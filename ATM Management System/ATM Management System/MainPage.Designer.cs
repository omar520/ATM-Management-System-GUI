namespace ATM_Management_System
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WithdrawButton = new Guna.UI2.WinForms.Guna2Button();
            this.CurrencyExchangeButton = new Guna.UI2.WinForms.Guna2Button();
            this.Loginbutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DepositButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BalanceButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(905, 120);
            this.guna2Panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(767, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Transaction Please";
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Animated = true;
            this.WithdrawButton.AutoRoundedCorners = true;
            this.WithdrawButton.BackColor = System.Drawing.Color.Transparent;
            this.WithdrawButton.BorderRadius = 34;
            this.WithdrawButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WithdrawButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WithdrawButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WithdrawButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WithdrawButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.WithdrawButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.WithdrawButton.ForeColor = System.Drawing.Color.White;
            this.WithdrawButton.Location = new System.Drawing.Point(587, 207);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(193, 70);
            this.WithdrawButton.TabIndex = 11;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseTransparentBackground = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click_1);
            // 
            // CurrencyExchangeButton
            // 
            this.CurrencyExchangeButton.Animated = true;
            this.CurrencyExchangeButton.AutoRoundedCorners = true;
            this.CurrencyExchangeButton.BackColor = System.Drawing.Color.Transparent;
            this.CurrencyExchangeButton.BorderRadius = 43;
            this.CurrencyExchangeButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.CurrencyExchangeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CurrencyExchangeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CurrencyExchangeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CurrencyExchangeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CurrencyExchangeButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.CurrencyExchangeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.CurrencyExchangeButton.ForeColor = System.Drawing.Color.White;
            this.CurrencyExchangeButton.Location = new System.Drawing.Point(321, 400);
            this.CurrencyExchangeButton.Name = "CurrencyExchangeButton";
            this.CurrencyExchangeButton.Size = new System.Drawing.Size(285, 88);
            this.CurrencyExchangeButton.TabIndex = 13;
            this.CurrencyExchangeButton.Text = "Currency Exchange";
            this.CurrencyExchangeButton.UseTransparentBackground = true;
            this.CurrencyExchangeButton.Click += new System.EventHandler(this.CurrencyExchangeButton_Click_1);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Animated = true;
            this.Loginbutton.AutoRoundedCorners = true;
            this.Loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.Loginbutton.BorderRadius = 26;
            this.Loginbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Loginbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Loginbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Loginbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Loginbutton.FillColor = System.Drawing.Color.OrangeRed;
            this.Loginbutton.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold);
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.IndicateFocus = true;
            this.Loginbutton.Location = new System.Drawing.Point(684, 533);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.PressedColor = System.Drawing.Color.Turquoise;
            this.Loginbutton.PressedDepth = 40;
            this.Loginbutton.Size = new System.Drawing.Size(159, 55);
            this.Loginbutton.TabIndex = 15;
            this.Loginbutton.Text = "Logout";
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(622, 533);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(56, 55);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // DepositButton
            // 
            this.DepositButton.Animated = true;
            this.DepositButton.AutoRoundedCorners = true;
            this.DepositButton.BackColor = System.Drawing.Color.Transparent;
            this.DepositButton.BorderRadius = 34;
            this.DepositButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DepositButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DepositButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DepositButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DepositButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.DepositButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.DepositButton.ForeColor = System.Drawing.Color.White;
            this.DepositButton.Location = new System.Drawing.Point(145, 207);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(193, 70);
            this.DepositButton.TabIndex = 17;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseTransparentBackground = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 34;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(145, 301);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(193, 70);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Fast Cash";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BalanceButton
            // 
            this.BalanceButton.Animated = true;
            this.BalanceButton.AutoRoundedCorners = true;
            this.BalanceButton.BackColor = System.Drawing.Color.Transparent;
            this.BalanceButton.BorderRadius = 34;
            this.BalanceButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BalanceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BalanceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BalanceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BalanceButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BalanceButton.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.BalanceButton.ForeColor = System.Drawing.Color.White;
            this.BalanceButton.Location = new System.Drawing.Point(587, 301);
            this.BalanceButton.Name = "BalanceButton";
            this.BalanceButton.Size = new System.Drawing.Size(193, 70);
            this.BalanceButton.TabIndex = 19;
            this.BalanceButton.Text = "Balance";
            this.BalanceButton.UseTransparentBackground = true;
            this.BalanceButton.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 630);
            this.Controls.Add(this.BalanceButton);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.CurrencyExchangeButton);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button WithdrawButton;
        private Guna.UI2.WinForms.Guna2Button CurrencyExchangeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button Loginbutton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button DepositButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button BalanceButton;
    }
}