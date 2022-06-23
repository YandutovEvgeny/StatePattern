using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork
{
    public partial class Form1 : Form
    {
        LightTraffic trafficLight;
        public Form1()
        {
            InitializeComponent();
            trafficLight = new LightTraffic(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trafficLight.NextState();
        }
    }
}
