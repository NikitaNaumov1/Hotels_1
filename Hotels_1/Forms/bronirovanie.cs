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
    public partial class bronirovanie : Form
    {
        Function f = new Function();

        public bronirovanie()
        {
            InitializeComponent();
        }

        private void bron_Click(object sender, EventArgs e)
        {

        }

   
        private void bronirovanie_Load(object sender, EventArgs e)
        {

        }

        private void Dropdown(object sender, EventArgs e)
        {

        }

        private void s(object sender, EventArgs e)
        {

        }
        
            private void button_bron_Click(object sender, EventArgs e)
            {

                Random rnd = new Random();
                string rndId = rnd.Next(1000, 99999).ToString();
                if (name.Text.Length == 0 || family.Text.Length == 0 || otch.Text.Length == 0 || pasp.Text.Length == 0 || kolvo.Text.Length == 0 || typ.Text.Length == 0 || phone.Text.Length == 0)
                {
                    MessageBox.Show("Поля не должны быть пустыми!");
                }
                else if (f.Bronir(name.Text, family.Text, otch.Text, dateBirth.Text, pasp.Text, kolvo.Text, dateStart.Text, dateStop.Text, typ.Text, phone.Text))
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            MessageBox.Show("Забронировано");

            }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

