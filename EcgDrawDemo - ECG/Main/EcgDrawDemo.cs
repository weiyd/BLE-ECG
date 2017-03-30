//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Drawing;
//using System.Windows.Forms;
//using System.Timers;
//using Nordicsemi;
//using System.IO;
//namespace EcgDrawDemo
//{
//    public partial class EcgDraw : Form
//    {
//        // 公有适配器变量
//        public DataAdapter0 da0;

//        enum AlertLevel : byte
//        {
//            Off = 0x00,
//            Low = 0x01,
//            High = 0x02,
//        }

//        [Flags]
//        enum BatteryState : byte
//        {
//            Present = 0x1,
//            Discharging = 0x02,
//            CriticalLevel = 0x04,
//            Charging = 0x08,
//            ServiceRequired = 0x10,
//            Valid = 0x20
//        }

//        class AppText
//        {
//            public const string StartingUp = "Starting up";
//            public const string Ready = "Ready";
//            public const string WorkerCompleted = "WorkerCompleted";
//            public const string Connect = "Connect";
//            public const string Disconnect = "Disconnect";
//            public const string DeleteBond = "Delete Bond";
//            public const string NoDeviceSelected = "No Master Emulator Board Detected. " +
//                "Make sure it is plugged in and the driver is correctly installed, then " +
//                "restart the application";
//            public const string Close = "Close";
//            public const string Open = "Open";
//            public const string OperationFailed = "Operation failed";
//            public const string DevDiscFinished = "Device discovery Stopped";
//            public const string DeleteBondInfo = "Delete Bond Info";
//            public const string Bond = "Bond";
//            public const string StartBackgroundScan = "Starting background scanning";
//            public const string BackgroundScanCompleted = "BackgroundScanCompleted";
//            public const string StartBackgroundConnect = "Starting background connect";
//            public const string BackgroundConnectCompleted = "BackgroundConnectCompleted";
//            public const string StopScanError = "Failed to stop device discovery";
//            public const string StartScanError = "Failed to start device discovery";
//        }

//        MasterEmulator masterEmulator;
//        BackgroundWorker initMasterEmulatorWorker = new BackgroundWorker();
//        BackgroundWorker backgroundConnectWorker = new BackgroundWorker();
//        BindingList<StringValue> log = new BindingList<StringValue>();
//        Dictionary<string, BtDevice> discoveredDevicesList = new Dictionary<string, BtDevice>();


//        System.Timers.Timer reconnectTimer = new System.Timers.Timer();
//        System.Timers.Timer clearMeasureIndicationTimer = new System.Timers.Timer();


//        bool pipeDiscoveryComplete = false;
//        bool isOpen = false;
//        bool isConnected = false;
//        bool isBonded = false;
//        bool isRunning = false;

//        int pipeElecData;
//        int pipeElecNotification;
//        int masterEmulatorBoardsCount = 0;
//        double measuredTemp = 0;
//        BtDeviceAddress curDeviceAddress = null;
//        BtDevice selectedDevice = null;

//        public EcgDraw()
//        {
//            // 初始化组件
//            InitializeComponent();// 初始化组件 c#自动生成

//            // 初始化数据适配器
//            da0 = new DataAdapter0(this, 0);
//            // 数据是否保存以及保存地址
//            da0.init(true, "D:\\11.txt");
//            //Byte[] data = new Byte[10];
//            //da0.getData(data);
//        }

//        private void OnShown(object sender, EventArgs e)
//        {
//            splitContainer.Enabled = false;
//            btnOpenClose.Enabled = false;
//            //pnlLeftBottom.Enabled = false;
//            lblConnectedSymbol.BackColor = Color.Pink;
//            SetupLogGrid();
//            SetupDeviceDiscoveryGrid();
//            RunWorkerInitMasterEmulator();
//        }

//        private void SetupLogGrid()
//        {
//            dgvLog.DataSource = log;
//            dgvLog.Columns["Data"].Visible = false;
//            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//            dgvLog.ColumnHeadersVisible = false;
//            dgvLog.RowHeadersVisible = false;
//            dgvLog.RowTemplate.Height = 18;
//            dgvLog.AllowUserToResizeRows = false;
//            dgvLog.ShowCellToolTips = false;
//            dgvLog.ShowEditingIcon = false;
//        }

//        private void SetupDeviceDiscoveryGrid()
//        {
//            dgvDeviceDiscovery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
//            dgvDeviceDiscovery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//            dgvDeviceDiscovery.ColumnHeadersVisible = true;
//            dgvDeviceDiscovery.RowHeadersVisible = false;
//            dgvDeviceDiscovery.RowTemplate.Height = 18;
//            dgvDeviceDiscovery.AllowUserToResizeRows = false;
//            dgvDeviceDiscovery.ShowCellToolTips = false;
//            dgvDeviceDiscovery.ShowEditingIcon = false;
//            dgvDeviceDiscovery.Click += OnDgvDeviceDiscoveryClick;
//            dgvDeviceDiscovery.VirtualMode = true;
//            dgvDeviceDiscovery.CellValueNeeded += dgvDeviceDiscovery_CellValueNeeded;
//        }

//        void dgvDeviceDiscovery_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
//        {
//            if (e.RowIndex >= discoveredDevicesList.Count)
//            {
//                return;
//            }

//            List<string> valuesList = new List<string>(discoveredDevicesList.Keys);
//            //this.log.Add(new StringValue(valuesList[e.RowIndex]));
//            e.Value = valuesList[e.RowIndex];
//        }

//        private void RegisterEventHandlers()
//        {
//            masterEmulator.LogMessage += OnLogMessage;
//            masterEmulator.DataReceived += OnDataReceived;
//            masterEmulator.Connected += OnConnected;
//            masterEmulator.Disconnected += OnDisconnected;
//            masterEmulator.PipeError += OnPipeError;
//            masterEmulator.DeviceDiscovered += OnDeviceDiscovered;
//            masterEmulator.ConnectionUpdateRequest += OnConnectionUpdateRequest;
//        }

//        private void RunWorkerInitMasterEmulator()
//        {
//            //this.Cursor = Cursors.WaitCursor;
//            initMasterEmulatorWorker.DoWork += OnInitMasterEmulatorWorkerDoWork;
//            initMasterEmulatorWorker.RunWorkerCompleted += OnInitMasterEmulatorWorkerCompleted;
//            initMasterEmulatorWorker.RunWorkerAsync();
//        }

//        void OnInitMasterEmulatorWorkerDoWork(object sender, DoWorkEventArgs e)
//        {
//            this.Invoke((MethodInvoker)delegate ()
//            {
//                log.Add(new StringValue(AppText.StartingUp));
//            });

//            masterEmulator = new MasterEmulator();
//            RegisterEventHandlers();

//            IEnumerable<string> usbDevices = masterEmulator.EnumerateUsb();

//            this.Invoke((MethodInvoker)delegate ()
//            {
//                PopulateUsbDevComboBox(usbDevices);
//                string usbSerial;
//                if (masterEmulatorBoardsCount == 0)
//                {
//                    MessageBox.Show(AppText.NoDeviceSelected);
//                    return;
//                }
//                btnOpenClose.Enabled = true;
//                cboUsbSerial.Enabled = true;
//            });

//            initMasterEmulatorWorker.DoWork -= OnInitMasterEmulatorWorkerDoWork;
//        }

//        void OnInitMasterEmulatorWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
//        {
//            this.Cursor = Cursors.Default;
//            this.Invoke((MethodInvoker)delegate ()
//            {
//                if (e.Error != null)
//                {
//                    DisplayErrorMessage(e.Error);
//                }
//                else
//                {
//                    log.Add(new StringValue(AppText.Ready));
//                }
//            });
//            Debug.WriteLine(AppText.WorkerCompleted);
//            initMasterEmulatorWorker.RunWorkerCompleted -= OnInitMasterEmulatorWorkerCompleted;
//        }

//        void StartScan()
//        {
//            bool success = false;
//            this.Invoke((MethodInvoker)delegate ()
//            {
//                btnConnect.Enabled = false;
//                dgvDeviceDiscovery.CurrentCell = null;

//                success = masterEmulator.StartDeviceDiscovery();

//                if (!success)
//                {
//                    log.Add(new StringValue(AppText.StartScanError));
//                }
//            });
//        }

//        void StopScan()
//        {
//            if (!masterEmulator.IsDeviceDiscoveryOngoing)
//            {
//                return;
//            }

//            bool success = masterEmulator.StopDeviceDiscovery();
//            if (!success)
//            {
//                log.Add(new StringValue(AppText.StopScanError));
//            }
//        }

//        void OnDeviceDiscovered(object sender, ValueEventArgs<BtDevice> e)
//        {
//            this.BeginInvoke((MethodInvoker)delegate ()
//            {
//                dgvDeviceDiscovery.Enabled = true;
//                dgvDeviceDiscovery.Visible = true;

//                BtDevice dev = e.Value;
//                string deviceName = "";
//                IDictionary<DeviceInfoType, string> deviceInfo = dev.DeviceInfo;

//                if (deviceInfo.ContainsKey(DeviceInfoType.CompleteLocalName))
//                {
//                    deviceName = deviceInfo[DeviceInfoType.CompleteLocalName];
//                }
//                else if (deviceInfo.ContainsKey(DeviceInfoType.ShortenedLocalName))
//                {
//                    deviceName = deviceInfo[DeviceInfoType.ShortenedLocalName];
//                }
//                else
//                {
//                    deviceName = "Default";
//                }

//                string key = deviceName + " (adr: " + dev.DeviceAddress + ")";
//                discoveredDevicesList[key] = dev;
//                dgvDeviceDiscovery.RowCount = discoveredDevicesList.Count;

//            });
//        }


//        private void PerformPipeSetup()
//        {
//            const ushort EcgServiceUuid = 0xFFF0;
//            const ushort EcgNotiCharacteristicUuid = 0xFFF2;
//            const ushort ecgNotificationUuid = 0x2902;

//            /* Setup pipe Temperature Measurement*/
//            BtUuid serviceUuid1 = new BtUuid(EcgServiceUuid);
//            PipeStore pipeStoreR = PipeStore.Remote;
//            masterEmulator.SetupAddService(serviceUuid1, pipeStoreR);

//            BtUuid charDefUuid1 = new BtUuid(EcgNotiCharacteristicUuid);
//            int maxDataLength = 20;
//            byte[] data = new byte[] { };
//            masterEmulator.SetupAddCharacteristicDefinition(charDefUuid1, maxDataLength, data);
//            PipeType pipeType1 = PipeType.Receive;

//            pipeElecData = masterEmulator.SetupAssignPipe(pipeType1);
//            pipeElecNotification = masterEmulator.SetupAssignPipe(PipeType.Transmit);
//        }

//        private void DisplayErrorMessage(Exception ex)
//        {

//            string message = String.Format("{0}: {1}", AppText.OperationFailed, ex.Message);
//            var result = MessageBox.Show(message, "Error", MessageBoxButtons.AbortRetryIgnore,
//                MessageBoxIcon.Exclamation);
//            Debug.WriteLine(ex.StackTrace);
//            if (result == System.Windows.Forms.DialogResult.Abort)
//            {
//                this.Invoke((MethodInvoker)delegate ()
//                {
//                    this.Close();
//                });
//            }
//        }

//        private void OpenMasterEmulator(string usbSerial)
//        {
//            masterEmulator.Open(usbSerial);
//            masterEmulator.Reset();
//            isOpen = true;
//            splitContainer.Enabled = true;
//        }

//        private void CloseMasterEmulator()
//        {
//            masterEmulator.Close();
//            isOpen = false;
//            btnOpenClose.Text = AppText.Open;
//        }

//        private void Run()
//        {
//            try
//            {
//                masterEmulator.Run();
//                //pnlLeftBottom.Enabled = true;
//            }
//            catch (Exception ex)
//            {
//                DisplayErrorMessage(ex);
//                if (isOpen)
//                {
//                    CloseMasterEmulator();
//                }
//            }
//        }

//        private void DiscoverPipes()
//        {
//            try
//            {
//                masterEmulator.DiscoverPipes();
//                masterEmulator.OpenAllRemotePipes();
//                pipeDiscoveryComplete = true;
//            }
//            catch (Exception ex)
//            {
//                DisplayErrorMessage(ex);
//            }
//        }

//        private void PopulateUsbDevComboBox(IEnumerable<string> devices)
//        {
//            List<string> devs = new List<string>(devices);
//            masterEmulatorBoardsCount = devs.Count;
//            cboUsbSerial.ComboBox.DataSource = devs;
//        }

//        void OnTimedEvent(object source, ElapsedEventArgs e)
//        {
//            //pnlRight.BackColor = Color.LightGreen;
//            clearMeasureIndicationTimer.Enabled = false;
//        }

//        void OnTimedEvtReconnect(object source, ElapsedEventArgs e)
//        {
//            reconnectTimer.Enabled = false;
//        }

//        private void UpdateTemperature(byte[] receivedTemp)
//        {
//            //byte flags = receivedTemp[0];
//            //byte[] convertedTemp = new byte[] { 0, 0, 0, 0 };
//            //SByte exponent = (SByte)receivedTemp[4];
//            //double multiplier = Math.Pow(10, exponent);
//            //int val = receivedTemp[3] << 16;
//            //val |= receivedTemp[2] << 8;
//            //val |= receivedTemp[1];
//            //measuredTemp = val * multiplier;

//            //string dateTime = DateTime.Now.ToString("HH:mm:ss.ffff");
//            //string debugMessage = String.Format("{0};{1};{2}", dateTime, "RECEIVED TEMPERATURE",
//            //    measuredTemp.ToString());
//            //this.Invoke((MethodInvoker)delegate()
//            //{
//            //    tbTemperature.Text = measuredTemp.ToString();
//            //    log.Add(new StringValue(debugMessage));
//            //    Debug.WriteLine(debugMessage);
//            //    Debug.Flush();
//            //    dgvLog.FirstDisplayedScrollingRowIndex = log.Count - 1;
//            //});
//        }

//        private BtDevice DiscoverPeerAddress(BtDeviceAddress address, int duration)
//        {
//            IEnumerable<BtDevice> devices;
//            try
//            {
//                BtScanParameters scanParams = new BtScanParameters();
//                scanParams.ScanIntervalMs = 100;
//                scanParams.ScanWindowMs = 12;
//                devices = masterEmulator.DiscoverDevices(1, scanParams);
//                foreach (BtDevice dev in devices)
//                {
//                    if (address.Value == dev.DeviceAddress.Value)
//                    {
//                        return dev;
//                    }
//                }
//                return null;
//            }
//            catch (Exception ex)
//            {
//                DisplayErrorMessage(ex);
//                return null;
//            }
//        }


//        #region master emulator event handlers

//        void OnConnectionUpdateRequest(object sender, ConnectionUpdateRequestEventArgs e)
//        {
//            masterEmulator.SendConnectionUpdateResponse(e.Identifier, ConnectionUpdateResponse.Accepted);
//        }
//        void OnLogMessage(object sender, ValueEventArgs<string> e)
//        {
//            this.BeginInvoke((MethodInvoker)delegate ()
//            {
//                log.Add(new StringValue(e.Value));
//                dgvLog.FirstDisplayedScrollingRowIndex = log.Count - 1;
//            });
//        }
//        int recCnt = 0;
//        void OnDataReceived(object sender, PipeDataEventArgs e)
//        {
//            if (e.PipeNumber == pipeElecData)
//            {
//                try
//                {
//                    recCnt++;
//                    //da0.getData(e.PipeData);
//                    // Console.Write(BitConverter.ToString(e.PipeData) + "\r\n");
//                    this.Invoke(new Action<byte[]>(da0.getData), new object[] { e.PipeData });
//                    if (recCnt > 3)
//                    {
//                        recCnt = 0;
//                        //Console.Clear();
//                    }
//                }
//                catch (Exception ee)
//                {
//                    log.Add(new StringValue(ee.ToString()));
//                }
//                //Application.DoEvents();
//            }
//        }

//        void OnConnected(object sender, EventArgs e)
//        {
//            reconnectTimer.Enabled = false;
//            isConnected = true;
//            isBonded = true;
//            this.BeginInvoke((MethodInvoker)delegate ()
//            {
//                lblConnectedSymbol.BackColor = Color.LightGreen;
//                //if (pipeDiscoveryComplete)
//                //{
//                //    pnlRight.BackColor = Color.LightGreen;
//                //}
//                btnConnect.Text = AppText.Disconnect;
//            });

//        }

//        void OnPipeError(object sender, PipeErrorEventArgs e)
//        {
//            Exception pipeErrorMsg = new Exception((e.ErrorCode).ToString());
//            this.BeginInvoke((MethodInvoker)delegate ()
//            {
//                DisplayErrorMessage(pipeErrorMsg);
//            });
//        }

//        void OnDisconnected(object sender, ValueEventArgs<DisconnectReason> e)
//        {
//            isConnected = false;
//            try
//            {
//                if (isBonded)
//                {
//                    //RunBackgroundConnectWorker();
//                }
//                this.BeginInvoke((MethodInvoker)delegate ()
//                {
//                    lblConnectedSymbol.BackColor = Color.Pink;
//                    //pnlRight.BackColor = SystemColors.Control;
//                    btnConnect.Text = AppText.Connect;
//                    log.Add(new StringValue("Disconnect!!"));
//                });
//            }
//            catch (Exception ex)
//            {
//                this.BeginInvoke((MethodInvoker)delegate ()
//                {
//                    DisplayErrorMessage(ex);
//                });
//            }
//            finally
//            {
//                this.BeginInvoke((MethodInvoker)delegate ()
//                {
//                    this.Cursor = Cursors.Default;
//                });
//            }
//        }

//        #endregion

//        #region ui event handlers

//        void OnDgvDeviceDiscoveryClick(object sender, EventArgs e)
//        {
//            if (isConnected)
//            {
//                return;
//            }

//            if (dgvDeviceDiscovery.CurrentCell != null)
//            {
//                string deviceKey = (string)(dgvDeviceDiscovery.CurrentCell.Value);
//                selectedDevice = discoveredDevicesList[deviceKey];
//                curDeviceAddress = selectedDevice.DeviceAddress;
//                btnConnect.Enabled = true;
//            }
//        }

//        void OnBtnOpenCloseClick(object sender, EventArgs e)
//        {
//            int selectedItem = cboUsbSerial.SelectedIndex;
//            string usbSerial;
//            if (selectedItem >= 0)
//            {
//                usbSerial = (string)cboUsbSerial.Items[selectedItem];
//            }
//            else
//            {
//                MessageBox.Show(AppText.NoDeviceSelected);
//                return;
//            }

//            try
//            {
//                this.Cursor = Cursors.WaitCursor;
//                if (!isOpen)
//                {
//                    OpenMasterEmulator(usbSerial);

//                    if (!isRunning)
//                    {
//                        PerformPipeSetup();
//                        Run();
//                        StartScan();
//                    }
//                    btnOpenClose.Text = AppText.Close;

//                }
//                else
//                {
//                    CloseMasterEmulator();
//                }
//            }
//            catch (Exception ex)
//            {
//                this.Invoke((MethodInvoker)delegate ()
//                {
//                    DisplayErrorMessage(ex);
//                });
//            }
//            finally
//            {
//                this.Cursor = Cursors.Default;
//            }
//        }

//        private void ConnectToDevice()
//        {
//            if (curDeviceAddress == null)
//            {
//                DataGridViewRow selectedRow = dgvDeviceDiscovery.SelectedRows[0];
//                selectedDevice = (BtDevice)dgvDeviceDiscovery.CurrentCell.Value;
//                curDeviceAddress = selectedDevice.DeviceAddress;
//            }
//            BtConnectionParameters cxParam = new BtConnectionParameters();
//            cxParam.ConnectionIntervalMs = 30;
//            //cxParam.SlaveLatency = 0;
//            //cxParam.SupervisionTimeoutMs = 10000;
//            try
//            {
//                if (false && isBonded)
//                {
//                    masterEmulator.Connect(curDeviceAddress, cxParam);
//                }
//                else
//                {
//                    if (masterEmulator.Connect(curDeviceAddress, cxParam))
//                    {
//                        //masterEmulator.Bond();
//                        DiscoverPipes();
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                DisplayErrorMessage(ex);
//            }
//        }

//        private void OnBtnbtnConnectClick(object sender, EventArgs e)
//        {
//            if (!isConnected)
//            {
//                this.Cursor = Cursors.WaitCursor;
//                StopScan();
//                if (dgvDeviceDiscovery.SelectedRows.Count > 0)
//                {
//                    try
//                    {
//                        ConnectToDevice();
//                    }
//                    catch (Exception ex)
//                    {
//                        DisplayErrorMessage(ex);
//                    }
//                    finally
//                    {
//                        this.Cursor = Cursors.Default;
//                    }
//                }
//            }
//            else
//            {
//                try
//                {
//                    isBonded = false;
//                    if (masterEmulator.IsConnected)
//                    {
//                        masterEmulator.Disconnect();
//                    }
//                    pipeDiscoveryComplete = false;
//                    //masterEmulator.DeleteBondInformation();
//                }
//                catch (Exception ex)
//                {
//                    DisplayErrorMessage(ex);
//                }
//                finally
//                {
//                    this.Cursor = Cursors.Default;
//                }
//            }
//        }

//        #endregion

//        private void tbTemperature_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void pnlLeftBottom_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void buttonNoti_Click(object sender, EventArgs e)
//        {
//            Byte[] data = new Byte[2] { 0x00, 0x01 };
//            masterEmulator.SendData(pipeElecNotification, data);
//        }

//        private void buttonScan_Click(object sender, EventArgs e)
//        {
//            if (!masterEmulator.IsDeviceDiscoveryOngoing)
//            {
//                discoveredDevicesList.Clear();
//                dgvDeviceDiscovery.ColumnCount = discoveredDevicesList.Count;
//                StartScan();
//            }
//        }

//        private void buttonStopScan_Click(object sender, EventArgs e)
//        {
//            if (masterEmulator.IsDeviceDiscoveryOngoing)
//            {
//                masterEmulator.StopDeviceDiscovery();
//            }
//        }

//        private void buttonTimeSyn_Click(object sender, EventArgs e)
//        {

//        }

//        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void btnClear_Click(object sender, EventArgs e)
//        {
//            for (int i = 0; i < da0.m_fp.chartThreeAsix.Series.Count; i++)
//            {
//                da0.m_fp.chartThreeAsix.Series[i].Points.Clear();
//            }
//            for (int i = 0; i < da0.m_fp.chartTemperate.Series.Count; i++)
//            {
//                da0.m_fp.chartTemperate.Series[i].Points.Clear();
//            }
//            for (int i = 0; i < da0.m_fp.chartElec.Series.Count; i++)
//            {
//                da0.m_fp.chartElec.Series[i].Points.Clear();
//            }
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void timer1_Tick(object sender, EventArgs e)
//        {
//            label1.Text = "实时心率：" + da0.HR.ToString();
//        }
//    }


//}