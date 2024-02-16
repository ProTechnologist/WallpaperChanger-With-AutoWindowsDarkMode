namespace WallpaperChanger
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            settingsToolStripMenuItem = new ToolStripMenuItem();
            wallpaperSettingsToolStripMenuItem = new ToolStripMenuItem();
            darkModeSettingsToolStripMenuItem = new ToolStripMenuItem();
            changeThemeToolStripMenuItem = new ToolStripMenuItem();
            lightThemeToolStripMenuItem = new ToolStripMenuItem();
            toggleWindowThemeMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Wallpaper Change (double click to change wallpaper)";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, changeThemeToolStripMenuItem, toggleWindowThemeMenuItem, toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(196, 114);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wallpaperSettingsToolStripMenuItem, darkModeSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(195, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // wallpaperSettingsToolStripMenuItem
            // 
            wallpaperSettingsToolStripMenuItem.Name = "wallpaperSettingsToolStripMenuItem";
            wallpaperSettingsToolStripMenuItem.Size = new Size(177, 22);
            wallpaperSettingsToolStripMenuItem.Text = "Wallpaper Settings";
            wallpaperSettingsToolStripMenuItem.Click += wallpaperSettingsToolStripMenuItem_Click;
            // 
            // darkModeSettingsToolStripMenuItem
            // 
            darkModeSettingsToolStripMenuItem.Name = "darkModeSettingsToolStripMenuItem";
            darkModeSettingsToolStripMenuItem.Size = new Size(177, 22);
            darkModeSettingsToolStripMenuItem.Text = "Dark Mode Settings";
            darkModeSettingsToolStripMenuItem.Click += darkModeSettingsToolStripMenuItem_Click;
            // 
            // changeThemeToolStripMenuItem
            // 
            changeThemeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightThemeToolStripMenuItem });
            changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            changeThemeToolStripMenuItem.Size = new Size(195, 22);
            changeThemeToolStripMenuItem.Text = "Tools";
            // 
            // lightThemeToolStripMenuItem
            // 
            lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            lightThemeToolStripMenuItem.Size = new Size(168, 22);
            lightThemeToolStripMenuItem.Text = "Wallpaper History";
            lightThemeToolStripMenuItem.Click += lightThemeToolStripMenuItem_Click;
            // 
            // toggleWindowThemeMenuItem
            // 
            toggleWindowThemeMenuItem.Name = "toggleWindowThemeMenuItem";
            toggleWindowThemeMenuItem.Size = new Size(195, 22);
            toggleWindowThemeMenuItem.Text = "Toggle Window Theme";
            toggleWindowThemeMenuItem.Click += toggleWindowThemeMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.close_app;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(195, 22);
            toolStripMenuItem1.Text = "Exit";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 189);
            Name = "frmMain";
            ShowInTaskbar = false;
            Text = "Wallpaper Changer with Dark Mode";
            WindowState = FormWindowState.Minimized;
            Load += MainForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem wallpaperSettingsToolStripMenuItem;
        private ToolStripMenuItem darkModeSettingsToolStripMenuItem;
        private ToolStripMenuItem changeThemeToolStripMenuItem;
        private ToolStripMenuItem lightThemeToolStripMenuItem;
        private ToolStripMenuItem toggleWindowThemeMenuItem;
    }
}