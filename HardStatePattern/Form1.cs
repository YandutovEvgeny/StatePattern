using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardStatePattern
{
    public partial class Form1 : Form
    {
        ButtonMove buttonMove;
        public Form1()
        {
            InitializeComponent();
            buttonMove = new ButtonMove(button1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(button1.Top < 0)
            {
                buttonMove.NextState();
                button1.Top = 0;
            }
            if(button1.Top > Height - 200)
            {
                buttonMove.NextState();
                button1.Top = Height - 200;
            }
            if(button1.Left > Width - 150)
            {
                buttonMove.NextState();
                button1.Left = Width - 150;
            }
            if(button1.Left < 0)
            {
                buttonMove.NextState();
                button1.Left = 0;
            }
            buttonMove.Move();
        }
    }
}
