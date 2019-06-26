using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ndassessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Creator factory = new FactoryClass();
        Pen myPen = new Pen(Color.Red);
        int x = 0, y = 0, width, height, radius, point, repeatval, counter;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
