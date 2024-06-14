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
    public partial class WithdrawPage : Form
    {
        public WithdrawPage()
        {
            InitializeComponent();
      
        }
        
        private void Backbutton_Click(object sender, EventArgs e)
        {
            MainPage BackmainPage = new MainPage();
            this.Hide();
            BackmainPage.ShowDialog();
        }

        private void WithdrawTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void WithdrawTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(WithdrawTextBox.Text);
                if (amount < 0)
                {
                    MessageBox.Show("You Can't Enter a Negative Value");
                }
                if (amount > BalancePage.intialBalance)
                {
                    MessageBox.Show("You don't have enough money");
                }
                else
                {
                    BalancePage.intialBalance -= amount;
                    MessageBox.Show("Withdrawal Successful");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter a Valid Value");
            }
        }
    }
}

