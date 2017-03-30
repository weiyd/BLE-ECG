namespace EcgDraw
{
    partial class EcgDraw
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcgDraw));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboUsbSerial = new System.Windows.Forms.ToolStripComboBox();
            this.btnOpenClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.lblConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnectedSymbol = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pnlLeftMiddle = new System.Windows.Forms.Panel();
            this.dgvDeviceDiscovery = new System.Windows.Forms.DataGridView();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartElec = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.buttonStopScan = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonTimeSyn = new System.Windows.Forms.Button();
            this.buttonNoti = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartTemperate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartThreeAsix = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlLeftMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceDiscovery)).BeginInit();
            this.grpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartElec)).BeginInit();
            this.grpLeft.SuspendLayout();
            this.grpLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThreeAsix)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 48);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItemAbout.Text = "toolStripMenuItem1";
            this.toolStripMenuItemAbout.ToolTipText = "关于";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItemExit.Text = "toolStripMenuItem1";
            this.toolStripMenuItemExit.ToolTipText = "退出";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(144, 24);
            this.toolStripLabel1.Text = "Master emulator:";
            // 
            // cboUsbSerial
            // 
            this.cboUsbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsbSerial.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboUsbSerial.Name = "cboUsbSerial";
            this.cboUsbSerial.Size = new System.Drawing.Size(120, 27);
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpenClose.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenClose.Image")));
            this.btnOpenClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(72, 24);
            this.btnOpenClose.Text = "Open";
            this.btnOpenClose.Click += new System.EventHandler(this.OnBtnOpenCloseClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboUsbSerial,
            this.btnOpenClose,
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1348, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // lblConnected
            // 
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(73, 21);
            this.lblConnected.Text = "Connected:";
            // 
            // lblConnectedSymbol
            // 
            this.lblConnectedSymbol.BackColor = System.Drawing.Color.Transparent;
            this.lblConnectedSymbol.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblConnectedSymbol.Name = "lblConnectedSymbol";
            this.lblConnectedSymbol.Size = new System.Drawing.Size(20, 21);
            this.lblConnectedSymbol.Text = "  ";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnected,
            this.lblConnectedSymbol});
            this.statusStrip.Location = new System.Drawing.Point(0, 704);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1348, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // pnlLeftMiddle
            // 
            this.pnlLeftMiddle.Controls.Add(this.dgvDeviceDiscovery);
            this.pnlLeftMiddle.Location = new System.Drawing.Point(7, 22);
            this.pnlLeftMiddle.Name = "pnlLeftMiddle";
            this.pnlLeftMiddle.Size = new System.Drawing.Size(240, 262);
            this.pnlLeftMiddle.TabIndex = 4;
            // 
            // dgvDeviceDiscovery
            // 
            this.dgvDeviceDiscovery.AllowDrop = true;
            this.dgvDeviceDiscovery.AllowUserToAddRows = false;
            this.dgvDeviceDiscovery.AllowUserToDeleteRows = false;
            this.dgvDeviceDiscovery.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDeviceDiscovery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDeviceDiscovery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceDiscovery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceDiscovery.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDeviceDiscovery.Location = new System.Drawing.Point(0, 0);
            this.dgvDeviceDiscovery.MultiSelect = false;
            this.dgvDeviceDiscovery.Name = "dgvDeviceDiscovery";
            this.dgvDeviceDiscovery.ReadOnly = true;
            this.dgvDeviceDiscovery.RowTemplate.Height = 23;
            this.dgvDeviceDiscovery.Size = new System.Drawing.Size(240, 262);
            this.dgvDeviceDiscovery.TabIndex = 1;
            // 
            // grpRight
            // 
            this.grpRight.BackColor = System.Drawing.SystemColors.Control;
            this.grpRight.Controls.Add(this.label1);
            this.grpRight.Controls.Add(this.chartElec);
            this.grpRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRight.Location = new System.Drawing.Point(0, 0);
            this.grpRight.Name = "grpRight";
            this.grpRight.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpRight.Size = new System.Drawing.Size(683, 394);
            this.grpRight.TabIndex = 4;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "PQRST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "实时心率：0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chartElec
            // 
            chartArea1.Name = "ChartArea1";
            this.chartElec.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.ForeColor = System.Drawing.SystemColors.HotTrack;
            legend1.Name = "Legend1";
            this.chartElec.Legends.Add(legend1);
            this.chartElec.Location = new System.Drawing.Point(17, 30);
            this.chartElec.Name = "chartElec";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "心电";
            this.chartElec.Series.Add(series1);
            this.chartElec.Size = new System.Drawing.Size(650, 364);
            this.chartElec.TabIndex = 4;
            this.chartElec.Text = "chart1";
            title1.Name = "心电波形";
            this.chartElec.Titles.Add(title1);
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.btnClear);
            this.grpLeft.Controls.Add(this.buttonStopScan);
            this.grpLeft.Controls.Add(this.buttonScan);
            this.grpLeft.Controls.Add(this.buttonTimeSyn);
            this.grpLeft.Controls.Add(this.buttonNoti);
            this.grpLeft.Controls.Add(this.btnConnect);
            this.grpLeft.Controls.Add(this.pnlLeftMiddle);
            this.grpLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpLeft.Location = new System.Drawing.Point(2, 0);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpLeft.Size = new System.Drawing.Size(250, 480);
            this.grpLeft.TabIndex = 3;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "Device";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(125, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // buttonStopScan
            // 
            this.buttonStopScan.Location = new System.Drawing.Point(125, 298);
            this.buttonStopScan.Name = "buttonStopScan";
            this.buttonStopScan.Size = new System.Drawing.Size(75, 37);
            this.buttonStopScan.TabIndex = 2;
            this.buttonStopScan.Text = "Stop";
            this.buttonStopScan.UseVisualStyleBackColor = true;
            this.buttonStopScan.Click += new System.EventHandler(this.buttonStopScan_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(44, 298);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 37);
            this.buttonScan.TabIndex = 2;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonTimeSyn
            // 
            this.buttonTimeSyn.Location = new System.Drawing.Point(44, 431);
            this.buttonTimeSyn.Name = "buttonTimeSyn";
            this.buttonTimeSyn.Size = new System.Drawing.Size(156, 39);
            this.buttonTimeSyn.TabIndex = 2;
            this.buttonTimeSyn.Text = "TimeSyn";
            this.buttonTimeSyn.UseVisualStyleBackColor = true;
            this.buttonTimeSyn.Click += new System.EventHandler(this.buttonTimeSyn_Click);
            // 
            // buttonNoti
            // 
            this.buttonNoti.Location = new System.Drawing.Point(44, 386);
            this.buttonNoti.Name = "buttonNoti";
            this.buttonNoti.Size = new System.Drawing.Size(156, 39);
            this.buttonNoti.TabIndex = 2;
            this.buttonNoti.Text = "EnableNoti";
            this.buttonNoti.UseVisualStyleBackColor = true;
            this.buttonNoti.Click += new System.EventHandler(this.buttonNoti_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(44, 341);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 39);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Con";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.OnBtnbtnConnectClick);
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.dgvLog);
            this.grpLog.Location = new System.Drawing.Point(2, 500);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(250, 160);
            this.grpLog.TabIndex = 5;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLog.Location = new System.Drawing.Point(3, 17);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.Size = new System.Drawing.Size(244, 140);
            this.dgvLog.TabIndex = 0;
            this.dgvLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLog_CellContentClick);
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(0, 30);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.grpLeft);
            this.splitContainer.Panel1.Controls.Add(this.grpLog);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer.Panel2.Controls.Add(this.grpRight);
            this.splitContainer.Size = new System.Drawing.Size(1345, 670);
            this.splitContainer.SplitterDistance = 257;
            this.splitContainer.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.chartTemperate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox2.Size = new System.Drawing.Size(1081, 257);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature";
            // 
            // chartTemperate
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTemperate.ChartAreas.Add(chartArea2);
            legend2.DockedToChartArea = "ChartArea1";
            legend2.ForeColor = System.Drawing.SystemColors.HotTrack;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartTemperate.Legends.Add(legend2);
            this.chartTemperate.Location = new System.Drawing.Point(17, 30);
            this.chartTemperate.Name = "chartTemperate";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "温度/°C";
            this.chartTemperate.Series.Add(series2);
            this.chartTemperate.Size = new System.Drawing.Size(1051, 224);
            this.chartTemperate.TabIndex = 4;
            this.chartTemperate.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.chartThreeAsix);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(685, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Size = new System.Drawing.Size(396, 394);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ThreeAxis";
            // 
            // chartThreeAsix
            // 
            chartArea3.Name = "ChartArea1";
            this.chartThreeAsix.ChartAreas.Add(chartArea3);
            legend3.DockedToChartArea = "ChartArea1";
            legend3.ForeColor = System.Drawing.SystemColors.HotTrack;
            legend3.Name = "Legend1";
            this.chartThreeAsix.Legends.Add(legend3);
            this.chartThreeAsix.Location = new System.Drawing.Point(17, 30);
            this.chartThreeAsix.Name = "chartThreeAsix";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "X轴";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Y轴";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Z轴";
            this.chartThreeAsix.Series.Add(series3);
            this.chartThreeAsix.Series.Add(series4);
            this.chartThreeAsix.Series.Add(series5);
            this.chartThreeAsix.Size = new System.Drawing.Size(366, 364);
            this.chartThreeAsix.TabIndex = 4;
            this.chartThreeAsix.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EcgDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 730);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "EcgDraw";
            this.Text = "EcgDraw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.OnShown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlLeftMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceDiscovery)).EndInit();
            this.grpRight.ResumeLayout(false);
            this.grpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartElec)).EndInit();
            this.grpLeft.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThreeAsix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripComboBox cboUsbSerial;
		private System.Windows.Forms.ToolStripButton btnOpenClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblConnected;
		private System.Windows.Forms.ToolStripStatusLabel lblConnectedSymbol;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.Panel pnlLeftMiddle;
		private System.Windows.Forms.DataGridView dgvDeviceDiscovery;
		private System.Windows.Forms.GroupBox grpRight;
		public System.Windows.Forms.DataVisualization.Charting.Chart chartElec;
		private System.Windows.Forms.GroupBox grpLeft;
		private System.Windows.Forms.Button buttonStopScan;
		private System.Windows.Forms.Button buttonScan;
		private System.Windows.Forms.Button buttonTimeSyn;
		private System.Windows.Forms.Button buttonNoti;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.GroupBox grpLog;
		private System.Windows.Forms.DataGridView dgvLog;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.DataVisualization.Charting.Chart chartTemperate;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.DataVisualization.Charting.Chart chartThreeAsix;
		private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

