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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            LoginPage Logout = new LoginPage();
            this.Hide();
            Logout.Show();
        }

        private void BalanceButton_Click(object sender, EventArgs e)
        {
            BalancePage Balance = new BalancePage();
            this.Hide();
            Balance.ShowDialog();
        }

        private void CurrencyExchangeButton_Click(object sender, EventArgs e)
        {
            CurrencyExchangePage currency = new CurrencyExchangePage();
            this.Hide();
            currency.ShowDialog();
        }

        private void CurrencyExchangeButton_Click_1(object sender, EventArgs e)
        {
            CurrencyExchangePage currency = new CurrencyExchangePage();
            this.Hide();
            currency.ShowDialog();
        }

        private void WithdrawButton_Click_1(object sender, EventArgs e)
        {
            WithdrawPage withdrawPage = new WithdrawPage();
            this.Hide();
            withdrawPage.ShowDialog();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            DepositPage dp = new DepositPage();
            this.Hide();
            dp.ShowDialog();
        }

        private void DepositButton_Click_1(object sender, EventArgs e)
        {
            DepositPage dp = new DepositPage();
            this.Hide();
            dp.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FastCashPage Fast= new FastCashPage();
            this.Hide();
            Fast.ShowDialog();
        }
    }
}
