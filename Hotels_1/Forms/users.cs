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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otchet Otchet = new Otchet();
            Otchet.Show();
        }

        private void users_Load(object sender, EventArgs e)
        {

        }
    }
}
