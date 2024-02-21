namespace WallpaperChanger
{
    partial class frmWallhavenSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWallhavenSettings));
            cbGeneral = new CheckBox();
            groupBox1 = new GroupBox();
            cbPeople = new CheckBox();
            cbAnime = new CheckBox();
            cbSorting = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbPurity = new ComboBox();
            cbRatio = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            cbActive = new CheckBox();
            cbChangeInterval = new ComboBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            txtKeywords = new TextBox();
            btnSaveChanges = new Button();
            groupBox5 = new GroupBox();
            txtApiKey = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // cbGeneral
            // 
            cbGeneral.AutoSize = true;
            cbGeneral.Location = new Point(37, 32);
            cbGeneral.Name = "cbGeneral";
            cbGeneral.Size = new Size(79, 24);
            cbGeneral.TabIndex = 3;
            cbGeneral.Text = "General";
            cbGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbPeople);
            groupBox1.Controls.Add(cbAnime);
            groupBox1.Controls.Add(cbGeneral);
            groupBox1.Location = new Point(12, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 64);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wallpaper Category";
            // 
            // cbPeople
            // 
            cbPeople.AutoSize = true;
            cbPeople.Location = new Point(199, 32);
            cbPeople.Name = "cbPeople";
            cbPeople.Size = new Size(73, 24);
            cbPeople.TabIndex = 3;
            cbPeople.Text = "People";
            cbPeople.UseVisualStyleBackColor = true;
            // 
            // cbAnime
            // 
            cbAnime.AutoSize = true;
            cbAnime.Location = new Point(122, 32);
            cbAnime.Name = "cbAnime";
            cbAnime.Size = new Size(71, 24);
            cbAnime.TabIndex = 3;
            cbAnime.Text = "Anime";
            cbAnime.UseVisualStyleBackColor = true;
            // 
            // cbSorting
            // 
            cbSorting.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSorting.FormattingEnabled = true;
            cbSorting.Items.AddRange(new object[] { "", "Random", "Toplist", "Views", "Relevance", "Favorites" });
            cbSorting.Location = new Point(122, 26);
            cbSorting.Name = "cbSorting";
            cbSorting.Size = new Size(150, 28);
            cbSorting.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 29);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 6;
            label1.Text = "Sorting";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbPurity);
            groupBox2.Controls.Add(cbRatio);
            groupBox2.Controls.Add(cbSorting);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 131);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filters";
            // 
            // cbPurity
            // 
            cbPurity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPurity.FormattingEnabled = true;
            cbPurity.Items.AddRange(new object[] { "SFW", "Sketchy", "Both", "NSFW Only" });
            cbPurity.Location = new Point(122, 94);
            cbPurity.Name = "cbPurity";
            cbPurity.Size = new Size(150, 28);
            cbPurity.TabIndex = 5;
            // 
            // cbRatio
            // 
            cbRatio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRatio.FormattingEnabled = true;
            cbRatio.Items.AddRange(new object[] { "16x9", "16x10" });
            cbRatio.Location = new Point(122, 60);
            cbRatio.Name = "cbRatio";
            cbRatio.Size = new Size(150, 28);
            cbRatio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 97);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Purity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 63);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "Ratio";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.wallhaven_logo;
            pictureBox1.Location = new Point(31, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 56);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbActive);
            groupBox3.Controls.Add(cbChangeInterval);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 402);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(278, 106);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Auto Wallpaper Change";
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new Point(122, 26);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(64, 24);
            cbActive.TabIndex = 7;
            cbActive.Text = "Acive";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // cbChangeInterval
            // 
            cbChangeInterval.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChangeInterval.FormattingEnabled = true;
            cbChangeInterval.Items.AddRange(new object[] { "Minute", "5 minutes ", "10 minutes", "15 minutes", "30 minutes", "Hour", "6 hours" });
            cbChangeInterval.Location = new Point(122, 56);
            cbChangeInterval.Name = "cbChangeInterval";
            cbChangeInterval.Size = new Size(150, 28);
            cbChangeInterval.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 59);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 6;
            label4.Text = "Every";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtKeywords);
            groupBox4.Location = new Point(12, 65);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(278, 59);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Keywords";
            // 
            // txtKeywords
            // 
            txtKeywords.Location = new Point(6, 26);
            txtKeywords.Name = "txtKeywords";
            txtKeywords.Size = new Size(266, 27);
            txtKeywords.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(12, 514);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(150, 38);
            btnSaveChanges.TabIndex = 12;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtApiKey);
            groupBox5.Location = new Point(12, 337);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(278, 59);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "API Key";
            // 
            // txtApiKey
            // 
            txtApiKey.Location = new Point(6, 26);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.Size = new Size(266, 27);
            txtApiKey.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(211, 514);
            button2.Name = "button2";
            button2.Size = new Size(79, 38);
            button2.TabIndex = 13;
            button2.Text = "List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmWallhavenSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 561);
            Controls.Add(button2);
            Controls.Add(groupBox5);
            Controls.Add(btnSaveChanges);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmWallhavenSettings";
            ShowInTaskbar = false;
            Text = "Auto Wallpaper Changer";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox cbGeneral;
        private GroupBox groupBox1;
        private CheckBox cbPeople;
        private CheckBox cbAnime;
        private ComboBox cbSorting;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cbRatio;
        private Label label2;
        private ComboBox cbPurity;
        private Label label3;
        private Button btNextWallpaper;
        private PictureBox pictureBox1;
        private Button button1;
        private GroupBox groupBox3;
        private ComboBox cbChangeInterval;
        private Label label4;
        private GroupBox groupBox4;
        private TextBox txtKeywords;
        private Button btnSaveChanges;
        private CheckBox cbActive;
        private GroupBox groupBox5;
        private TextBox txtApiKey;
        private Button button2;
    }
}