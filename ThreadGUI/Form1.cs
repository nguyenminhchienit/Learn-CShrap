using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cach tao Thread 1
            Thread th = new Thread(demo);
            th.IsBackground = true;
            th.Start();
        }

        void demo()
        {
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                label1.Text = i.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int speed = 20;
        void MousePictureBox()
        {
            new Thread(() =>
           {
               while (true)
               {
                   if (checkBox1.Checked)
                       pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                   else
                       pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                   
                   Thread.Sleep(speed);
               }
           })
            { IsBackground = true }.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MousePictureBox();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            speed = Convert.ToInt32(textBox2.Text);
        }
    }
}
