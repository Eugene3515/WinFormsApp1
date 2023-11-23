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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            UpdateDataGridView1();
        }

        private void UpdateDataGridView1()
        {
            using (DataContext dc = new DataContext())
            {
                var workListItems = dc.workLists.ToList();

                dataGridView1.Rows.Clear();

                foreach (var item in workListItems)
                {
                    dataGridView1.Rows.Add(item.Id, item.Company, item.Phone, item.Specialization);
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string companyName = textBox1.Text;
            string phone = textBox2.Text;
            string specialization = textBox3.Text;

            var newItem = new WorkList()
            {
                Company = companyName,
                Phone = phone,
                Specialization = specialization
            };

            using (DataContext dc = new DataContext())
            {
                dc.workLists.Add(newItem);
                dc.SaveChanges();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            UpdateDataGridView1();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int id))
            {
                using (DataContext dc = new DataContext())
                {
                    var item = dc.workLists.Find(id);

                    if (item != null)
                    {
                        dc.workLists.Remove(item);
                        dc.SaveChanges();
                        textBox4.Text = "";
                        UpdateDataGridView1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите корректный ID!");
            }
        }
    }

}
