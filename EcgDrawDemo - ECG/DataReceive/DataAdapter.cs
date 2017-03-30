using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace EcgDrawDemo
{
    public class DataAdapter
    {
        public int HR = 0;
        // 传入窗体对象
        public Object m_fp = null;
        // 视图显示标记位
        protected bool bDraw = false;
        // 数据保存标记位
        protected bool bStore = false;
        // 数据保存文件路径
        protected string strFilename = null;
        //protected FormRealDraw fp = null;
        // 文件流
        protected StreamWriter m_sw = null;
        protected int i0 = 0;
        public const int dataBufLen = 1536;

        public Queue<short> dataBuf;
        protected int m_iSeriesIndex = 0;

        // 构造函数传入ECGDraw的对象以及曲线的索引号
        public DataAdapter(Object fp, int i)
        {
            // 1表示ECG窗体
            if (i == 1)
                m_fp = (ECGForm)fp;
            else if(i==2)// 2表示三轴窗体
                m_fp = (ThreeAxisForm)fp;
            else if (i == 3)// 2表示三轴窗体
                m_fp = (TemperatureForm)fp;
        }
        // 保存数据
        public void init(bool store, string filename)
        {
            i0 = 0;
            bStore = store;
            dataBuf = new Queue<short>(dataBufLen);

            // 开始存储
            if (bStore)
            {
                strFilename = filename;
                // 文件流开启
                if (m_sw != null)
                {
                    m_sw.Close();
                    m_sw = null;
                    //m_swraw.Close();
                }
                // 新建文件流
                m_sw = new StreamWriter(new FileStream(strFilename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite));
            }
            // 不存储
            else
            {
                strFilename = null;
                m_sw = null;
            }

        }
        // 定义虚函数 得到数据 在DataAdapter0中实现
        public virtual void getData(byte[] ba) { }
    }

    public class DataAdapter0 : DataAdapter
    {
        public int pointAllNum = 0;

        // 构造函数 将参数传到父类 设置传入Form中Chart的属性
        public DataAdapter0(Object fp, int i)
            : base(fp, i)
        {
            // 1表示ECG窗体
            if (i == 1)
                m_fp = (ECGForm)fp;
            else if (i == 2)// 2表示三轴窗体
                m_fp = (ThreeAxisForm)fp;
            else if (i == 3)// 2表示三轴窗体
                m_fp = (TemperatureForm)fp;
            //
            //m_fp.chartElec.Series.Add("s" + i.ToString() + "_" + Color.Blue);

            //心电Chart属性设置
            //m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Color = Color.Blue;
            //m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].BorderWidth = 1;
            //m_fp.chartElec.ChartAreas[0].CursorX.IsUserEnabled = true;
            //m_fp.chartElec.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //m_fp.chartElec.ChartAreas[0].CursorY.IsUserEnabled = true;
            //m_fp.chartElec.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            //m_fp.chartElec.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            //m_fp.chartElec.ChartAreas[0].AxisY.Maximum = 2048;
            //m_fp.chartElec.ChartAreas[0].AxisY.Minimum = -2048;
            //m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Size = 1024;
            //m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.MinSize = 1;


            // 三轴属性设置
            //m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Color = Color.Green;
            //m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].BorderWidth = 1;

            //m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Color = Color.MediumAquamarine;
            //m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].BorderWidth = 1;

            //m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Color = Color.LimeGreen;
            //m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].BorderWidth = 1;

            //m_fp.chartThreeAsix.ChartAreas[0].CursorX.IsUserEnabled = true;
            //m_fp.chartThreeAsix.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //m_fp.chartThreeAsix.ChartAreas[0].CursorY.IsUserEnabled = true;
            //m_fp.chartThreeAsix.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            //m_fp.chartThreeAsix.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            //m_fp.chartThreeAsix.ChartAreas[0].AxisY.Maximum = 127;
            //m_fp.chartThreeAsix.ChartAreas[0].AxisY.Minimum = -128;
            //m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size = 64;
            //m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.MinSize = 1;


            // 温度Chart属性设置
            //m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Color = Color.Maroon;
            //m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].BorderWidth = 1;
            //m_fp.chartTemperate.ChartAreas[0].CursorX.IsUserEnabled = true;
            //m_fp.chartTemperate.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //m_fp.chartTemperate.ChartAreas[0].CursorY.IsUserEnabled = true;
            //m_fp.chartTemperate.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            //m_fp.chartTemperate.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            //m_fp.chartTemperate.ChartAreas[0].AxisY.Maximum = 100;
            //m_fp.chartTemperate.ChartAreas[0].AxisY.Minimum = 0;
            //m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Size = 64;
            //m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.MinSize = 1;

        }
        // 数据包头检测位
        bool findhead = false;
        // 数据显示标记位
        bool showEn = false;
        // BLE数据索引位
        int bleRecDatai = 0;
        // BLE数据接收缓冲区
        byte[] bleRecData = new byte[1024];
        // BLE数据包长度
        int packetLen;

        Filter f = new Filter();
        double[] data = new double[256];
        int qrstindex = 0;

        // 对外传出数据
        private double[] ECGrawdata = new double[256];
        private double[,] ThreeAxisrawdata = new double[3,32];
        private double[] Temperaturerawdata = new double[2];
        public double[] getECGrawdata()
        {
            return ECGrawdata;
        }
        public double[,] getThreeAxisrawdata()
        {
            return ThreeAxisrawdata;
        }
        public double[] getTemperaturerawdata()
        {
            return Temperaturerawdata;
        }
        // 对基类方法进行重写
        public override void getData(byte[] ba)
        {
            double val = 0;
            int ecgdata = 0;
            // 没有发现数据包头 进行对数据包头检测
            if (false == findhead)
            {
                // 数据包头格式 0xA7 0xB8 0XFF
                if (((ba[0] & 0xFF) == 0xA7) && ((ba[1] & 0xFF) == 0xB8) && ((ba[2] & 0xFF) == 0x00))
                {
                    // 检测到数据包头
                    findhead = true;
                    // 不显示数据
                    showEn = false;
                    // 将数据包ba数据复制到BLE接收缓冲区
                    System.Array.Copy(ba, 0, bleRecData, bleRecDatai, ba.Length);
                    // 缓冲区索引更新
                    bleRecDatai += ba.Length;
                    // 数据包的4-8个字节是数据包长度
                    Array.Reverse(ba, 4, 4);
                    packetLen = BitConverter.ToInt32(ba, 4);
                }
            }
            else // 已经发现数据包头 直接对数据包进行复制到BLE接收缓冲区
            {
                System.Array.Copy(ba, 0, bleRecData, bleRecDatai, ba.Length);
                bleRecDatai += ba.Length;
                // 接收索引超过包的长度 接收结束 修改标志位 开始显示
                if (bleRecDatai >= packetLen)
                {
                    findhead = false; // 为下次接收包做准备
                    showEn = true; // 开始显示数据
                    bleRecDatai = 0; // 为下次接收包做准备
                }
            }
            // 开始显示数据
            if (true == showEn)
            {
                // 更新标记位
                showEn = false;
                // 偏移14字节 前14字节是数据包头数据
                int dOffset = 14;
                // 之后的512字节是ECG数据
                int rawdataindex = 0;
                for (int i = dOffset; i < (dOffset + 512);)
                {
                    // ADC12位采样用16位进行表示一个采样点
                    val = (bleRecData[i + 1] & 0xFF) * 256 + (bleRecData[i] & 0xff);
                    // 12位采样最大是4095 对异常点进行丢弃处理
                    ECGrawdata[rawdataindex] = val;
                    rawdataindex++;
                    //double filted = f.Low_Filter(val);//滤波之后
                    //filted = f.High_Filter(filted);
                    //if (qrstindex != 255)
                    //{
                    //    data[qrstindex] = filted;
                    //}
                    //else
                    //{
                    //    data[qrstindex] = filted;
                    //    HR = f.HeartRate(data);
                    //    qrstindex = 0;
                    //}
                    //qrstindex++;
                    ////if(f.find_R(filted))
                    ////m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.AddY(filted * 4);
                    ////else
                    //m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.AddY(filted);
                    //}
                    //if (m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.Count >= 25600)
                    //{
                    //    m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.Clear();
                    //}
                    //if (m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.Count > m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Size)
                    //{
                    //    m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Position
                    //        = m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.Count
                    //        - m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Size;
                    //}
                    i += 2;
                    // 对数据进行保存
                    if (bStore && m_sw != null)
                    {
                        m_sw.WriteLine(val);
                        m_sw.Flush();
                    }
                }

                dOffset = dOffset + 512;
                rawdataindex = 0;
                //三轴数据96字节
                for (int i = dOffset; i < (dOffset + 96);)
                {
                    //if (m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Points.Count >= 25600)
                    //{
                    //    m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Points.Clear();
                    //    m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Points.Clear();
                    //    m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Points.Clear();
                    //}
                    val = bleRecData[i];
                    val = val >= 128 ? val - 256 : val;
                    ThreeAxisrawdata[0, rawdataindex] = val;
                    val = bleRecData[i+1];
                    val = val >= 128 ? val - 256 : val;
                    ThreeAxisrawdata[1, rawdataindex] = val;
                    val = bleRecData[i+2];
                    val = val >= 128 ? val - 256 : val;
                    ThreeAxisrawdata[2, rawdataindex] = val;

                    i += 3;
                    rawdataindex++;
                    //val = val >= 128 ? val - 256 : val;

                    //if (val <= 127 && val >= -128)
                    //    m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Points.AddY(val);

                    //if (m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Points.Count > m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size)
                    //{
                    //    m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Position
                    //        = m_fp.chartThreeAsix.Series[m_fp.chartElec.Series.Count - 1].Points.Count
                    //        - m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size;
                    //}

                    //val = bleRecData[i + 1];
                    //val = val >= 128 ? val - 256 : val;

                    //if (val <= 127 && val >= -128)
                    //    m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Points.AddY(val);

                    //if (m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Points.Count > m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size)
                    //{
                    //    m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Position
                    //        = m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Points.Count
                    //        - m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size;
                    //}

                    //val = bleRecData[i + 2];
                    //val = val >= 128 ? val - 256 : val;

                    //if (val <= 127 && val >= -128)
                    //    m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Points.AddY(val);

                    //if (m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Points.Count > m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size)
                    //{
                    //    m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Position
                    //        = m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Points.Count
                    //        - m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size;
                    //}
                    ////当前只画了X轴
                    ////bleRecData[i] 	X
                    ////bleRecData[i + 1] y
                    ////bleRecData[i + 2] Z

                    ////gvSeries1.appendData(new GraphViewData(graph2LastXValue, bleRecData[i]), true, 512);                    			
                    ////graph2LastXValue++;
                    //i += 3;
                }

                dOffset = dOffset + 96;
                rawdataindex = 0;
                //温度数据2字节
                for (int i = dOffset; i < (dOffset + 2);)
                {
                    val = (bleRecData[i + 1] & 0xff) * 256 + (bleRecData[i] & 0xff);
                    val /= 100;
                    Temperaturerawdata[rawdataindex++] = val;
                    //if (m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Points.Count >= 25600)
                    //{
                    //    m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Points.Clear();
                    //}
                    //val = (bleRecData[i + 1] & 0xff) * 256 + (bleRecData[i] & 0xff);
                    //val /= 100;
                    //if (val < 100)
                    //    m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Points.AddY(val);
                    ////gvSeries1.appendData(new GraphViewData(graph2LastXValue, tempData), true, 512);                    			
                    ////graph2LastXValue++;
                    //if (m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Points.Count > m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Size)
                    //{
                    //    m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Position
                    //        = m_fp.chartTemperate.Series[m_fp.chartElec.Series.Count - 1].Points.Count
                    //        - m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Size;
                    //}
                    i += 2;
                }
            }
        }
    }
}
