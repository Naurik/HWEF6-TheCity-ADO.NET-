using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_HWEF6_ADO.NET_
{
    public partial class CityForms : Form
    {
        public CityForms()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new ContextCity())
            {
                var city = new Cities();
                if (textBox1.Text == "+77172")
                {
                    city = new Cities
                    {
                        NameCity = "Нур-Султан",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77162")
                {
                    city = new Cities
                    {
                        NameCity = "Кокшетау",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77212")
                {
                    city = new Cities
                    {
                        NameCity = "Караганда",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+7727")
                {
                    city = new Cities
                    {
                        NameCity = "Алматы",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77152")
                {
                    city = new Cities
                    {
                        NameCity = "Петропавл",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77112")
                {
                    city = new Cities
                    {
                        NameCity = "Уральск",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77182")
                {
                    city = new Cities
                    {
                        NameCity = "Павлодар",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77222")
                {
                    city = new Cities
                    {
                        NameCity = "Семей",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77242")
                {
                    city = new Cities
                    {
                        NameCity = "Кызылорда",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77252")
                {
                    city = new Cities
                    {
                        NameCity = "Шымкент",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77262")
                {
                    city = new Cities
                    {
                        NameCity = "Тараз",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77282")
                {
                    city = new Cities
                    {
                        NameCity = "Талдыкорган",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77232")
                {
                    city = new Cities
                    {
                        NameCity = "Усть-Каменогорск",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77292")
                {
                    city = new Cities
                    {
                        NameCity = "Актау",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77122")
                {
                    city = new Cities
                    {
                        NameCity = "Атырау",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else if (textBox1.Text == "+77132")
                {
                    city = new Cities
                    {
                        NameCity = "Актобе",
                        CodeNumberCity = (textBox1.Text + " " + textBox2.Text)
                    };
                    context.City.Add(city);
                    context.SaveChanges();
                    MessageBox.Show("Телефон успешно добавлен в список!");
                }
                else
                {
                    MessageBox.Show("Такого кода не существует, попробуйте снова!");
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
