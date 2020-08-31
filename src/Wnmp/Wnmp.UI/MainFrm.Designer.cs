namespace Wnmp.UI
{
    partial class MainFrm
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.WnmpMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wnmpOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostToIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHTTPHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localhostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wnmpDirButton = new System.Windows.Forms.Button();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.applicationsGroupBox = new System.Windows.Forms.GroupBox();
            this.phpRestartButton = new System.Windows.Forms.Button();
            this.mariadbRestartButton = new System.Windows.Forms.Button();
            this.nginxRestartButton = new System.Windows.Forms.Button();
            this.phpLogButton = new System.Windows.Forms.Button();
            this.mariadbLogButton = new System.Windows.Forms.Button();
            this.nginxLogButton = new System.Windows.Forms.Button();
            this.phpConfigButton = new System.Windows.Forms.Button();
            this.mariadbConfigButton = new System.Windows.Forms.Button();
            this.nginxConfigButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phprunning = new System.Windows.Forms.Label();
            this.mariadbrunning = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nginxrunning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mariadbStopButton = new System.Windows.Forms.Button();
            this.mariadbStartButton = new System.Windows.Forms.Button();
            this.phpStartButton = new System.Windows.Forms.Button();
            this.phpStopButton = new System.Windows.Forms.Button();
            this.nginxStartButton = new System.Windows.Forms.Button();
            this.nginxStopButton = new System.Windows.Forms.Button();
            this.startAllButton = new System.Windows.Forms.Button();
            this.stopAllButton = new System.Windows.Forms.Button();
            this.openMariaDBShellButton = new System.Windows.Forms.Button();
            this.AppsRunningTimer = new System.Windows.Forms.Timer(this.components);
            this.WnmpMenuStrip.SuspendLayout();
            this.applicationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WnmpMenuStrip
            // 
            this.WnmpMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.localhostToolStripMenuItem});
            resources.ApplyResources(this.WnmpMenuStrip, "WnmpMenuStrip");
            this.WnmpMenuStrip.Name = "WnmpMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wnmpOptionsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // wnmpOptionsToolStripMenuItem
            // 
            this.wnmpOptionsToolStripMenuItem.Name = "wnmpOptionsToolStripMenuItem";
            resources.ApplyResources(this.wnmpOptionsToolStripMenuItem, "wnmpOptionsToolStripMenuItem");
            this.wnmpOptionsToolStripMenuItem.Click += new System.EventHandler(this.WnmpOptionsToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            resources.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostToIPToolStripMenuItem,
            this.getHTTPHeadersToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // hostToIPToolStripMenuItem
            // 
            this.hostToIPToolStripMenuItem.Name = "hostToIPToolStripMenuItem";
            resources.ApplyResources(this.hostToIPToolStripMenuItem, "hostToIPToolStripMenuItem");
            this.hostToIPToolStripMenuItem.Click += new System.EventHandler(this.HostToIPToolStripMenuItem_Click);
            // 
            // getHTTPHeadersToolStripMenuItem
            // 
            this.getHTTPHeadersToolStripMenuItem.Name = "getHTTPHeadersToolStripMenuItem";
            resources.ApplyResources(this.getHTTPHeadersToolStripMenuItem, "getHTTPHeadersToolStripMenuItem");
            this.getHTTPHeadersToolStripMenuItem.Click += new System.EventHandler(this.GetHTTPHeadersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.reportBugToolStripMenuItem,
            this.toolStripSeparator2,
            this.websiteToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            resources.ApplyResources(this.supportToolStripMenuItem, "supportToolStripMenuItem");
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.SupportToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            resources.ApplyResources(this.reportBugToolStripMenuItem, "reportBugToolStripMenuItem");
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.ReportBugToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            resources.ApplyResources(this.websiteToolStripMenuItem, "websiteToolStripMenuItem");
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.WebsiteToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            resources.ApplyResources(this.donateToolStripMenuItem, "donateToolStripMenuItem");
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // localhostToolStripMenuItem
            // 
            this.localhostToolStripMenuItem.Name = "localhostToolStripMenuItem";
            resources.ApplyResources(this.localhostToolStripMenuItem, "localhostToolStripMenuItem");
            this.localhostToolStripMenuItem.Click += new System.EventHandler(this.LocalhostToolStripMenuItem_Click);
            // 
            // wnmpDirButton
            // 
            resources.ApplyResources(this.wnmpDirButton, "wnmpDirButton");
            this.wnmpDirButton.Name = "wnmpDirButton";
            this.wnmpDirButton.UseVisualStyleBackColor = true;
            this.wnmpDirButton.Click += new System.EventHandler(this.WnmpDirButton_Click);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.logRichTextBox, "logRichTextBox");
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            // 
            // applicationsGroupBox
            // 
            this.applicationsGroupBox.Controls.Add(this.phpRestartButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbRestartButton);
            this.applicationsGroupBox.Controls.Add(this.nginxRestartButton);
            this.applicationsGroupBox.Controls.Add(this.phpLogButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbLogButton);
            this.applicationsGroupBox.Controls.Add(this.nginxLogButton);
            this.applicationsGroupBox.Controls.Add(this.phpConfigButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbConfigButton);
            this.applicationsGroupBox.Controls.Add(this.nginxConfigButton);
            this.applicationsGroupBox.Controls.Add(this.label8);
            this.applicationsGroupBox.Controls.Add(this.label7);
            this.applicationsGroupBox.Controls.Add(this.phprunning);
            this.applicationsGroupBox.Controls.Add(this.mariadbrunning);
            this.applicationsGroupBox.Controls.Add(this.label6);
            this.applicationsGroupBox.Controls.Add(this.label4);
            this.applicationsGroupBox.Controls.Add(this.label3);
            this.applicationsGroupBox.Controls.Add(this.nginxrunning);
            this.applicationsGroupBox.Controls.Add(this.label1);
            this.applicationsGroupBox.Controls.Add(this.mariadbStopButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbStartButton);
            this.applicationsGroupBox.Controls.Add(this.phpStartButton);
            this.applicationsGroupBox.Controls.Add(this.phpStopButton);
            this.applicationsGroupBox.Controls.Add(this.nginxStartButton);
            this.applicationsGroupBox.Controls.Add(this.nginxStopButton);
            resources.ApplyResources(this.applicationsGroupBox, "applicationsGroupBox");
            this.applicationsGroupBox.Name = "applicationsGroupBox";
            this.applicationsGroupBox.TabStop = false;
            // 
            // phpRestartButton
            // 
            resources.ApplyResources(this.phpRestartButton, "phpRestartButton");
            this.phpRestartButton.Name = "phpRestartButton";
            this.phpRestartButton.UseVisualStyleBackColor = true;
            this.phpRestartButton.Click += new System.EventHandler(this.PhpRestartButton_Click);
            // 
            // mariadbRestartButton
            // 
            resources.ApplyResources(this.mariadbRestartButton, "mariadbRestartButton");
            this.mariadbRestartButton.Name = "mariadbRestartButton";
            this.mariadbRestartButton.UseVisualStyleBackColor = true;
            this.mariadbRestartButton.Click += new System.EventHandler(this.MariadbRestartButton_Click);
            // 
            // nginxRestartButton
            // 
            resources.ApplyResources(this.nginxRestartButton, "nginxRestartButton");
            this.nginxRestartButton.Name = "nginxRestartButton";
            this.nginxRestartButton.UseVisualStyleBackColor = true;
            this.nginxRestartButton.Click += new System.EventHandler(this.NginxRestartButton_Click);
            // 
            // phpLogButton
            // 
            resources.ApplyResources(this.phpLogButton, "phpLogButton");
            this.phpLogButton.Name = "phpLogButton";
            this.phpLogButton.UseVisualStyleBackColor = true;
            this.phpLogButton.Click += new System.EventHandler(this.PhpLogButton_Click);
            // 
            // mariadbLogButton
            // 
            resources.ApplyResources(this.mariadbLogButton, "mariadbLogButton");
            this.mariadbLogButton.Name = "mariadbLogButton";
            this.mariadbLogButton.UseVisualStyleBackColor = true;
            this.mariadbLogButton.Click += new System.EventHandler(this.MariadbLogButton_Click);
            // 
            // nginxLogButton
            // 
            resources.ApplyResources(this.nginxLogButton, "nginxLogButton");
            this.nginxLogButton.Name = "nginxLogButton";
            this.nginxLogButton.UseVisualStyleBackColor = true;
            this.nginxLogButton.Click += new System.EventHandler(this.NginxLogButton_Click);
            // 
            // phpConfigButton
            // 
            resources.ApplyResources(this.phpConfigButton, "phpConfigButton");
            this.phpConfigButton.Name = "phpConfigButton";
            this.phpConfigButton.UseVisualStyleBackColor = true;
            this.phpConfigButton.Click += new System.EventHandler(this.PhpConfigButton_Click);
            // 
            // mariadbConfigButton
            // 
            resources.ApplyResources(this.mariadbConfigButton, "mariadbConfigButton");
            this.mariadbConfigButton.Name = "mariadbConfigButton";
            this.mariadbConfigButton.UseVisualStyleBackColor = true;
            this.mariadbConfigButton.Click += new System.EventHandler(this.MariadbConfigButton_Click);
            // 
            // nginxConfigButton
            // 
            resources.ApplyResources(this.nginxConfigButton, "nginxConfigButton");
            this.nginxConfigButton.Name = "nginxConfigButton";
            this.nginxConfigButton.UseVisualStyleBackColor = true;
            this.nginxConfigButton.Click += new System.EventHandler(this.NginxConfigButton_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // phprunning
            // 
            resources.ApplyResources(this.phprunning, "phprunning");
            this.phprunning.ForeColor = System.Drawing.Color.DarkRed;
            this.phprunning.Name = "phprunning";
            // 
            // mariadbrunning
            // 
            resources.ApplyResources(this.mariadbrunning, "mariadbrunning");
            this.mariadbrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.mariadbrunning.Name = "mariadbrunning";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // nginxrunning
            // 
            resources.ApplyResources(this.nginxrunning, "nginxrunning");
            this.nginxrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.nginxrunning.Name = "nginxrunning";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // mariadbStopButton
            // 
            resources.ApplyResources(this.mariadbStopButton, "mariadbStopButton");
            this.mariadbStopButton.Name = "mariadbStopButton";
            this.mariadbStopButton.UseVisualStyleBackColor = true;
            this.mariadbStopButton.Click += new System.EventHandler(this.MariadbStopButton_Click);
            // 
            // mariadbStartButton
            // 
            resources.ApplyResources(this.mariadbStartButton, "mariadbStartButton");
            this.mariadbStartButton.Name = "mariadbStartButton";
            this.mariadbStartButton.UseVisualStyleBackColor = true;
            this.mariadbStartButton.Click += new System.EventHandler(this.MariadbStartButton_Click);
            // 
            // phpStartButton
            // 
            resources.ApplyResources(this.phpStartButton, "phpStartButton");
            this.phpStartButton.Name = "phpStartButton";
            this.phpStartButton.UseVisualStyleBackColor = true;
            this.phpStartButton.Click += new System.EventHandler(this.PhpStartButton_Click);
            // 
            // phpStopButton
            // 
            resources.ApplyResources(this.phpStopButton, "phpStopButton");
            this.phpStopButton.Name = "phpStopButton";
            this.phpStopButton.UseVisualStyleBackColor = true;
            this.phpStopButton.Click += new System.EventHandler(this.PhpStopButton_Click);
            // 
            // nginxStartButton
            // 
            resources.ApplyResources(this.nginxStartButton, "nginxStartButton");
            this.nginxStartButton.Name = "nginxStartButton";
            this.nginxStartButton.UseVisualStyleBackColor = true;
            this.nginxStartButton.Click += new System.EventHandler(this.NginxStartButton_Click);
            // 
            // nginxStopButton
            // 
            resources.ApplyResources(this.nginxStopButton, "nginxStopButton");
            this.nginxStopButton.Name = "nginxStopButton";
            this.nginxStopButton.UseVisualStyleBackColor = true;
            this.nginxStopButton.Click += new System.EventHandler(this.NginxStopButton_Click);
            // 
            // startAllButton
            // 
            resources.ApplyResources(this.startAllButton, "startAllButton");
            this.startAllButton.Name = "startAllButton";
            this.startAllButton.UseVisualStyleBackColor = true;
            this.startAllButton.Click += new System.EventHandler(this.StartAllButton_Click);
            // 
            // stopAllButton
            // 
            resources.ApplyResources(this.stopAllButton, "stopAllButton");
            this.stopAllButton.Name = "stopAllButton";
            this.stopAllButton.UseVisualStyleBackColor = true;
            this.stopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
            // 
            // openMariaDBShellButton
            // 
            resources.ApplyResources(this.openMariaDBShellButton, "openMariaDBShellButton");
            this.openMariaDBShellButton.Name = "openMariaDBShellButton";
            this.openMariaDBShellButton.UseVisualStyleBackColor = true;
            this.openMariaDBShellButton.Click += new System.EventHandler(this.OpenMariaDBShellButton_Click);
            // 
            // AppsRunningTimer
            // 
            this.AppsRunningTimer.Enabled = true;
            this.AppsRunningTimer.Interval = 1000;
            this.AppsRunningTimer.Tick += new System.EventHandler(this.AppsRunningTimer_Tick);
            // 
            // MainFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wnmpDirButton);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.applicationsGroupBox);
            this.Controls.Add(this.startAllButton);
            this.Controls.Add(this.stopAllButton);
            this.Controls.Add(this.openMariaDBShellButton);
            this.Controls.Add(this.WnmpMenuStrip);
            this.MainMenuStrip = this.WnmpMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.WnmpMenuStrip.ResumeLayout(false);
            this.WnmpMenuStrip.PerformLayout();
            this.applicationsGroupBox.ResumeLayout(false);
            this.applicationsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip WnmpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button wnmpDirButton;
        public System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.GroupBox applicationsGroupBox;
        private System.Windows.Forms.Button phpLogButton;
        private System.Windows.Forms.Button mariadbLogButton;
        private System.Windows.Forms.Button nginxLogButton;
        private System.Windows.Forms.Button phpConfigButton;
        private System.Windows.Forms.Button mariadbConfigButton;
        private System.Windows.Forms.Button nginxConfigButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem wnmpOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localhostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHTTPHeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button nginxRestartButton;
        private System.Windows.Forms.Button mariadbStopButton;
        private System.Windows.Forms.Button mariadbStartButton;
        private System.Windows.Forms.Button phpStartButton;
        private System.Windows.Forms.Button phpStopButton;
        private System.Windows.Forms.Button nginxStartButton;
        private System.Windows.Forms.Button nginxStopButton;
        private System.Windows.Forms.Button phpRestartButton;
        private System.Windows.Forms.Button mariadbRestartButton;
        private System.Windows.Forms.Button startAllButton;
        private System.Windows.Forms.Button stopAllButton;
        private System.Windows.Forms.Button openMariaDBShellButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label phprunning;
        private System.Windows.Forms.Label mariadbrunning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nginxrunning;
        private System.Windows.Forms.Timer AppsRunningTimer;
    }
}