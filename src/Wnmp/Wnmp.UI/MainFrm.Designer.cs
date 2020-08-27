﻿namespace Wnmp.UI
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
            this.WnmpMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.WnmpMenuStrip.Name = "WnmpMenuStrip";
            this.WnmpMenuStrip.Size = new System.Drawing.Size(647, 28);
            this.WnmpMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wnmpOptionsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.fileToolStripMenuItem.Text = "文件(&F)";
            // 
            // wnmpOptionsToolStripMenuItem
            // 
            this.wnmpOptionsToolStripMenuItem.Name = "wnmpOptionsToolStripMenuItem";
            this.wnmpOptionsToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.wnmpOptionsToolStripMenuItem.Text = "Wnmp Options";
            this.wnmpOptionsToolStripMenuItem.Click += new System.EventHandler(this.WnmpOptionsToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostToIPToolStripMenuItem,
            this.getHTTPHeadersToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.toolsToolStripMenuItem.Text = "工具(&T)";
            // 
            // hostToIPToolStripMenuItem
            // 
            this.hostToIPToolStripMenuItem.Name = "hostToIPToolStripMenuItem";
            this.hostToIPToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.hostToIPToolStripMenuItem.Text = "Host To IP";
            this.hostToIPToolStripMenuItem.Click += new System.EventHandler(this.HostToIPToolStripMenuItem_Click);
            // 
            // getHTTPHeadersToolStripMenuItem
            // 
            this.getHTTPHeadersToolStripMenuItem.Name = "getHTTPHeadersToolStripMenuItem";
            this.getHTTPHeadersToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.getHTTPHeadersToolStripMenuItem.Text = "Get HTTP Headers";
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.helpToolStripMenuItem.Text = "帮助(&H)";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.SupportToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.reportBugToolStripMenuItem.Text = "Report Bug";
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.ReportBugToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.WebsiteToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // localhostToolStripMenuItem
            // 
            this.localhostToolStripMenuItem.Name = "localhostToolStripMenuItem";
            this.localhostToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.localhostToolStripMenuItem.Text = "打开IE浏览器";
            this.localhostToolStripMenuItem.Click += new System.EventHandler(this.LocalhostToolStripMenuItem_Click);
            // 
            // wnmpDirButton
            // 
            this.wnmpDirButton.Location = new System.Drawing.Point(572, 150);
            this.wnmpDirButton.Name = "wnmpDirButton";
            this.wnmpDirButton.Size = new System.Drawing.Size(63, 37);
            this.wnmpDirButton.TabIndex = 65;
            this.wnmpDirButton.Text = "Wnmp Directory";
            this.wnmpDirButton.UseVisualStyleBackColor = true;
            this.wnmpDirButton.Click += new System.EventHandler(this.WnmpDirButton_Click);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.BackColor = System.Drawing.Color.White;
            this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRichTextBox.Location = new System.Drawing.Point(0, 210);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            this.logRichTextBox.Size = new System.Drawing.Size(647, 123);
            this.logRichTextBox.TabIndex = 61;
            this.logRichTextBox.Text = "";
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
            this.applicationsGroupBox.Location = new System.Drawing.Point(12, 25);
            this.applicationsGroupBox.Name = "applicationsGroupBox";
            this.applicationsGroupBox.Size = new System.Drawing.Size(543, 162);
            this.applicationsGroupBox.TabIndex = 60;
            this.applicationsGroupBox.TabStop = false;
            this.applicationsGroupBox.Text = "程序组件";
            // 
            // phpRestartButton
            // 
            this.phpRestartButton.Location = new System.Drawing.Point(276, 122);
            this.phpRestartButton.Name = "phpRestartButton";
            this.phpRestartButton.Size = new System.Drawing.Size(50, 26);
            this.phpRestartButton.TabIndex = 78;
            this.phpRestartButton.Text = "重启";
            this.phpRestartButton.UseVisualStyleBackColor = true;
            this.phpRestartButton.Click += new System.EventHandler(this.PhpRestartButton_Click);
            // 
            // mariadbRestartButton
            // 
            this.mariadbRestartButton.Location = new System.Drawing.Point(276, 81);
            this.mariadbRestartButton.Name = "mariadbRestartButton";
            this.mariadbRestartButton.Size = new System.Drawing.Size(50, 26);
            this.mariadbRestartButton.TabIndex = 77;
            this.mariadbRestartButton.Text = "重启";
            this.mariadbRestartButton.UseVisualStyleBackColor = true;
            this.mariadbRestartButton.Click += new System.EventHandler(this.MariadbRestartButton_Click);
            // 
            // nginxRestartButton
            // 
            this.nginxRestartButton.Location = new System.Drawing.Point(276, 42);
            this.nginxRestartButton.Name = "nginxRestartButton";
            this.nginxRestartButton.Size = new System.Drawing.Size(50, 26);
            this.nginxRestartButton.TabIndex = 76;
            this.nginxRestartButton.Text = "重启";
            this.nginxRestartButton.UseVisualStyleBackColor = true;
            this.nginxRestartButton.Click += new System.EventHandler(this.NginxRestartButton_Click);
            // 
            // phpLogButton
            // 
            this.phpLogButton.Location = new System.Drawing.Point(421, 122);
            this.phpLogButton.Name = "phpLogButton";
            this.phpLogButton.Size = new System.Drawing.Size(50, 26);
            this.phpLogButton.TabIndex = 75;
            this.phpLogButton.Text = "日志";
            this.phpLogButton.UseVisualStyleBackColor = true;
            this.phpLogButton.Click += new System.EventHandler(this.PhpLogButton_Click);
            // 
            // mariadbLogButton
            // 
            this.mariadbLogButton.Location = new System.Drawing.Point(421, 81);
            this.mariadbLogButton.Name = "mariadbLogButton";
            this.mariadbLogButton.Size = new System.Drawing.Size(50, 26);
            this.mariadbLogButton.TabIndex = 74;
            this.mariadbLogButton.Text = "日志";
            this.mariadbLogButton.UseVisualStyleBackColor = true;
            this.mariadbLogButton.Click += new System.EventHandler(this.MariadbLogButton_Click);
            // 
            // nginxLogButton
            // 
            this.nginxLogButton.Location = new System.Drawing.Point(421, 42);
            this.nginxLogButton.Name = "nginxLogButton";
            this.nginxLogButton.Size = new System.Drawing.Size(50, 26);
            this.nginxLogButton.TabIndex = 73;
            this.nginxLogButton.Text = "日志";
            this.nginxLogButton.UseVisualStyleBackColor = true;
            this.nginxLogButton.Click += new System.EventHandler(this.NginxLogButton_Click);
            // 
            // phpConfigButton
            // 
            this.phpConfigButton.Location = new System.Drawing.Point(332, 122);
            this.phpConfigButton.Name = "phpConfigButton";
            this.phpConfigButton.Size = new System.Drawing.Size(83, 26);
            this.phpConfigButton.TabIndex = 72;
            this.phpConfigButton.Text = "详细配置";
            this.phpConfigButton.UseVisualStyleBackColor = true;
            this.phpConfigButton.Click += new System.EventHandler(this.PhpConfigButton_Click);
            // 
            // mariadbConfigButton
            // 
            this.mariadbConfigButton.Location = new System.Drawing.Point(332, 81);
            this.mariadbConfigButton.Name = "mariadbConfigButton";
            this.mariadbConfigButton.Size = new System.Drawing.Size(83, 26);
            this.mariadbConfigButton.TabIndex = 71;
            this.mariadbConfigButton.Text = "详细配置";
            this.mariadbConfigButton.UseVisualStyleBackColor = true;
            this.mariadbConfigButton.Click += new System.EventHandler(this.MariadbConfigButton_Click);
            // 
            // nginxConfigButton
            // 
            this.nginxConfigButton.Location = new System.Drawing.Point(332, 42);
            this.nginxConfigButton.Name = "nginxConfigButton";
            this.nginxConfigButton.Size = new System.Drawing.Size(83, 26);
            this.nginxConfigButton.TabIndex = 70;
            this.nginxConfigButton.Text = "详细配置";
            this.nginxConfigButton.UseVisualStyleBackColor = true;
            this.nginxConfigButton.Click += new System.EventHandler(this.NginxConfigButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 69;
            this.label8.Text = "PHP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "SQL数据库";
            // 
            // phprunning
            // 
            this.phprunning.AutoSize = true;
            this.phprunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phprunning.ForeColor = System.Drawing.Color.DarkRed;
            this.phprunning.Location = new System.Drawing.Point(22, 125);
            this.phprunning.Name = "phprunning";
            this.phprunning.Size = new System.Drawing.Size(21, 20);
            this.phprunning.TabIndex = 67;
            this.phprunning.Text = "X";
            // 
            // mariadbrunning
            // 
            this.mariadbrunning.AutoSize = true;
            this.mariadbrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mariadbrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.mariadbrunning.Location = new System.Drawing.Point(22, 84);
            this.mariadbrunning.Name = "mariadbrunning";
            this.mariadbrunning.Size = new System.Drawing.Size(21, 20);
            this.mariadbrunning.TabIndex = 66;
            this.mariadbrunning.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "服务启停及配置选项";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nginx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "后台服务器";
            // 
            // nginxrunning
            // 
            this.nginxrunning.AutoSize = true;
            this.nginxrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nginxrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.nginxrunning.Location = new System.Drawing.Point(22, 43);
            this.nginxrunning.Name = "nginxrunning";
            this.nginxrunning.Size = new System.Drawing.Size(21, 20);
            this.nginxrunning.TabIndex = 61;
            this.nginxrunning.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "运行状态";
            // 
            // mariadbStopButton
            // 
            this.mariadbStopButton.Location = new System.Drawing.Point(220, 82);
            this.mariadbStopButton.Name = "mariadbStopButton";
            this.mariadbStopButton.Size = new System.Drawing.Size(50, 26);
            this.mariadbStopButton.TabIndex = 57;
            this.mariadbStopButton.Text = "停止";
            this.mariadbStopButton.UseVisualStyleBackColor = true;
            this.mariadbStopButton.Click += new System.EventHandler(this.MariadbStopButton_Click);
            // 
            // mariadbStartButton
            // 
            this.mariadbStartButton.Location = new System.Drawing.Point(164, 82);
            this.mariadbStartButton.Name = "mariadbStartButton";
            this.mariadbStartButton.Size = new System.Drawing.Size(50, 26);
            this.mariadbStartButton.TabIndex = 56;
            this.mariadbStartButton.Text = "启动";
            this.mariadbStartButton.UseVisualStyleBackColor = true;
            this.mariadbStartButton.Click += new System.EventHandler(this.MariadbStartButton_Click);
            // 
            // phpStartButton
            // 
            this.phpStartButton.Location = new System.Drawing.Point(164, 122);
            this.phpStartButton.Name = "phpStartButton";
            this.phpStartButton.Size = new System.Drawing.Size(50, 26);
            this.phpStartButton.TabIndex = 55;
            this.phpStartButton.Text = "启动";
            this.phpStartButton.UseVisualStyleBackColor = true;
            this.phpStartButton.Click += new System.EventHandler(this.PhpStartButton_Click);
            // 
            // phpStopButton
            // 
            this.phpStopButton.Location = new System.Drawing.Point(220, 122);
            this.phpStopButton.Name = "phpStopButton";
            this.phpStopButton.Size = new System.Drawing.Size(50, 26);
            this.phpStopButton.TabIndex = 54;
            this.phpStopButton.Text = "停止";
            this.phpStopButton.UseVisualStyleBackColor = true;
            this.phpStopButton.Click += new System.EventHandler(this.PhpStopButton_Click);
            // 
            // nginxStartButton
            // 
            this.nginxStartButton.Location = new System.Drawing.Point(164, 42);
            this.nginxStartButton.Name = "nginxStartButton";
            this.nginxStartButton.Size = new System.Drawing.Size(50, 26);
            this.nginxStartButton.TabIndex = 53;
            this.nginxStartButton.Text = "启动";
            this.nginxStartButton.UseVisualStyleBackColor = true;
            this.nginxStartButton.Click += new System.EventHandler(this.NginxStartButton_Click);
            // 
            // nginxStopButton
            // 
            this.nginxStopButton.Location = new System.Drawing.Point(220, 42);
            this.nginxStopButton.Name = "nginxStopButton";
            this.nginxStopButton.Size = new System.Drawing.Size(50, 26);
            this.nginxStopButton.TabIndex = 52;
            this.nginxStopButton.Text = "停止";
            this.nginxStopButton.UseVisualStyleBackColor = true;
            this.nginxStopButton.Click += new System.EventHandler(this.NginxStopButton_Click);
            // 
            // startAllButton
            // 
            this.startAllButton.Location = new System.Drawing.Point(572, 25);
            this.startAllButton.Name = "startAllButton";
            this.startAllButton.Size = new System.Drawing.Size(63, 33);
            this.startAllButton.TabIndex = 62;
            this.startAllButton.Text = "全部启动";
            this.startAllButton.UseVisualStyleBackColor = true;
            this.startAllButton.Click += new System.EventHandler(this.StartAllButton_Click);
            // 
            // stopAllButton
            // 
            this.stopAllButton.Location = new System.Drawing.Point(572, 63);
            this.stopAllButton.Name = "stopAllButton";
            this.stopAllButton.Size = new System.Drawing.Size(63, 33);
            this.stopAllButton.TabIndex = 63;
            this.stopAllButton.Text = "全部停止";
            this.stopAllButton.UseVisualStyleBackColor = true;
            this.stopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
            // 
            // openMariaDBShellButton
            // 
            this.openMariaDBShellButton.Location = new System.Drawing.Point(572, 101);
            this.openMariaDBShellButton.Name = "openMariaDBShellButton";
            this.openMariaDBShellButton.Size = new System.Drawing.Size(63, 45);
            this.openMariaDBShellButton.TabIndex = 64;
            this.openMariaDBShellButton.Text = "SQL命令提示符";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 333);
            this.Controls.Add(this.wnmpDirButton);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.applicationsGroupBox);
            this.Controls.Add(this.startAllButton);
            this.Controls.Add(this.stopAllButton);
            this.Controls.Add(this.openMariaDBShellButton);
            this.Controls.Add(this.WnmpMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.WnmpMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Wnmp Control Panel";
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