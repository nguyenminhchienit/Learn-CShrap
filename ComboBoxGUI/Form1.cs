using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxGUI
{
    public partial class Form1 : Form
    {

        List<Food> listFood;
        List<School> listSchool;
        public Form1()
        {
            InitializeComponent();

            listFood = new List<Food>()
            {
                new Food(){Name = "Vegetable", Price = 10000 },
                new Food(){Name = "Meal", Price = 200000 },
                new Food(){Name = "Fish", Price = 125000 }
            };

            comboBox1.DataSource = listFood;
            comboBox1.DisplayMember = "Name";

            AddFoodBinding();

            listSchool = new List<School>()
            {
                new School()
                {
                    ClassName = "21DTHB2", 
                    ListStudent = new List<string>()
                    {
                        "Nguyễn Minh Anh",
                        "Trần Quốc Bảo",
                        "Hồ Trương Ngọc Bích",
                        "Nguyễn Kim Chí",
                        "Nguyễn Minh Chiến",
                        "Hà Đình Chương",
                        "Vũ Hưng Dũng",
                        "Phạm Khánh Duy",
                        "Nguyễn Minh Chiến",
                        "Nguyễn Hoàng Đạt",
                        "Nguyễn Thành Đạt",
                        "Nguyễn Minh Đức",
                        "Nguyễn Phước Hân",
                        "Tống Viết Hiệp",
                        "Hồ Hoàng Hiệp",
                        "Dương Trần Khánh Hoàng",
                        "Nguyễn Tuấn Huy",
                        "Nguyễn Minh Huy",
                        "Võ Trần Quốc Huy",
                    }
                },
                new School()
                {
                    ClassName = "21DTHB1", 
                    ListStudent = new List<string>()
                    {
                        "Pham Hoang Nhan", 
                        "Nguyen Trung Hau",
                        "Tran Van Tien",
                    } 
                }
            };
            comboBox2.DataSource = listSchool;
            comboBox2.DisplayMember = "ClassName";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           /* ComboBox cb = sender as ComboBox;

            if(cb.SelectedValue != null)
            {
                Food food = cb.SelectedValue as Food;
                textBox1.Text = food.Price.ToString();
            }*/
        }

        void AddFoodBinding()
        {
            textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Price"));
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if(cb.SelectedValue != null)
            {
                School school = cb.SelectedValue as School;
                comboBox3.DataSource = school.ListStudent;
            }
        }
    }

    public class Food
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }

    public class School
    {
        public string ClassName { get; set; }
        public List<string> ListStudent { get; set; }

    }
}
