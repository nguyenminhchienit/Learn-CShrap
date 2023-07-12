using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] proc = Process.GetProcesses();
            foreach(Process p in proc)
            {
                textBox1.Text = p.ProcessName + "\n" + textBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process.Start("notepad");
            //Process.Start(Application.StartupPath + "\\ProcessGUI.exe");
            //Process.Start(@"https:\\fullstack.edu.vn");
        }
    }
}
