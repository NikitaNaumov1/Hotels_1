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
    public partial class Uslugi : Form
    {
        public Uslugi()
        {
            InitializeComponent();
        }

        private void bron_Click(object sender, EventArgs e)
        {
            this.Hide();
            bronirovanie bronirovanie = new bronirovanie();
            bronirovanie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale Sale = new Sale();
            Sale.Show();
        }

        private void info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile Profile = new Profile();
            Profile.Show();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact Contact = new Contact();
            Contact.Show();
        }
    }
}
