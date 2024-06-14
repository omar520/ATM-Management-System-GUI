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
    public partial class DepositPage : Form
    {
        public DepositPage()
        {
            InitializeComponent();
        }
        

        private void Backbutton_Click(object sender, EventArgs e)
        {
            MainPage BackmainPage = new MainPage();
            this.Hide();
            BackmainPage.ShowDialog();
        }

        private void DepositPage_Load(object sender, EventArgs e)
        {

        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(Depsoit_TextBox.Text);
                if (amount < 0)
                {
                    MessageBox.Show("You Can't Enter a Negative Value");
                }
                else
                {
                    BalancePage.intialBalance += amount;
                    MessageBox.Show("Deposited Successfully");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter a Valid Value");
            }
        }

        private void Depsoit_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
