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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 4;
            progBar.Value = starting;
            percent.Text = "" + starting;
            if (progBar.Value == 100)
            {
                progBar.Value = 0;
                timer1.Stop();
                LoginPage log = new LoginPage();
                this.Hide();
                log.Show();
            }
            
        }
        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void percent_Click(object sender, EventArgs e)
        {

        }
    }
}
