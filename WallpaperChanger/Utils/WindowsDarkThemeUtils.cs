using Microsoft.Win32;
using System.Globalization;

namespace WallpaperChanger.Utils
{
    /* Folder:      HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize
     * Key Name:    AppsUseLightTheme
     * 
     * Possible Values:
     *      0 = dark mode
     *      1 = light mode
    */
    public class WindowsDarkThemeUtils
    {
        private const string RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const string RegistryValueName = "AppsUseLightTheme";

        public void ToggleWindowAppTheme()
        {
            using var key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, true);
            var value = key?.GetValue(RegistryValueName);
            if (value != null)
            {
                object new_value = value.ToString() == "1" ? "0" : "1";

                if (value.ToString() != new_value.ToString())
                {
                    key.SetValue(RegistryValueName, new_value, RegistryValueKind.DWord);
                    key.Close();
                }
            }
        }

        void EnableWindowAppTheme(bool IsDarkTheme)
        {
            using var key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, true);
            var value = key?.GetValue(RegistryValueName);
            if (value != null)
            {
                object new_value = IsDarkTheme ? "0" : "1";
                if (value.ToString() != new_value.ToString())
                {
                    key.SetValue(RegistryValueName, new_value, RegistryValueKind.DWord);
                    key.Close();
                }
            }
        }

        public void ChangeScheduledWindowAppTheme()
        {

            #region validation
            if (!Settings.Default.LightModeStartsAt.IsNotEmpty() && !Settings.Default.DarkModeStartsAt.IsNotEmpty()) return;
            #endregion

            string current = DateTime.Now.ToString("hh:mm tt");

            DateTime darkThemeStart = DateTime.ParseExact(Settings.Default.DarkModeStartsAt, "h:mm tt", CultureInfo.InvariantCulture);
            DateTime lightThemeStart = DateTime.ParseExact(Settings.Default.LightModeStartsAt, "h:mm tt", CultureInfo.InvariantCulture);
            DateTime currentTime = DateTime.ParseExact(current, "h:mm tt", CultureInfo.InvariantCulture);

            // Check if the current time is within the dark theme range
            if (currentTime >= darkThemeStart || currentTime < lightThemeStart)
            {
                // Set the theme to dark
                EnableWindowAppTheme(true);
            }
            else
            {
                // Set the theme to light
                EnableWindowAppTheme(false);
            }
        }

    }
}
