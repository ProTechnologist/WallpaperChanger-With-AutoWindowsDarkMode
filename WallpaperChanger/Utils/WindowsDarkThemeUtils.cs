using Microsoft.Win32;
using System.Globalization;
using System.Runtime.InteropServices;

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
        #region win32 code to send request to OS
        // Define the constants for the Windows messages
        private const int HWND_BROADCAST = 0xffff;
        private const int WM_SETTINGCHANGE = 0x001A;
        private const int WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320;
        private const int SMTO_BLOCK = 0x0001;

        // Define the P/Invoke methods for sending messages
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessageTimeoutW(IntPtr hWnd, int Msg, IntPtr wParam, string lParam, uint fuFlags, uint uTimeout, out IntPtr lpdwResult);


        #endregion

        private const string RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        private const string RegistryValueName = "AppsUseLightTheme";

        public void ToggleWindowAppTheme()
        {
            Task.Run(() =>
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
                        SendTimeooutMsgToWindows();
                    }
                }
            });
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
                    SendTimeooutMsgToWindows();
                }
            }
        }

        public void ChangeScheduledWindowAppTheme()
        {
            Task.Run(() =>
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
            });
        }

        void SendTimeooutMsgToWindows()
        {
            IntPtr result;
            SendMessageTimeoutW((IntPtr)HWND_BROADCAST, WM_SETTINGCHANGE, IntPtr.Zero, "ImmersiveColorSet", SMTO_BLOCK, 1000, out result);
            SendMessageTimeoutW((IntPtr)HWND_BROADCAST, WM_DWMCOLORIZATIONCOLORCHANGED, IntPtr.Zero, null, SMTO_BLOCK, 1000, out result);
        }

    }
}
