namespace WallpaperChanger
{
    partial class frmWindowsDarkMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWindowsDarkMode));
            groupBox1 = new GroupBox();
            cbLightSS = new ComboBox();
            cbLightMins = new ComboBox();
            cbLightHrs = new ComboBox();
            label2 = new Label();
            cbDarkSS = new ComboBox();
            cbDarkMins = new ComboBox();
            cbDarkHrs = new ComboBox();
            label1 = new Label();
            btnSaveChanges = new Button();
            cbActive = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbActive);
            groupBox1.Controls.Add(cbLightSS);
            groupBox1.Controls.Add(cbLightMins);
            groupBox1.Controls.Add(cbLightHrs);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbDarkSS);
            groupBox1.Controls.Add(cbDarkMins);
            groupBox1.Controls.Add(cbDarkHrs);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 197);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dark Mode Settings";
            // 
            // cbLightSS
            // 
            cbLightSS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLightSS.FormattingEnabled = true;
            cbLightSS.Items.AddRange(new object[] { "AM", "PM" });
            cbLightSS.Location = new Point(216, 158);
            cbLightSS.Name = "cbLightSS";
            cbLightSS.Size = new Size(50, 28);
            cbLightSS.TabIndex = 3;
            // 
            // cbLightMins
            // 
            cbLightMins.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLightMins.FormattingEnabled = true;
            cbLightMins.Items.AddRange(new object[] { "00", "15", "30", "45" });
            cbLightMins.Location = new Point(160, 158);
            cbLightMins.Name = "cbLightMins";
            cbLightMins.Size = new Size(50, 28);
            cbLightMins.TabIndex = 4;
            // 
            // cbLightHrs
            // 
            cbLightHrs.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLightHrs.FormattingEnabled = true;
            cbLightHrs.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12 " });
            cbLightHrs.Location = new Point(104, 158);
            cbLightHrs.Name = "cbLightHrs";
            cbLightHrs.Size = new Size(50, 28);
            cbLightHrs.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 135);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 2;
            label2.Text = "Enable Light Mode At";
            // 
            // cbDarkSS
            // 
            cbDarkSS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDarkSS.FormattingEnabled = true;
            cbDarkSS.Items.AddRange(new object[] { "AM", "PM" });
            cbDarkSS.Location = new Point(216, 94);
            cbDarkSS.Name = "cbDarkSS";
            cbDarkSS.Size = new Size(50, 28);
            cbDarkSS.TabIndex = 1;
            // 
            // cbDarkMins
            // 
            cbDarkMins.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDarkMins.FormattingEnabled = true;
            cbDarkMins.Items.AddRange(new object[] { "00", "15", "30", "45" });
            cbDarkMins.Location = new Point(160, 94);
            cbDarkMins.Name = "cbDarkMins";
            cbDarkMins.Size = new Size(50, 28);
            cbDarkMins.TabIndex = 1;
            // 
            // cbDarkHrs
            // 
            cbDarkHrs.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDarkHrs.FormattingEnabled = true;
            cbDarkHrs.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12 " });
            cbDarkHrs.Location = new Point(104, 94);
            cbDarkHrs.Name = "cbDarkHrs";
            cbDarkHrs.Size = new Size(50, 28);
            cbDarkHrs.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 71);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 0;
            label1.Text = "Enable Dark Mode At";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveChanges.Location = new Point(86, 215);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(117, 38);
            btnSaveChanges.TabIndex = 13;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new Point(18, 31);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(218, 24);
            cbActive.TabIndex = 6;
            cbActive.Text = "Active (Auto Change Theme)";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // frmWindowsDarkMode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 261);
            Controls.Add(btnSaveChanges);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmWindowsDarkMode";
            Text = "Dark Mode Settings";
            Load += WallpaperChangerWithDarkMode_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cbDarkSS;
        private ComboBox cbDarkMins;
        private ComboBox cbDarkHrs;
        private Label label1;
        private ComboBox cbLightSS;
        private ComboBox cbLightMins;
        private ComboBox cbLightHrs;
        private Label label2;
        private Button btnSaveChanges;
        private CheckBox cbActive;
    }
}