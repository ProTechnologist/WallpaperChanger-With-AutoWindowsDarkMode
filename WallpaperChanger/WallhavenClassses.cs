namespace WallpaperChanger
{

    public class WallpaperInfo
    {
        public string URL { get; set; }
        public string Thumbnail { get; set; }
        public string Path { get; set; }
    }

    #region Generated classes for Wallhaven json object
    public class WallhavenResponse
    {
        public WallpaperData[] data { get; set; }
        public Meta meta { get; set; }
    }

    public class Meta
    {
        public int current_page { get; set; }
        public int last_page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public object query { get; set; }
        public object seed { get; set; }
    }

    public class WallpaperData
    {
        public string id { get; set; }
        public string url { get; set; }
        public string short_url { get; set; }
        public int views { get; set; }
        public int favorites { get; set; }
        public string source { get; set; }
        public string purity { get; set; }
        public string category { get; set; }
        public int dimension_x { get; set; }
        public int dimension_y { get; set; }
        public string resolution { get; set; }
        public string ratio { get; set; }
        public int file_size { get; set; }
        public string file_type { get; set; }
        public string created_at { get; set; }
        public string[] colors { get; set; }
        public string path { get; set; }
        public Thumbs thumbs { get; set; }
    }

    public class Thumbs
    {
        public string large { get; set; }
        public string original { get; set; }
        public string small { get; set; }
    }

    #endregion

}
