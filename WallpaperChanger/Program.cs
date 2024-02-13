using System;
using System.Threading;
using WallpaperChanger.Utils;

namespace WallpaperChanger
{
    internal static class Program
    {
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {
            try
            {
                bool createdNew;
                mutex = new Mutex(true, Application.ProductName, out createdNew);

                if (!createdNew)
                {
                    MessageBox.Show("Application is already running.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                ApplicationConfiguration.Initialize();
                Application.Run(new frmMain());
            }
            catch (Exception ex)
            {
                ex.LogException();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}