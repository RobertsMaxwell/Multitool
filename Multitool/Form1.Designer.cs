namespace Multitool
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.LookupPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.domainLabel = new System.Windows.Forms.Label();
            this.domainText = new System.Windows.Forms.TextBox();
            this.PortScannerPanel = new System.Windows.Forms.Panel();
            this.ETA = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScanStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PortStart = new System.Windows.Forms.TextBox();
            this.IPAddressStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NetworkMonitorPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.uploadDisplay = new System.Windows.Forms.Label();
            this.downloadDisplay = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.processName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.programDownload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.programUpload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NetworkShow = new System.Windows.Forms.Button();
            this.WHOISShow = new System.Windows.Forms.Button();
            this.ScannerShow = new System.Windows.Forms.Button();
            this.LookupPanel.SuspendLayout();
            this.PortScannerPanel.SuspendLayout();
            this.NetworkMonitorPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LookupPanel
            // 
            this.LookupPanel.Controls.Add(this.listBox1);
            this.LookupPanel.Controls.Add(this.SearchButton);
            this.LookupPanel.Controls.Add(this.domainLabel);
            this.LookupPanel.Controls.Add(this.domainText);
            this.LookupPanel.Location = new System.Drawing.Point(12, 118);
            this.LookupPanel.Name = "LookupPanel";
            this.LookupPanel.Size = new System.Drawing.Size(933, 471);
            this.LookupPanel.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(212, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(641, 433);
            this.listBox1.TabIndex = 14;
            this.listBox1.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(79, 413);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(127, 41);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainLabel
            // 
            this.domainLabel.Location = new System.Drawing.Point(80, 16);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(126, 22);
            this.domainLabel.TabIndex = 13;
            this.domainLabel.Text = "Domain:";
            this.domainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // domainText
            // 
            this.domainText.Location = new System.Drawing.Point(79, 41);
            this.domainText.Name = "domainText";
            this.domainText.Size = new System.Drawing.Size(126, 20);
            this.domainText.TabIndex = 11;
            // 
            // PortScannerPanel
            // 
            this.PortScannerPanel.Controls.Add(this.ETA);
            this.PortScannerPanel.Controls.Add(this.progressBar);
            this.PortScannerPanel.Controls.Add(this.checkBox2);
            this.PortScannerPanel.Controls.Add(this.label2);
            this.PortScannerPanel.Controls.Add(this.comboBox1);
            this.PortScannerPanel.Controls.Add(this.listView1);
            this.PortScannerPanel.Controls.Add(this.ScanStart);
            this.PortScannerPanel.Controls.Add(this.label4);
            this.PortScannerPanel.Controls.Add(this.PortStart);
            this.PortScannerPanel.Controls.Add(this.IPAddressStart);
            this.PortScannerPanel.Controls.Add(this.label1);
            this.PortScannerPanel.Location = new System.Drawing.Point(12, 118);
            this.PortScannerPanel.Name = "PortScannerPanel";
            this.PortScannerPanel.Size = new System.Drawing.Size(933, 471);
            this.PortScannerPanel.TabIndex = 1;
            // 
            // ETA
            // 
            this.ETA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ETA.Location = new System.Drawing.Point(789, 447);
            this.ETA.Name = "ETA";
            this.ETA.Size = new System.Drawing.Size(65, 16);
            this.ETA.TabIndex = 26;
            this.ETA.Text = "ETA: 0";
            this.ETA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.progressBar.Location = new System.Drawing.Point(78, 448);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(705, 16);
            this.progressBar.TabIndex = 25;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(690, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 39);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Scan LAN";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(540, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Timeout (MS):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.comboBox1.Location = new System.Drawing.Point(543, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(78, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 348);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 233;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Port";
            this.columnHeader2.Width = 188;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 163;
            // 
            // ScanStart
            // 
            this.ScanStart.Location = new System.Drawing.Point(443, 29);
            this.ScanStart.Name = "ScanStart";
            this.ScanStart.Size = new System.Drawing.Size(75, 46);
            this.ScanStart.TabIndex = 16;
            this.ScanStart.Text = "Scan";
            this.ScanStart.UseVisualStyleBackColor = true;
            this.ScanStart.Click += new System.EventHandler(this.ScanStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ports:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PortStart
            // 
            this.PortStart.Location = new System.Drawing.Point(143, 55);
            this.PortStart.Name = "PortStart";
            this.PortStart.Size = new System.Drawing.Size(285, 20);
            this.PortStart.TabIndex = 19;
            this.PortStart.Enter += new System.EventHandler(this.PortStart_Enter);
            this.PortStart.Leave += new System.EventHandler(this.PortStart_Leave);
            // 
            // IPAddressStart
            // 
            this.IPAddressStart.ForeColor = System.Drawing.Color.Black;
            this.IPAddressStart.Location = new System.Drawing.Point(143, 29);
            this.IPAddressStart.Name = "IPAddressStart";
            this.IPAddressStart.Size = new System.Drawing.Size(285, 20);
            this.IPAddressStart.TabIndex = 18;
            this.IPAddressStart.Enter += new System.EventHandler(this.IPAddressStart_Enter);
            this.IPAddressStart.Leave += new System.EventHandler(this.IPAddressStart_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Addresses:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NetworkMonitorPanel
            // 
            this.NetworkMonitorPanel.Controls.Add(this.panel1);
            this.NetworkMonitorPanel.Controls.Add(this.listView2);
            this.NetworkMonitorPanel.Location = new System.Drawing.Point(12, 118);
            this.NetworkMonitorPanel.Name = "NetworkMonitorPanel";
            this.NetworkMonitorPanel.Size = new System.Drawing.Size(933, 471);
            this.NetworkMonitorPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.uploadDisplay);
            this.panel1.Controls.Add(this.downloadDisplay);
            this.panel1.Location = new System.Drawing.Point(78, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 426);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bytes/sec";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Download:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(36, 24);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 37);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(109, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Upload:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uploadDisplay
            // 
            this.uploadDisplay.Location = new System.Drawing.Point(109, 107);
            this.uploadDisplay.Name = "uploadDisplay";
            this.uploadDisplay.Size = new System.Drawing.Size(72, 23);
            this.uploadDisplay.TabIndex = 4;
            this.uploadDisplay.Text = "0";
            this.uploadDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadDisplay
            // 
            this.downloadDisplay.Location = new System.Drawing.Point(-3, 107);
            this.downloadDisplay.Name = "downloadDisplay";
            this.downloadDisplay.Size = new System.Drawing.Size(72, 23);
            this.downloadDisplay.TabIndex = 3;
            this.downloadDisplay.Text = "0";
            this.downloadDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processName,
            this.programDownload,
            this.programUpload});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(265, 22);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(589, 426);
            this.listView2.TabIndex = 7;
            this.listView2.TabStop = false;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView2_ColumnClick);
            // 
            // processName
            // 
            this.processName.Text = "Process";
            this.processName.Width = 212;
            // 
            // programDownload
            // 
            this.programDownload.Text = "Read (Bytes/sec)";
            this.programDownload.Width = 185;
            // 
            // programUpload
            // 
            this.programUpload.Text = "Write (Bytes/sec)";
            this.programUpload.Width = 185;
            // 
            // NetworkShow
            // 
            this.NetworkShow.Location = new System.Drawing.Point(202, 12);
            this.NetworkShow.Name = "NetworkShow";
            this.NetworkShow.Size = new System.Drawing.Size(185, 38);
            this.NetworkShow.TabIndex = 4;
            this.NetworkShow.Text = "Network Usage";
            this.NetworkShow.UseVisualStyleBackColor = true;
            this.NetworkShow.Click += new System.EventHandler(this.NetworkShow_Click);
            // 
            // WHOISShow
            // 
            this.WHOISShow.Location = new System.Drawing.Point(393, 12);
            this.WHOISShow.Name = "WHOISShow";
            this.WHOISShow.Size = new System.Drawing.Size(185, 38);
            this.WHOISShow.TabIndex = 5;
            this.WHOISShow.Text = "WHOIS Lookup";
            this.WHOISShow.UseVisualStyleBackColor = true;
            this.WHOISShow.Click += new System.EventHandler(this.WHOISShow_Click);
            // 
            // ScannerShow
            // 
            this.ScannerShow.Location = new System.Drawing.Point(584, 12);
            this.ScannerShow.Name = "ScannerShow";
            this.ScannerShow.Size = new System.Drawing.Size(185, 38);
            this.ScannerShow.TabIndex = 6;
            this.ScannerShow.Text = "Port Scanner";
            this.ScannerShow.UseVisualStyleBackColor = true;
            this.ScannerShow.Click += new System.EventHandler(this.ScannerShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 601);
            this.Controls.Add(this.ScannerShow);
            this.Controls.Add(this.WHOISShow);
            this.Controls.Add(this.NetworkShow);
            this.Controls.Add(this.LookupPanel);
            this.Controls.Add(this.PortScannerPanel);
            this.Controls.Add(this.NetworkMonitorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LookupPanel.ResumeLayout(false);
            this.LookupPanel.PerformLayout();
            this.PortScannerPanel.ResumeLayout(false);
            this.PortScannerPanel.PerformLayout();
            this.NetworkMonitorPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button whoISLookupShow;
        private System.Windows.Forms.Button portScannerShow;
        private System.Windows.Forms.Button networkMonitorShow;
        private System.Windows.Forms.Panel LookupPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.TextBox domainText;
        private System.Windows.Forms.Panel PortScannerPanel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ScanStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PortStart;
        private System.Windows.Forms.TextBox IPAddressStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ETA;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel NetworkMonitorPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label uploadDisplay;
        private System.Windows.Forms.Label downloadDisplay;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.ColumnHeader programDownload;
        private System.Windows.Forms.ColumnHeader programUpload;
        private System.Windows.Forms.Button NetworkShow;
        private System.Windows.Forms.Button WHOISShow;
        private System.Windows.Forms.Button ScannerShow;
    }
}

