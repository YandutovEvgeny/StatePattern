using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class Form1 : Form
    {
        Water water;
        public Form1()
        {
            InitializeComponent();
            water = new Water();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            water.Heat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            water.Frost();
        }
    }
}
