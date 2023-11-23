using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            UpdateDataGridView1();
        }
        private void UpdateDataGridView1()
        {
            dataGridView1.Rows.Clear();

            using (DataContext сc = new DataContext())
            {
                var items = сc.worker.ToList();

                foreach (var item in items)
                {
                    dataGridView1.Rows.Add(item.Id, item.Names, item.Surname, item.Age, item.Phone, item.City, item.Specialization);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string age = textBox3.Text;
            string phone = textBox4.Text;
            string city = textBox5.Text;
            string specialization = textBox6.Text;

            var items = new Workers
            {
                Names = name,
                Surname = surname,
                Age = age,
                Phone = phone,
                City = city,
                Specialization = specialization
            };

            using (DataContext сc = new DataContext())
            {
                сc.worker.Add(items);
                сc.SaveChanges();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            UpdateDataGridView1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox7.Text, out int id))
            {
                using (DataContext сc = new DataContext())
                {
                    var items = сc.worker.Find(id);
                    if (items != null)
                    {
                        сc.worker.Remove(items);
                        сc.SaveChanges();
                        textBox7.Text = "";
                        UpdateDataGridView1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
