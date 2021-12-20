using Hotels_1.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotels_1.Forms
{
    public partial class Authorization : Form
    {
        Function f = new Function();
        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length == 0 || textBoxPass.Text.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else
            {
                if (f.LoginUser(textBoxLogin.Text, textBoxPass.Text))
                {
                    Authorization.ActiveForm.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();

                }
                else if (textBoxLogin.Text == "admin" && textBoxPass.Text == "admin")
                {
                    Authorization.ActiveForm.Hide();
                    MainAdminForm main = new MainAdminForm();
                    main.ShowDialog();
                    MessageBox.Show("Првиет админ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            if (reg.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Вы создали аккаунт!");
            }
            else
            {
                MessageBox.Show("Ошибка! Аккаунт не создан");
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
