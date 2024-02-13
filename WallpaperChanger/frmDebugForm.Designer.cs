namespace WallpaperChanger
{
    partial class frmDebugForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCurrentPageNo = new Label();
            lblMaxPageNo = new Label();
            lblWallpaperHistoryCount = new Label();
            listBoxCurrentWallpapers = new ListBox();
            lblCurrentWallpaperCount = new Label();
            btnNext = new Button();
            lblSeed = new Label();
            lblKeywords = new Label();
            SuspendLayout();
            // 
            // lblCurrentPageNo
            // 
            lblCurrentPageNo.AutoSize = true;
            lblCurrentPageNo.Location = new Point(12, 33);
            lblCurrentPageNo.Name = "lblCurrentPageNo";
            lblCurrentPageNo.Size = new Size(125, 21);
            lblCurrentPageNo.TabIndex = 0;
            lblCurrentPageNo.Text = "Current Page No";
            // 
            // lblMaxPageNo
            // 
            lblMaxPageNo.AutoSize = true;
            lblMaxPageNo.Location = new Point(12, 54);
            lblMaxPageNo.Name = "lblMaxPageNo";
            lblMaxPageNo.Size = new Size(101, 21);
            lblMaxPageNo.TabIndex = 0;
            lblMaxPageNo.Text = "Max Page No";
            // 
            // lblWallpaperHistoryCount
            // 
            lblWallpaperHistoryCount.AutoSize = true;
            lblWallpaperHistoryCount.Location = new Point(12, 96);
            lblWallpaperHistoryCount.Name = "lblWallpaperHistoryCount";
            lblWallpaperHistoryCount.Size = new Size(180, 21);
            lblWallpaperHistoryCount.TabIndex = 0;
            lblWallpaperHistoryCount.Text = "Wallpaper History Count";
            // 
            // listBoxCurrentWallpapers
            // 
            listBoxCurrentWallpapers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxCurrentWallpapers.FormattingEnabled = true;
            listBoxCurrentWallpapers.ItemHeight = 21;
            listBoxCurrentWallpapers.Location = new Point(17, 159);
            listBoxCurrentWallpapers.Name = "listBoxCurrentWallpapers";
            listBoxCurrentWallpapers.Size = new Size(205, 382);
            listBoxCurrentWallpapers.TabIndex = 1;
            // 
            // lblCurrentWallpaperCount
            // 
            lblCurrentWallpaperCount.AutoSize = true;
            lblCurrentWallpaperCount.Location = new Point(12, 129);
            lblCurrentWallpaperCount.Name = "lblCurrentWallpaperCount";
            lblCurrentWallpaperCount.Size = new Size(183, 21);
            lblCurrentWallpaperCount.TabIndex = 0;
            lblCurrentWallpaperCount.Text = "Current Wallpaper Count";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(17, 547);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(205, 36);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next Wallapper";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblSeed
            // 
            lblSeed.AutoSize = true;
            lblSeed.Location = new Point(12, 75);
            lblSeed.Name = "lblSeed";
            lblSeed.Size = new Size(44, 21);
            lblSeed.TabIndex = 0;
            lblSeed.Text = "Seed";
            // 
            // lblKeywords
            // 
            lblKeywords.AutoSize = true;
            lblKeywords.Location = new Point(12, 12);
            lblKeywords.Name = "lblKeywords";
            lblKeywords.Size = new Size(78, 21);
            lblKeywords.TabIndex = 0;
            lblKeywords.Text = "Keywords";
            // 
            // frmDebugForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 589);
            Controls.Add(btnNext);
            Controls.Add(listBoxCurrentWallpapers);
            Controls.Add(lblCurrentWallpaperCount);
            Controls.Add(lblWallpaperHistoryCount);
            Controls.Add(lblSeed);
            Controls.Add(lblMaxPageNo);
            Controls.Add(lblKeywords);
            Controls.Add(lblCurrentPageNo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDebugForm";
            Text = "frmDebugForm";
            Load += frmDebugForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentPageNo;
        private Label lblMaxPageNo;
        private Label lblWallpaperHistoryCount;
        private ListBox listBoxCurrentWallpapers;
        private Label lblCurrentWallpaperCount;
        private Button btnNext;
        private Label lblSeed;
        private Label lblKeywords;
    }
}