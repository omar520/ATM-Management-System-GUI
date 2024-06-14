using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class BalancePage : Form
    {
        public BalancePage()
        {
            InitializeComponent();
        }

        private static int Bcash;
        public static int intialBalance
        {
            get 
            {
                return Bcash;
            }
            set 
            {
                Bcash = value;
            }
        }   
        private void BalancePage_Load(object sender, EventArgs e)
        {
           // intialBalance = 0;

            label5.Text = intialBalance.ToString() + " EGP";
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            MainPage BackmainPage = new MainPage();
            this.Hide();
            BackmainPage.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Acc_Id_Balance_Click(object sender, EventArgs e)
        {

        }
    }
}
