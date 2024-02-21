namespace WallpaperChanger
{
    partial class frmWallpaperList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWallpaperList));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnNextPage = new Button();
            btnPrevPage = new Button();
            lblPageInfo = new Label();
            btnRefresh = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.CausesValidation = false;
            flowLayoutPanel1.Location = new Point(0, 53);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1334, 658);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNextPage
            // 
            btnNextPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNextPage.Location = new Point(1237, 12);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(93, 34);
            btnNextPage.TabIndex = 13;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrevPage.Location = new Point(1040, 12);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(93, 34);
            btnPrevPage.TabIndex = 14;
            btnPrevPage.Text = "Prev Page";
            btnPrevPage.UseVisualStyleBackColor = true;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(1138, 19);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(91, 20);
            lblPageInfo.TabIndex = 15;
            lblPageInfo.Text = "<Page Info>";
            lblPageInfo.Click += lblPageInfo_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(941, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(93, 34);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(280, 25);
            label1.TabIndex = 17;
            label1.Text = "Double Click to set as wallpaper";
            // 
            // frmWallpaperList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 711);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(lblPageInfo);
            Controls.Add(btnPrevPage);
            Controls.Add(btnNextPage);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmWallpaperList";
            Text = "Wallpaper List";
            Load += frmWallpaperList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnNextPage;
        private Button btnPrevPage;
        private Label lblPageInfo;
        private Button btnRefresh;
        private Label label1;
    }
}