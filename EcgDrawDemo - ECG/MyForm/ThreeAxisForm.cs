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
    public partial class ThreeAxisForm : Form
    {
        public DataAdapter0 d0 = null;
        public ThreeAxisForm()
        {
            InitializeComponent();
            d0 = new DataAdapter0(this, 0);
            d0.init(true, "D:\\三轴.txt");
        }
    }
}
