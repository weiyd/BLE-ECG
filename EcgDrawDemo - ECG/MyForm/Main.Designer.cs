namespace EcgDrawDemo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnectedSymbol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboUsbSerial = new System.Windows.Forms.ToolStripComboBox();
            this.btnOpenClose = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.dgvDeviceDiscovery = new System.Windows.Forms.DataGridView();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonStopScan = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.buttonNoti = new System.Windows.Forms.Button();
            this.buttonTimeSyn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceDiscovery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblConnectedSymbol});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "连接状态：";
            // 
            // lblConnectedSymbol
            // 
            this.lblConnectedSymbol.Name = "lblConnectedSymbol";
            this.lblConnectedSymbol.Size = new System.Drawing.Size(16, 17);
            this.lblConnectedSymbol.Text = "  ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboUsbSerial,
            this.btnOpenClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(108, 22);
            this.toolStripLabel1.Text = "Master emulator:";
            // 
            // cboUsbSerial
            // 
            this.cboUsbSerial.Name = "cboUsbSerial";
            this.cboUsbSerial.Size = new System.Drawing.Size(121, 25);
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenClose.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenClose.Image")));
            this.btnOpenClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(36, 22);
            this.btnOpenClose.Text = "打开";
            this.btnOpenClose.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.buttonTimeSyn);
            this.panel.Controls.Add(this.buttonNoti);
            this.panel.Controls.Add(this.btnClear);
            this.panel.Controls.Add(this.btnConnect);
            this.panel.Controls.Add(this.buttonStopScan);
            this.panel.Controls.Add(this.buttonScan);
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(584, 367);
            this.panel.TabIndex = 3;
            // 
            // dgvDeviceDiscovery
            // 
            this.dgvDeviceDiscovery.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDeviceDiscovery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceDiscovery.Location = new System.Drawing.Point(6, 20);
            this.dgvDeviceDiscovery.Name = "dgvDeviceDiscovery";
            this.dgvDeviceDiscovery.RowTemplate.Height = 23;
            this.dgvDeviceDiscovery.Size = new System.Drawing.Size(179, 202);
            this.dgvDeviceDiscovery.TabIndex = 1;
            this.dgvDeviceDiscovery.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvDeviceDiscovery_CellValueNeeded);
            // 
            // dgvLog
            // 
            this.dgvLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(6, 20);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.Size = new System.Drawing.Size(360, 335);
            this.dgvLog.TabIndex = 0;
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(15, 250);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 23);
            this.buttonScan.TabIndex = 2;
            this.buttonScan.Text = "扫描";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click_1);
            // 
            // buttonStopScan
            // 
            this.buttonStopScan.Location = new System.Drawing.Point(117, 250);
            this.buttonStopScan.Name = "buttonStopScan";
            this.buttonStopScan.Size = new System.Drawing.Size(75, 23);
            this.buttonStopScan.TabIndex = 3;
            this.buttonStopScan.Text = "停止扫描";
            this.buttonStopScan.UseVisualStyleBackColor = true;
            this.buttonStopScan.Click += new System.EventHandler(this.buttonStopScan_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(17, 286);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接蓝牙";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(117, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // buttonNoti
            // 
            this.buttonNoti.Location = new System.Drawing.Point(15, 322);
            this.buttonNoti.Name = "buttonNoti";
            this.buttonNoti.Size = new System.Drawing.Size(75, 23);
            this.buttonNoti.TabIndex = 6;
            this.buttonNoti.Text = "EnableNoti";
            this.buttonNoti.UseVisualStyleBackColor = true;
            this.buttonNoti.Click += new System.EventHandler(this.buttonNoti_Click_1);
            // 
            // buttonTimeSyn
            // 
            this.buttonTimeSyn.Location = new System.Drawing.Point(117, 322);
            this.buttonTimeSyn.Name = "buttonTimeSyn";
            this.buttonTimeSyn.Size = new System.Drawing.Size(75, 23);
            this.buttonTimeSyn.TabIndex = 7;
            this.buttonTimeSyn.Text = "同步时间";
            this.buttonTimeSyn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDeviceDiscovery);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "蓝牙设备";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLog);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 361);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作日志";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 420);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.OnShown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceDiscovery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectedSymbol;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboUsbSerial;
        private System.Windows.Forms.ToolStripButton btnOpenClose;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridView dgvDeviceDiscovery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTimeSyn;
        private System.Windows.Forms.Button buttonNoti;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button buttonStopScan;
        private System.Windows.Forms.Button buttonScan;
    }
}