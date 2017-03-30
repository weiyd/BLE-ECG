using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace EcgDraw
{
    public class DataAdapter
    {
        public int HR = 0;
        public EcgDraw m_fp = null;
        protected bool bDraw = false;
        protected bool bStore = false;
        protected string strFilename = null;
        //protected FormRealDraw fp = null;
        protected StreamWriter m_sw = null;
        protected int i0 = 0;
        public const int dataBufLen = 1536;
        public Queue<short> dataBuf;
        protected int m_iSeriesIndex = 0;
        public DataAdapter(EcgDraw fp, int i)
        {
            m_fp = fp;
            m_iSeriesIndex = i;
        }

        public void init(bool store, string filename)
        {
            i0 = 0;
            bStore = store;
            dataBuf = new Queue<short>(dataBufLen);
            if (bStore)
            {
                strFilename = filename;

                if (m_sw != null)
                {
                    m_sw.Close();
                    m_sw = null;
                    //m_swraw.Close();
                }
                m_sw = new StreamWriter(new FileStream(strFilename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite));
            }
            else
            {
                strFilename = null;
                m_sw = null;
            }

        }

        public virtual void getData(byte[] ba) { }
    }

    public class DataAdapter0 : DataAdapter
    {
        public int pointAllNum = 0;
        public DataAdapter0(EcgDraw fp, int i)
            : base(fp, i)
        {
            //m_fp.chartElec.Series.Add("s" + i.ToString() + "_" + Color.Blue);
            m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Color = Color.Blue;
            m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].BorderWidth = 1;
            m_fp.chartElec.ChartAreas[0].CursorX.IsUserEnabled = true;
            m_fp.chartElec.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            m_fp.chartElec.ChartAreas[0].CursorY.IsUserEnabled = true;
            m_fp.chartElec.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            m_fp.chartElec.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            m_fp.chartElec.ChartAreas[0].AxisY.Maximum = 2048;
            m_fp.chartElec.ChartAreas[0].AxisY.Minimum = -2048;
            m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Size = 1024;
            m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.MinSize = 1;



            m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Color = Color.Green;
            m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].BorderWidth = 1;

            m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Color = Color.MediumAquamarine;
            m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].BorderWidth = 1;

            m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Color = Color.LimeGreen;
            m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].BorderWidth = 1;

            m_fp.chartThreeAsix.ChartAreas[0].CursorX.IsUserEnabled = true;
            m_fp.chartThreeAsix.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            m_fp.chartThreeAsix.ChartAreas[0].CursorY.IsUserEnabled = true;
            m_fp.chartThreeAsix.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            m_fp.chartThreeAsix.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            m_fp.chartThreeAsix.ChartAreas[0].AxisY.Maximum = 127;
            m_fp.chartThreeAsix.ChartAreas[0].AxisY.Minimum = -128;
            m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size = 64;
            m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.MinSize = 1;



            m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Color = Color.Maroon;
            m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].BorderWidth = 1;
            m_fp.chartTemperate.ChartAreas[0].CursorX.IsUserEnabled = true;
            m_fp.chartTemperate.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            m_fp.chartTemperate.ChartAreas[0].CursorY.IsUserEnabled = true;
            m_fp.chartTemperate.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            m_fp.chartTemperate.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            m_fp.chartTemperate.ChartAreas[0].AxisY.Maximum = 100;
            m_fp.chartTemperate.ChartAreas[0].AxisY.Minimum = 0;
            m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Size = 64;
            m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.MinSize = 1;

        }

        bool findhead = false;
        bool showEn = false;
        int bleRecDatai = 0;
        byte[] bleRecData = new byte[1024];
        int packetLen;
        Filter f = new Filter();
        double[] data = new double[256];
        int qrstindex = 0;
        public override void getData(byte[] ba)
        {
            int val;

            int ecgdata = 0;
            if (false == findhead)
            {
                if (((ba[0] & 0xFF) == 0xA7) && ((ba[1] & 0xFF) == 0xB8) && ((ba[2] & 0xFF) == 0x00))
                {
                    findhead = true;
                    showEn = false; ;
                    System.Array.Copy(ba, 0, bleRecData, bleRecDatai, ba.Length);
                    bleRecDatai += ba.Length;

                    Array.Reverse(ba, 4, 4);
                    packetLen = BitConverter.ToInt32(ba, 4);
                }
            }
            else
            {
                System.Array.Copy(ba, 0, bleRecData, bleRecDatai, ba.Length);
                bleRecDatai += ba.Length;
                if (bleRecDatai >= packetLen)
                {
                    findhead = false;
                    showEn = true;
                    bleRecDatai = 0;
                }
            }

            if (true == showEn)
            {

                showEn = false;
                int dOffset = 14;
                for (int i = dOffset; i < (dOffset + 512);)
                {
                    val = (bleRecData[i + 1] & 0xFF) * 256 + (bleRecData[i] & 0xff);
                    if (val <= 4096)
                    {
                        double filted = f.Low_Filter(val);//滤波之后
                        filted = f.High_Filter(filted);
                        if (qrstindex != 255)
                        {
                            data[qrstindex] = filted;
                        }
                        else
                        {
                            data[qrstindex] = filted;
                            HR = f.HeartRate(data);
                            qrstindex = 0;
                        }
                        qrstindex++;
                        //if(f.find_R(filted))
                        //m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.AddY(filted * 4);
                        //else
                        m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.AddY(filted);
                    }
                    if (m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.Count >= 25600)
                    {
                        m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.Clear();
                    }
                    if (m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.Count > m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Position
                            = m_fp.chartElec.Series[m_fp.chartElec.Series.Count - 1].Points.Count
                            - m_fp.chartElec.ChartAreas[0].AxisX.ScaleView.Size;
                    }
                    i += 2;
                    if (bStore && m_sw != null)
                    {
                        m_sw.WriteLine(val);
                        m_sw.Flush();
                    }
                }

                dOffset = dOffset + 512;
                //三轴数据96字节
                for (int i = dOffset; i < (dOffset + 96);)
                {
                    if (m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Points.Count >= 25600)
                    {
                        m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Points.Clear();
                        m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Points.Clear();
                        m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Points.Clear();
                    }
                    val = bleRecData[i];
                    val = val >= 128 ? val - 256 : val;

                    if (val <= 127 && val >= -128)
                        m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Points.AddY(val);

                    if (m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 1].Points.Count > m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Position
                            = m_fp.chartThreeAsix.Series[m_fp.chartElec.Series.Count - 1].Points.Count
                            - m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size;
                    }

                    val = bleRecData[i + 1];
                    val = val >= 128 ? val - 256 : val;

                    if (val <= 127 && val >= -128)
                        m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Points.AddY(val);

                    if (m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Points.Count > m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Position
                            = m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 2].Points.Count
                            - m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size;
                    }

                    val = bleRecData[i + 2];
                    val = val >= 128 ? val - 256 : val;

                    if (val <= 127 && val >= -128)
                        m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Points.AddY(val);

                    if (m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Points.Count > m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Position
                            = m_fp.chartThreeAsix.Series[m_fp.chartThreeAsix.Series.Count - 3].Points.Count
                            - m_fp.chartThreeAsix.ChartAreas[0].AxisX.ScaleView.Size;
                    }
                    //当前只画了X轴
                    //bleRecData[i] 	X
                    //bleRecData[i + 1] y
                    //bleRecData[i + 2] Z

                    //gvSeries1.appendData(new GraphViewData(graph2LastXValue, bleRecData[i]), true, 512);                    			
                    //graph2LastXValue++;
                    i += 3;
                }

                dOffset = dOffset + 96;
                //温度数据2字节
                for (int i = dOffset; i < (dOffset + 2);)
                {
                    if (m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Points.Count >= 25600)
                    {
                        m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Points.Clear();
                    }
                    val = (bleRecData[i + 1] & 0xff) * 256 + (bleRecData[i] & 0xff);
                    val /= 100;
                    if (val < 100)
                        m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Points.AddY(val);
                    //gvSeries1.appendData(new GraphViewData(graph2LastXValue, tempData), true, 512);                    			
                    //graph2LastXValue++;
                    if (m_fp.chartTemperate.Series[m_fp.chartTemperate.Series.Count - 1].Points.Count > m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Position
                            = m_fp.chartTemperate.Series[m_fp.chartElec.Series.Count - 1].Points.Count
                            - m_fp.chartTemperate.ChartAreas[0].AxisX.ScaleView.Size;
                    }
                    i += 2;
                }
            }
        }
    }
}
