using System.Threading;

namespace WallpaperChanger
{
    internal static class Program
    {
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {

            string appName = Application.ProductName;
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("Application is already running.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //app is already running! Exiting the application
                return;
            }


            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}