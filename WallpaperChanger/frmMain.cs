using System.Windows.Forms.Design;
using WallpaperChanger.Utils;

namespace WallpaperChanger
{
    public partial class frmMain : Form
    {
        private DarkModeCS DM = null;

        WallhavenAutoWallpaperChanger wallpaperManager = new WallhavenAutoWallpaperChanger();
        WindowsDarkThemeUtils windowDarkModeManager = new WindowsDarkThemeUtils();

        System.Timers.Timer wallpaperTimer;
        System.Timers.Timer windowThemeTimer;

        public frmMain()
        {
            InitializeComponent();
            DM = new DarkModeCS(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();


            StartWallpaperTimer();
            StartWindowThemeTimer();

            // uncomment following line of code only for debugging purposes
            //new frmDebugForm().Show();
            //new frmTestForm().Show();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            applyNextWallpaper();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wallpaperSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmWallhavenSettings().Show();
        }

        private void darkModeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmWindowsDarkMode().Show();
        }

        private void nextWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applyNextWallpaper();
        }

        public void applyNextWallpaper()
        {
            Task.Run(() =>
            {
                wallpaperManager.ApplyNextWallpaper();
            });
        }

        public void WallpaperSettingsChanged()
        {

            wallpaperManager.ResetFilters();
            wallpaperManager.UpdateWallpaperList();
            StartWallpaperTimer();
        }

        void StartWallpaperTimer()
        {
            #region checking if auto wallpaper changer is enabled
            if (!Settings.Default.AutoWallpaperChange)
            {
                #region disable timer if already running
                if (wallpaperTimer.Enabled)
                {
                    wallpaperTimer.Stop();
                    wallpaperTimer.Enabled = false;
                    wallpaperTimer.Dispose();
                }
                #endregion

                return;
            }
            #endregion

            if (wallpaperTimer != null)
            {
                wallpaperTimer.Stop();
                wallpaperTimer.Enabled = false;
                wallpaperTimer.Dispose();
            }

            wallpaperTimer = new System.Timers.Timer();

            int minutes = 0;

            if (Settings.Default.ChangeInterval.ToLower() == "minute") minutes = 1;
            if (Settings.Default.ChangeInterval.ToLower() == "5 minutes") minutes = 5;
            if (Settings.Default.ChangeInterval.ToLower() == "10 minutes") minutes = 10;
            if (Settings.Default.ChangeInterval.ToLower() == "15 minutes") minutes = 15;
            if (Settings.Default.ChangeInterval.ToLower() == "30 minutes") minutes = 30;
            if (Settings.Default.ChangeInterval.ToLower() == "hour") minutes = 60;
            if (Settings.Default.ChangeInterval.ToLower() == "6 hours") minutes = 360;

            #region validation

            if (minutes == 0) return;

            #endregion

            wallpaperTimer.Interval = minutes * 60 * 1000; // minutes * seconds * 1000 will give milliseconds
            wallpaperTimer.Elapsed += (sender, e) => { applyNextWallpaper(); };
            wallpaperTimer.Start();

            // manually triggering change wallpaper as timer will kick after first interval elapsed
            applyNextWallpaper();
        }

        void StartWindowThemeTimer()
        {
            #region checking if window auto theme changer is enabled
            if (!Settings.Default.AutoThemeChange)
            {
                #region disable timer if already running
                if (windowThemeTimer.Enabled)
                {
                    windowThemeTimer.Stop();
                    windowThemeTimer.Enabled = false;
                    windowThemeTimer.Dispose();
                }
                #endregion

                return;
            }
            #endregion

            windowThemeTimer = new System.Timers.Timer();
            windowThemeTimer.Interval = 60 * 1000; // 60 seconds (in milliseconds)
            windowThemeTimer.Elapsed += (sender, e) => { windowDarkModeManager.ChangeScheduledWindowAppTheme(); };
            windowThemeTimer.Start();
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmWallpaperHistory().Show();
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Toggle window theme ...");
            new WindowsDarkThemeUtils().ToggleWindowAppTheme();
        }

        // following function is only for debugging for debug form
        public List<WallpaperInfo> GetWallpaperObject()
        {
            return wallpaperManager.GetWallpapersObject();
        }

        private void frmMain_VisibleChanged(object sender, EventArgs e)
        {
            //base.OnVisibleChanged(e);
            //this.Visible = false;
        }
    }
}
