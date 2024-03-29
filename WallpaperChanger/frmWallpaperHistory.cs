﻿using System.Data;
using System.Diagnostics;
using WallpaperChanger.Utils;

namespace WallpaperChanger
{
    public partial class frmWallpaperHistory : Form
    {
        private DarkModeCS DM = null;

        List<PictureBox> boxes = null;

        public frmWallpaperHistory()
        {
            InitializeComponent();
            DM = new DarkModeCS(this);

            // set form positioning 
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Settings.Default.WallpaperHistory = "";
                Settings.Default.Save();
                flowLayoutPanel1.Controls.Clear();
            }
        }

        private void frmWallpaperHistory_Shown(object sender, EventArgs e)
        {
            LoadPreviousWallpapers();
        }

        void LoadPreviousWallpapers()
        {
            #region validation

            if (!Settings.Default.WallpaperHistory.IsNotEmpty()) return;

            #endregion

            Task.Run(() =>
            {
                List<string> IDs = Settings.Default.WallpaperHistory.Split(',').ToList();
                boxes = new List<PictureBox>();
                foreach (string id in IDs)
                {
                    PictureBox picture_box = new PictureBox();
                    picture_box.ImageLocation = $"https://th.wallhaven.cc/small/{id.Substring(0, 2)}/{id}.jpg";
                    picture_box.SizeMode = PictureBoxSizeMode.AutoSize;
                    picture_box.Tag = id; // $"https://wallhaven.cc/w/{id}";

                    picture_box.DoubleClick += Picture_box_DoubleClick;

                    boxes.Add(picture_box);
                }
            }).Wait();

            // desc sorting before processing
            boxes.Reverse();

            // loading up wallpaper boxes into othe UI
            flowLayoutPanel1.Controls.AddRange(boxes.ToArray());
            groupBox1.Text = $"Previous Wallpapers ({boxes.Count})";
        }

        private void Picture_box_DoubleClick(object? sender, EventArgs e)
        {
            string id = (sender as PictureBox).Tag.ToString();

            #region open wallpaper in the browse (removing this feature in favor of setting image as wallpaper)
            //Process.Start(new ProcessStartInfo()
            //{
            //    UseShellExecute = true,
            //    FileName = url
            //});
            #endregion

            // set image as wallpaper
            new WallhavenAutoWallpaperChanger().ApplyWallpaper(new WallpaperInfo()
            {
                URL = $"https://wallhaven.cc/w/{id}",
                Path = @$"https://w.wallhaven.cc/full/{id.Substring(0, 2)}/wallhaven-{id}.jpg"
            });
        }
    }
}
