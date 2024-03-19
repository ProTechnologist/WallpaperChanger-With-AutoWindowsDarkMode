using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Reflection;

namespace WallpaperChanger.Utils
{
    public class WallhavenAutoWallpaperChanger
    {
        List<WallpaperInfo> Wallpapers = new List<WallpaperInfo>();

        #region private helper methods
        string GetUrl()
        {
            // sample URL
            // https://wallhaven.cc/api/v1/search?q=cars&sorting=views&categories=001&purity=010&ratios=16x9

            string URL = "https://wallhaven.cc/api/v1/search";

            // keywords
            URL += "?q=" + Settings.Default.Keywords;

            // compute categories string
            string categories = ""; // format 000 (general/anime/people)
            categories += Settings.Default.IsGeneral ? "1" : "0";
            categories += Settings.Default.IsAnime ? "1" : "0";
            categories += Settings.Default.IsPeople ? "1" : "0";
            URL += "&categories=" + categories;

            // commputing Sorting
            if (Settings.Default.Sorting.IsNotEmpty()) URL += "&sorting=" + Settings.Default.Sorting;

            // computing ratio
            if (Settings.Default.Ratio.IsNotEmpty()) URL += "&ratios=" + Settings.Default.Ratio;

            // compute purity string
            string purity = "100"; // format 000 (sfw/sketchy/nsfw) nsfw not avaiable without user app key, FYI.
            if (Settings.Default.Purity.ToLower() == "sfw") purity = "100";
            else if (Settings.Default.Purity.ToLower() == "sketchy") purity = "010";
            else if (Settings.Default.Purity.ToLower() == "sketchy") purity = "010";
            else if (Settings.Default.Purity.ToLower() == "both") purity = "110";
            else if (Settings.Default.Purity.ToLower() == "nsfw only") purity = "001";
            URL += "&purity=" + purity;

            // verifying that the current page is properly set
            if (Settings.Default.CurrentPageNo < 1)
            {
                Settings.Default.CurrentPageNo = 1;
            }

            // add page size to the URL
            URL += "&page=" + Settings.Default.CurrentPageNo;


            // API key
            if (Settings.Default.ApiKey.IsNotEmpty())
            {
                URL += "&apikey=" + Settings.Default.ApiKey;
            }

            return URL;
        }

        public void ResetFilters()
        {
            // reset page counter
            Settings.Default.CurrentPageNo = 0;
            Settings.Default.MaxPageNo = 0;
            Settings.Default.Seed = string.Empty;
            Settings.Default.Save();

            //reset current set of cached wallpapers
            Wallpapers.Clear();
        }

        public void UpdateWallpaperList()
        {
            Task.Run(() =>
            {
                // fetching fresh list of wallpapers
                string api_url = GetUrl();
                HttpClient Client = new HttpClient();
                HttpResponseMessage response = Client.GetAsync(api_url).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    WallhavenResponse list = JsonConvert.DeserializeObject<WallhavenResponse>(json);

                    // update page index
                    Settings.Default.CurrentPageNo = list.meta.current_page;
                    Settings.Default.MaxPageNo = list.meta.total;
                    Settings.Default.Seed = list.meta.seed == null ? string.Empty : list.meta.seed.ToString();
                    Settings.Default.Save();

                    // update wallpaper collection
                    Wallpapers.Clear();

                    foreach (WallpaperData wallpaper in list.data)
                    {
                        WallpaperInfo wi = new WallpaperInfo();
                        wi.URL = wallpaper.url;
                        wi.Path = wallpaper.path;
                        wi.Thumbnail = wallpaper.thumbs.large;

                        Wallpapers.Add(wi);
                    }
                }
            }).Wait();
        }

        WallpaperInfo ComputeRandomWallpaperURL()
        {
            #region validation
            if (Wallpapers.Count == 0) return null;
            #endregion

            int index = new Random().Next(0, Wallpapers.Count - 1);
            WallpaperInfo random_wallapper = Wallpapers[index];

            return random_wallapper;
        }

        string GetCurrentFolder()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        string DownloadWallpaper(WallpaperInfo wi)
        {
            #region validation
            if (wi == null) return string.Empty;
            #endregion

            if (wi != null && wi.Path.IsNotEmpty())
            {
                string filename = GetCurrentFolder() + "\\" + wi.Path.GetFileName();
                byte[] fileBytes = new HttpClient().GetByteArrayAsync(wi.Path).GetAwaiter().GetResult();
                File.WriteAllBytes(filename, fileBytes);
                File.WriteAllBytesAsync(filename, fileBytes).GetAwaiter().GetResult();
                return filename;
            }
            return string.Empty;
        }

        #endregion
        public void ApplyWallpaper(WallpaperInfo wi)
        {
            // download wallpaper
            string new_wallpaper = DownloadWallpaper(wi);

            #region wallpaper clean up (delete old wallpaper, rename current wallpaper and set as a wallpaper)

            // delete old wallpaper (if found)
            string[] old_wallpapers = Directory.GetFiles(GetCurrentFolder(), "wallpaper_*");
            foreach (string old_wallpaper in old_wallpapers)
            {
                File.Delete(old_wallpaper);
            }

            // rename new/downloaded wallpaper
            string new_wallpaper_name = $"wallpaper_{DateTime.Now.Ticks.ToString()}{Path.GetExtension(new_wallpaper)}";
            new FileInfo(new_wallpaper).MoveTo(new_wallpaper_name);

            new_wallpaper = new_wallpaper_name;

            #endregion

            // change wallpaper

            // following line of code (approach) does change walllpaper but when we switch between virtual desktops
            // it shows a solid background color for a moment, and then wallpaper appears up
            // everything's fast but the overall experience is weird...
            //WallpaperChangerUtil.ChangeWallpaper(GetCurrentFolder() + "\\" + new_wallpaper);

            // so instead, let's se external (and functional solution for it)

            WallpaperChangerByExe.ChangeWallpaper(GetCurrentFolder() + "\\" + new_wallpaper);

            #region add wallpaper to history
            if (Settings.Default.WallpaperHistory.IsNotEmpty())
            {
                List<string> id_list = Settings.Default.WallpaperHistory.Split(',').Distinct().ToList();
                if (id_list.Count >= 250)
                {
                    id_list.RemoveAt(0);
                }

                id_list.Add(wi.URL.GetFileName());
                Settings.Default.WallpaperHistory = string.Join(",", id_list);
            }
            else
            {
                Settings.Default.WallpaperHistory += wi.URL.GetFileName();
            }
            Settings.Default.Save();
            #endregion
        }

        public void ApplyNextWallpaper()
        {
            if (Wallpapers.Count == 0)
            {
                // increase page counter and then load up the wallpapers
                if (Settings.Default.CurrentPageNo == 0 || Settings.Default.CurrentPageNo == Settings.Default.MaxPageNo)
                {
                    Settings.Default.CurrentPageNo = 1;
                }
                else
                {
                    Settings.Default.CurrentPageNo++;
                }

                Settings.Default.Save();
                UpdateWallpaperList();
            }

            // i guess, noo point in randomizing unknown wallpapers but keeping the functionality
            //WallpaperInfo next_wallpaper = ComputeRandomWallpaperURL();

            // now intead, going for sequential list of wallpapers
            WallpaperInfo next_wallpaper = Wallpapers.FirstOrDefault();

            // remove selected wallpaper from current wallpaper collection
            // this will avoid re-appling this same wallpaper again
            Wallpapers.Remove(next_wallpaper);

            #region validation

            if (next_wallpaper == null) return;

            #endregion

            string temp_wallpaper_name = Path.GetFileName(next_wallpaper.URL);

            // validation - null/empty check
            if (string.IsNullOrEmpty(temp_wallpaper_name)) return;

            #region condition - avoid applying any of previous wallpapers

            bool already_applied = false;
            already_applied = Settings.Default.WallpaperHistory
                                                    .Split(',')
                                                    .ToList()
                                                    .Contains(temp_wallpaper_name);
            if (already_applied)
            {
                ApplyNextWallpaper();
                return;
            }

            #endregion

            ApplyWallpaper(next_wallpaper);
        }

        // following function is only for debugging purposes for debug form
        public List<WallpaperInfo> GetWallpapersObject()
        {
            return Wallpapers;
        }
    }
}
