using System.Runtime.InteropServices;
using WallpaperChanger.Utils;

namespace WallpaperChanger
{
    public partial class frmWallhavenSettings : Form
    {
        private DarkModeCS DM = null;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public frmWallhavenSettings()
        {
            InitializeComponent();
            DM = new DarkModeCS(this);

            // set form positioning 
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        #region change wallpaper code
        //public const int SPI_SETDESKWALLPAPER = 20;
        //public const int SPIF_UPDATEINIFILE = 1;
        //public const int SPIF_SENDCHANGE = 2;

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        //void ChangeWallpaper(string path)
        //{
        //    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
        //}
        #endregion

        void setDefaultUIOptions()
        {
            cbSorting.SelectedIndex = 0;
            cbRatio.SelectedIndex = 0;
            cbPurity.SelectedIndex = 0;
            cbChangeInterval.SelectedIndex = 0;
            cbActive.Checked = true;

            cbGeneral.Checked = true;
            cbChangeInterval.SelectedIndex = 1;

            txtApiKey.Text = string.Empty;

            txtKeywords.Text = "Nature";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDefaultUIOptions();
            RestoreSettings();
            ConfigureSaveButtonTimer();
        }

        void OpenConfigWindow()
        {
            //Get screen resolution
            Rectangle res = Screen.PrimaryScreen.Bounds;

            // Calculate location (etc. 1366 Width - form size...)
            this.Location = new Point(res.Width - Size.Width, res.Height - Size.Height);

            // show form
            this.Show();
        }

        #region save and restore settings
        void SaveChanges()
        {
            // saving keywords
            Settings.Default.Keywords = txtKeywords.Text.Trim();

            // saving categories
            Settings.Default.IsGeneral = cbGeneral.Checked;
            Settings.Default.IsAnime = cbAnime.Checked;
            Settings.Default.IsPeople = cbPeople.Checked;

            // saving filters
            Settings.Default.Sorting = cbSorting.Text;
            Settings.Default.Ratio = cbRatio.Text;
            Settings.Default.Purity = cbPurity.Text;

            // change interval
            Settings.Default.ChangeInterval = cbChangeInterval.Text;
            Settings.Default.AutoWallpaperChange = cbActive.Checked;

            // API key
            Settings.Default.ApiKey = txtApiKey.Text;

            // saving changes
            Settings.Default.Save();

            // refreshing wallpaper cache
            Task.Run(() =>
            {
                frmMain form = ((frmMain)Application.OpenForms["frmMain"]);
                if (form != null)
                {
                    form.WallpaperSettingsChanged();
                }
            });

            // notifying user about saved changes
            //MessageBox.Show("Settings have been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void RestoreSettings()
        {
            txtKeywords.Text = Settings.Default.Keywords;
            cbGeneral.Checked = Settings.Default.IsGeneral;
            cbAnime.Checked = Settings.Default.IsAnime;
            cbPeople.Checked = Settings.Default.IsPeople;

            cbSorting.Text = Settings.Default.Sorting;
            cbRatio.Text = Settings.Default.Ratio;
            cbPurity.Text = Settings.Default.Purity;
            cbChangeInterval.Text = Settings.Default.ChangeInterval;

            cbActive.Checked = Settings.Default.AutoWallpaperChange;

            txtApiKey.Text = Settings.Default.ApiKey;
        }

        #endregion

        void ConfigureSaveButtonTimer()
        {
            timer.Interval = 500;

            timer.Tick += (sender, e) =>
            {
                btnSaveChanges.Text = "Saved Successfully";
                Thread.Sleep(500);
                btnSaveChanges.Text = "Save Changes";
                btnSaveChanges.Enabled = true;

                timer.Stop();
            };
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = false;
            btnSaveChanges.Text = "Saved!";

            timer.Start();
            SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmWallpaperList().Show();
        }
    }
}