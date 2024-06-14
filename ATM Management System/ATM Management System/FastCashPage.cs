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
    public partial class FastCashPage : Form
    {
        public FastCashPage()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            int fif = 200;
            if (fif <= BalancePage.intialBalance)
            {
                BalancePage.intialBalance -= fif;
                MessageBox.Show("Withdrawal Successful");
            }
            else
            {
                MessageBox.Show("You don't have enough money");

            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            MainPage BackmainPage = new MainPage();
            this.Hide();
            BackmainPage.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int fif = 50;
            if (fif<= BalancePage.intialBalance)
            {
            BalancePage.intialBalance -= fif;
                MessageBox.Show("Withdrawal Successful");
            }
            else
            {
                MessageBox.Show("You don't have enough money");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int fif = 100;
            if (fif <= BalancePage.intialBalance)
            {
                BalancePage.intialBalance -= fif;
                MessageBox.Show("Withdrawal Successful");
            }
            else
            {
                MessageBox.Show("You don't have enough money");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int fif = 500;
            if (fif <= BalancePage.intialBalance)
            {
                BalancePage.intialBalance -= fif;
                MessageBox.Show("Withdrawal Successful");
            }
            else
            {
                MessageBox.Show("You don't have enough money");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int fif = 1000;
            if (fif <= BalancePage.intialBalance)
            {
                BalancePage.intialBalance -= fif;
                MessageBox.Show("Withdrawal Successful");
            }
            else
            {
                MessageBox.Show("You don't have enough money");
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            int fif = 2000;
            if (fif <= BalancePage.intialBalance)
            {
                BalancePage.intialBalance -= fif;
                MessageBox.Show("Withdrawal Successful");
            }
            else
            {
                MessageBox.Show("You don't have enough money");
            }
        }
    }
}
