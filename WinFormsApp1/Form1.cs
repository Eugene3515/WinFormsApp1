using Microsoft.EntityFrameworkCore.Storage.Json;
using WinFormsApp1.data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registr_Click(object sender, EventArgs e)
        {
            using DataContext dc = new DataContext();
            string InLogin = loginbox.Text;
            string InPassword = passbox.Text;

            //проверка1
            if (dc.logins.Any(l => l.Login == InLogin))
            {
                MessageBox.Show("Этот логин уже существует!");
                return;
            }
            //проверка2
            int password = 0;
            if (int.TryParse(InPassword, out password))
            {
                login d = new login() { Login = InLogin, Password = password };
                dc.logins.Add(d);
                dc.SaveChanges();
                MessageBox.Show("Вы успешно зарегистрировались!");
            }
            else
            {
                MessageBox.Show("Введён некорректный пароль!");
            }
        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void autorize_Click(object sender, EventArgs e)
        {
            using (DataContext dc = new DataContext())
            {
                string InLogin = loginaut.Text;
                string InPassword = passaut.Text;

                //проверка
                if (dc.logins.Any(l => l.Login == InLogin && l.Password.ToString() == InPassword))
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
