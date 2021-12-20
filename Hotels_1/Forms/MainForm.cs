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
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Gray;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                   
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelControl.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void info_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(new Profile(), sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bron_Click(object sender, EventArgs e)
        {
            OpenChildForm(new bronirovanie(), sender);
        }

        private void uslugi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Uslugi(), sender);

        }

        private void contact_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Contact(), sender);

        }

        private void sale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sale(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
