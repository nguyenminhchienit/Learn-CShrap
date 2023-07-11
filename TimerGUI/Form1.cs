using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                button1.Text = "Stop";
                timer1.Start();
            }
            else
            {
                button1.Text = "Start";
                timer1.Stop();
            }
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
        }
    }
}
