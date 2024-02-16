using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperChanger.Utils
{
    public class WallpaperChangerByExe
    {
        static string exeName = "VirtualDesktop11.exe";
        static string exeResourceName = "WallpaperChanger.VirtualDesktop11.VirtualDesktop11.exe";

        /// <summary>
        /// Extract exe from embedded resources so it can be used to change wallpapers on all virtual desktops
        /// </summary>
        static string ExtractExe()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + exeName;
            using (var resourceToSave = Assembly.GetExecutingAssembly().GetManifestResourceStream(exeResourceName))
            {
                using (var output = File.OpenWrite(AppDomain.CurrentDomain.BaseDirectory + exeName))
                {
                    resourceToSave.CopyTo(output);
                }
                resourceToSave.Close();
            }
            return path;
        }

        public static void ChangeWallpaper(string imagePath)
        {
            string command = "AllWallpapers:" + imagePath;

            string exePath = ExtractExe();

            var startInfo = new ProcessStartInfo(exeName, command);
            startInfo.UseShellExecute = true;
            //startInfo.CreateNoWindow = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;     

            Process.Start(startInfo).WaitForExit();

            File.Delete(exePath);
        }
    }
}
