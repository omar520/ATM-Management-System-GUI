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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }
        
       public void Login()
        {
           // Properties.Settings.Default.ID = textAccountId.Text;
           // Properties.Settings.Default.Save();
        }

        //public static string username;
       /*public static string account_id
        {
            get { return username; }
            set { username = value; }
        }
       */

       
        public void guna2Button1_Click(object sender, EventArgs e)
        {
            string account_id = textAccountId.Text;
            string password = textPassword.Text;
            if (account_id == "")
                MessageBox.Show("Please Enter Your Account ID");
            if (password == "")
                MessageBox.Show("Please Enter Your PIN Code");
            if ( password == "")
            {
                Login();
                MessageBox.Show("Login Succeeded");
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }   
            else
                MessageBox.Show("Login Failed");
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                textPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textPassword.UseSystemPasswordChar = false;
            }
        }

       
    }
}
