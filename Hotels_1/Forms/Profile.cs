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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
           
        }

        private void bron_Click(object sender, EventArgs e)
        {
            this.Hide();
            bronirovanie bronirovanie = new bronirovanie();
            bronirovanie.Show();
        }

        private void uslugi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Uslugi Uslugi = new Uslugi();
            Uslugi.Show();
        }

        private void sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale Sale = new Sale();
            Sale.Show();
        }

        private void info_Click(object sender, EventArgs e)
        {

        }

        private void contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact Contact = new Contact();
            Contact.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
