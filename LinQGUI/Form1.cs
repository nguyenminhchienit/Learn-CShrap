using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQGUI
{
    public partial class Form1 : Form
    {
        List<Food> foodList;
        public Form1()
        {
            InitializeComponent();

            LoadFood();
        }

        void LoadFood()
        {
            foodList = new List<Food>();
            foodList.Add(new Food("Com tam", "25000"));
            foodList.Add(new Food("Bun Bo", "35000"));
            foodList.Add(new Food("Bun Rieu", "30000"));
            foodList.Add(new Food("Com ga", "27000"));
            foodList.Add(new Food("Com suon", "25000"));

            comboBox1.DataSource = foodList;
            comboBox1.DisplayMember = "name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Food> result = new List<Food>();

            /*foreach(Food item in foodList)
            {
                if(item.name == textBox1.Text)
                {
                    result.Add(item);
                }
            }*/

            //Su dung LinQ
            result = foodList.Where(item => item.name == textBox1.Text).ToList();

            comboBox2.DataSource = result;
            comboBox2.DisplayMember = "name";
        }
    }

    class Food
    {
        public string name { get; set; }
        public string price { get; set; }

        public Food()
        {

        }

        public Food(string n, string p)
        {
            this.name = n;
            this.price = p;
        }
    }
}
