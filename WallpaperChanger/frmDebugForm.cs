namespace WallpaperChanger
{
    public partial class frmDebugForm : Form
    {
        public frmDebugForm()
        {
            InitializeComponent();
        }

        private void frmDebugForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => { GetDataAndDisplay(); };
            timer.Start();
        }

        void GetDataAndDisplay()
        {
            //Task.Run(() =>
            //{
            lblKeywords.Text = "Keywords: " + Settings.Default.Keywords;
            lblCurrentPageNo.Text = "Current Page No: " + Settings.Default.CurrentPageNo;
            lblMaxPageNo.Text = "Max Page No: " + Settings.Default.MaxPageNo;
            lblSeed.Text = "Seed: " + Settings.Default.Seed;
            lblWallpaperHistoryCount.Text = "Wallpaper History Count: " + Settings.Default.WallpaperHistory.Split(',').Length;

            frmMain form = (frmMain)Application.OpenForms["frmMain"];
            if (form != null)
            {
                List<WallpaperInfo> wallpapers = form.GetWallpaperObject();

                listBoxCurrentWallpapers.Items.Clear();
                foreach (WallpaperInfo wi in wallpapers)
                {
                    listBoxCurrentWallpapers.Items.Add(Path.GetFileName(wi.URL));
                }

                lblCurrentWallpaperCount.Text = "Current Wallpaper Count: " + wallpapers.Count;
            }
            else
            {
                lblCurrentWallpaperCount.Text = "Current Wallpaper Count: 0";
                listBoxCurrentWallpapers.Items.Clear();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmMain form = (frmMain)Application.OpenForms["frmMain"];
            form.applyNextWallpaper();
        }
    }
}
