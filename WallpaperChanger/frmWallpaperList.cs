using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallpaperChanger.Utils;

namespace WallpaperChanger
{
    public partial class frmWallpaperList : Form
    {
        private DarkModeCS DM = null;

        List<PictureBox> boxes = new List<PictureBox>();
        WallhavenAutoWallpaperChanger WallpaperChanger = new WallhavenAutoWallpaperChanger();
        public frmWallpaperList()
        {
            InitializeComponent();
            DM = new DarkModeCS(this);

            this.StartPosition = FormStartPosition.Manual;

            if (Application.OpenForms.OfType<frmWallhavenSettings>().Count() == 1)
            {
                // 320 is the width of frmWallhavenSettings form
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (this.Width + 315), Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            }
            else
            {
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            }
        }

        private void frmWallpaperList_Load(object sender, EventArgs e)
        {
            RefreshWallpapers();
        }

        void RefreshWallpapers()
        {
            LoadPage(null);
            UpdatePageLabel();
        }

        void UpdatePageLabel()
        {
            lblPageInfo.Text = $"({Settings.Default.CurrentPageNo} / {Settings.Default.MaxPageNo})";

        }

        void LoadPage(bool? isNextPage)
        {
            Task.Run(() =>
            {
                if (isNextPage.HasValue)
                {
                    if (isNextPage.Value) Settings.Default.CurrentPageNo++;
                    if (!isNextPage.Value) Settings.Default.CurrentPageNo--;

                    if (Settings.Default.CurrentPageNo < 1) Settings.Default.CurrentPageNo = 1;

                    Settings.Default.Save();
                }

                WallpaperChanger.UpdateWallpaperList();
                boxes.Clear();
                foreach (var wi in WallpaperChanger.GetWallpapersObject())
                {
                    PictureBox picture_box = new PictureBox();
                    picture_box.ImageLocation = wi.Thumbnail;

                    picture_box.SizeMode = PictureBoxSizeMode.AutoSize;
                    picture_box.Tag = wi;



                    picture_box.DoubleClick += (sender, e) =>
                    {
                        Task.Run(() =>
                        {
                            WallpaperInfo current_wi = (sender as PictureBox).Tag as WallpaperInfo;
                            if (current_wi != null)
                            {
                                WallpaperChanger.ApplyWallpaper(current_wi);
                            }
                        });
                    };

                    boxes.Add(picture_box);
                }
            }).Wait();

            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(boxes.ToArray());
            flowLayoutPanel1.ResumeLayout();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            LoadPage(false);
            UpdatePageLabel();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            LoadPage(true);
            UpdatePageLabel();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshWallpapers();
        }
    }
}
