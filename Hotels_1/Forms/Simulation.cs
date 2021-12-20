using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotels_1.Script;

namespace Simulation
{
    public partial class Simulat : Form
    {
        Function sql = new Function();
        
        public Simulat()
        {
            InitializeComponent();
        }

        private bool working = false;
        private int countUser = 0;


        public void SimpleGenerateUser()
        {
            string login, password, name, phone, id;

            string[] Arrlogin = { "Abdul228", "Axmed438", "Dudon336", "KireyaBitcoin" };
            string[] Arrpassword = { "Qu3jdh", "okH84N", "Pkijf94", "Fsndb72" };
            string[] Arrname = { "Имя1", "Имя2", "Имя3", "Имя4" };
            string[] Arrphone = { "232244", "32424232", "546463", "5436665" };

            Random random = new Random();

            while (working)
            {
                id = random.Next(10000, 99999).ToString();
                login = Arrlogin[random.Next(0, Arrlogin.Length - 1)];
                password = Arrpassword[random.Next(0, Arrpassword.Length - 1)];
                name = Arrname[random.Next(0, Arrname.Length - 1)];
                phone = Arrphone[random.Next(0, Arrphone.Length - 1)];


                countUser++;

                sql.RegUser(id,login,password,name,phone);
                labelCount.Invoke(new Action(() => labelCount.Text = countUser.ToString())); 


                Thread.Sleep(1000);

            }



        }




        private void Start()
        {
            working = true;
            Task.Run(() => SimpleGenerateUser());
        }

        private void Stop()
        {
            working = false;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {

            Start();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();

        }

        private void Simulation_Load(object sender, EventArgs e)
        {

        }
    }
}
