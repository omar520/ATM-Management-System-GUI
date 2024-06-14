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
    public partial class CurrencyExchangePage : Form
    {
        public CurrencyExchangePage()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double a=int.Parse(amountText.Text);
            
            //Dollar to Pound and vice versa
            if (ConvFrom.SelectedItem== "USD-الدولار الأمريكي " && ConvTo.SelectedItem== "EGP-جنيه مصري")
            {
                double convert = a * 24.65;
                DisplayAmount.Text = "Converted Amount: " + convert + "\t EGP";   
            }
            if (ConvFrom.SelectedItem == "EGP-جنيه مصري" && ConvTo.SelectedItem == "USD-الدولار الأمريكي ")
            {
                double convert = a / 24.65;
                DisplayAmount.Text = "Converted Amount: " + convert + "\t $";
            }

            //Euro to Pound and vice versa
            if (ConvFrom.SelectedItem == "EUR-اليورو" && ConvTo.SelectedItem == "EGP-جنيه مصري")
            {
                double convert = a * 26.11;
                DisplayAmount.Text = "Converted Amount: " + convert + "\t EGP";
            }
            if (ConvFrom.SelectedItem == "EGP-جنيه مصري" && ConvTo.SelectedItem == "EUR-اليورو")
            {
                double convert = a / 26.11;
                DisplayAmount.Text = "Converted Amount: " + convert + "\t €";
            }

            //SAR to Pound and vice versa
            if (ConvFrom.SelectedItem == "SAR-الريال السعودي" && ConvTo.SelectedItem == "EGP-جنيه مصري")
            {
                double convert = a * 6.56;
                DisplayAmount.Text = "Converted Amount: " + convert + "\t EGP";
            }
            if (ConvFrom.SelectedItem == "EGP-جنيه مصري" && ConvTo.SelectedItem == "SAR-الريال السعودي")
            {
                double convert = a / 6.56;
                DisplayAmount.Text = "Converted Amount: " + convert + "\t SAR";
            }

            //AED to Pound and vice versa
            if (ConvFrom.SelectedItem == "AED-الدرهم الإماراتي" && ConvTo.SelectedItem == "EGP-جنيه مصري")
            {
                double convert = a * 6.71;
                DisplayAmount.Text = "Converted Amount: " + convert + "\t EGP";
            }
            if (ConvFrom.SelectedItem == "EGP-جنيه مصري" && ConvTo.SelectedItem == "AED-الدرهم الإماراتي")
            {
                double convert = a / 6.71;
                DisplayAmount.Text = "Converted Amount: " + convert + "\t AED";
            }


        }

        private void EXBackButton_Click(object sender, EventArgs e)
        {
            MainPage ExmainPage = new MainPage();
            this.Hide();
            ExmainPage.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
