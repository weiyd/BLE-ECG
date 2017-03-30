using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EcgDrawDemo
{
    public partial class TemperatureForm : Form
    {
        public DataAdapter0 d0 = null;
        public TemperatureForm()
        {
            InitializeComponent();
            d0 = new DataAdapter0(this, 0);
            d0.init(true, "D:\\温度.txt");
        }
    }
}
