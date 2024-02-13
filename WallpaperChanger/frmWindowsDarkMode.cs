namespace WallpaperChanger
{
    public partial class frmWindowsDarkMode : Form
    {
        private DarkModeCS DM = null;

        public frmWindowsDarkMode()
        {
            InitializeComponent();
            DM = new DarkModeCS(this);

            // set form positioning 
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        void defaultUIValues()
        {
            cbDarkHrs.Text = "8";
            cbDarkMins.Text = "00";
            cbDarkSS.Text = "PM";

            cbLightHrs.Text = "9";
            cbLightMins.Text = "00";
            cbLightSS.Text = "AM";

            cbActive.Checked = true;
        }

        void SaveChanges()
        {
            string darkModeTime = cbDarkHrs.Text + ":" + cbDarkMins.Text + " " + cbDarkSS.Text;
            string lightModeTime = cbLightHrs.Text + ":" + cbLightMins.Text + " " + cbLightSS.Text;

            Settings.Default.DarkModeStartsAt = darkModeTime;
            Settings.Default.LightModeStartsAt = lightModeTime;
            Settings.Default.Save();

            // refreshing theme timer
            Task.Run(() =>
            {
                frmMain form = ((frmMain)Application.OpenForms["frmMain"]);
                if (form != null)
                {
                    form.WindowsThemeSettingsChanged();
                }
            });

            // notifying user about saved changes
            MessageBox.Show("Settings have been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void RestoreUIValues()
        {
            string darkModeTime = Settings.Default.DarkModeStartsAt;
            cbDarkHrs.Text = darkModeTime.Split(':').First();
            cbDarkMins.Text = darkModeTime.Split(" ").First().Split(':').Last();
            cbDarkSS.Text = darkModeTime.Split(" ").Last();

            string lightModeTime = Settings.Default.LightModeStartsAt;
            cbLightHrs.Text = lightModeTime.Split(':').First();
            cbLightMins.Text = lightModeTime.Split(" ").First().Split(':').Last();
            cbLightSS.Text = lightModeTime.Split(" ").Last();

            cbActive.Checked = Settings.Default.AutoThemeChange;
        }

        private void WallpaperChangerWithDarkMode_Load(object sender, EventArgs e)
        {
            defaultUIValues();
            RestoreUIValues();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
