using System;
using System.Collections.Generic;
using System.Text;

namespace EcgDrawDemo
{
	
	class Filter
	{
		// 低通滤波系数（FIR）
		static double[] h_low = { -0.0833280833705624,  0.0169383374811856, 0.0996331738000324, 0.161291094189399,
			0.199341376750681,  0.212202692091625,  0.199341376750681,  0.161291094189399,  0.0996331738000324,
			0.0169383374811856, -0.0833280833705624};
		//　高通滤波系数（IIR）
		static double[] h_high_a = { -2.97556554241633, 2.95142869449895, -0.975861350573406 };
		static double[] h_high_b = { 0.987856948436085, -2.96357084530825, 2.96357084530825, -0.987856948436082 };
		// 低通移位缓存（FIR） 高通移位缓存（IIR）

        public Filter()
        {
        }

        private double[] LowBuffer = new double[h_low.Length];
        public double Low_Filter(double x)
        {
            int i;
            for (i = 0; i < h_low.Length - 1; i++)
            {
                LowBuffer[i] = LowBuffer[i + 1];
            }
            LowBuffer[h_low.Length - 1] = x;
            double result = 0;
            for (i = 0; i < h_low.Length; i++)
                result += LowBuffer[i] * h_low[i];
            return result;
        }

        private double[] B_buffer = new double[h_high_b.Length];
        private double[] A_buffer = new double[h_high_a.Length];
        public double High_Filter(double x)
        {
            B_buffer[0] = x;
            double result = 0.0;
            int i = 0;
            for (i = 0; i < B_buffer.Length; i++)
                result += B_buffer[i] * h_high_b[i];
            for (i = 0; i < A_buffer.Length; i++)
                result -= A_buffer[i] * h_high_a[i];
            for (i = B_buffer.Length-1; i > 0 ; i--)
                B_buffer[i] = B_buffer[i - 1];
            for (i = A_buffer.Length - 1; i > 0; i--)
                A_buffer[i] = A_buffer[i - 1];
            if (result > 1.0e10)
                result=4096;
            if(result<-1.0e10)
                result = -4096;
            A_buffer[0] = result;
            return result;
        }

        private const int fs = 256;
        private const int N = 5;
        private double[] QRST = new double[fs * 4];//10秒观测数据
        private double[] diff = new double[fs * 4 - N - N]; 
        public int HeartRate(double[] x)
        {
            int i = 0;
            int j = 0;

            // 移位更新数据
            for(i=256;i<QRST.Length;i++)
            {
                QRST[i - 256] = QRST[i];
            }
            j = 0;
            for (i = QRST.Length - 256; i < QRST.Length; i++)
            {
                QRST[i] = x[j++];
            }

            //Step1 R波差分差异化处理
            j = 0;
            for (i = N; i < QRST.Length - N-1; i++)
            {
                diff[j] = QRST[i] * 2 - QRST[i - 5] - QRST[i + 5];
                j++;
            }
            ////Step2 R波平方处理
            //for (i = 0; i < diff.Length; i++)
            //    diff[i] = diff[i] * diff[i];

            //Step2 求最大值
            double max = -0xffff;
            for (i = 1; i < diff.Length; i++)
            {
                if (diff[i] > max)
                    max = diff[i];
            }
            double Threshold = max * 0.5;

            //Step3 检测超过阈值的点
            List<int> list = new List<int>();
            int list_size = 0;
            for (i = 1; i < diff.Length; i++)
            {
                if (diff[i] > Threshold)
                {
                    list.Add(i);
                    list_size++;
                }
                       
            }

            //Step4 对过阈值点进行处理
            List<int> R_pos = new List<int>();
            int HR = 0;
            for (i = 0; i < list_size - 1; i++) 
            {
                if (list[i + 1] - list[i] > 30)
                {
                    R_pos.Add(i);
                    HR++;
                }
            }
            if (list[i] - list[i - 1] > 30)
            {
                R_pos.Add(i);
                HR++;
            }
            return HR;
        }
	}

    
}