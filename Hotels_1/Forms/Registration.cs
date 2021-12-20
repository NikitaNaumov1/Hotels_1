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

namespace Hotels_1
{
    public partial class Registration : Form
    {
        Function f = new Function();
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBoxLogin.Text + "ds");
            Random rnd = new Random();
            string rndId = rnd.Next(1000, 99999).ToString();
            if (textBoxLogin.Text.Length == 0 || textBoxPass.Text.Length == 0 || textBoxName.Text.Length == 0 || textBoxPhone.Text.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else if (f.RegUser(rndId, textBoxLogin.Text, textBoxPass.Text, textBoxName.Text, textBoxPhone.Text))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
