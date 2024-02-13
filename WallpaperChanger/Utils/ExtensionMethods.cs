namespace WallpaperChanger.Utils
{
    public static class ExtensionMethods
    {
        public static bool IsNotEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static string GetFileName(this string value)
        {
            return new FileInfo(value).Name;
        }

        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }

        public static void LogException(this Exception exception)
        {
            if (exception != null)
            {
                System.Diagnostics.EventLog.WriteEntry("WallpaperChanger", exception.StackTrace,
                                       System.Diagnostics.EventLogEntryType.Error);
            }
        }
    }

}
