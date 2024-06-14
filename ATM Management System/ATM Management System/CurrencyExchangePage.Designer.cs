namespace ATM_Management_System
{
    partial class CurrencyExchangePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyExchangePage));
            this.ConvFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayAmount = new System.Windows.Forms.Label();
            this.ConvTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ConvertButton = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.EXBackButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvFrom
            // 
            this.ConvFrom.AutoRoundedCorners = true;
            this.ConvFrom.BackColor = System.Drawing.Color.Transparent;
            this.ConvFrom.BorderRadius = 17;
            this.ConvFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ConvFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConvFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConvFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConvFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ConvFrom.ItemHeight = 30;
            this.ConvFrom.Items.AddRange(new object[] {
            "USD-الدولار الأمريكي ",
            "EGP-جنيه مصري",
            "EUR-اليورو",
            "SAR-الريال السعودي",
            "AED-الدرهم الإماراتي"});
            this.ConvFrom.Location = new System.Drawing.Point(385, 268);
            this.ConvFrom.Name = "ConvFrom";
            this.ConvFrom.Size = new System.Drawing.Size(261, 36);
            this.ConvFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Amount";
            // 
            // amountText
            // 
            this.amountText.Animated = true;
            this.amountText.AutoRoundedCorners = true;
            this.amountText.BackColor = System.Drawing.Color.Transparent;
            this.amountText.BorderColor = System.Drawing.Color.Transparent;
            this.amountText.BorderRadius = 24;
            this.amountText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountText.DefaultText = "";
            this.amountText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amountText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amountText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.amountText.ForeColor = System.Drawing.Color.Black;
            this.amountText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountText.Location = new System.Drawing.Point(385, 189);
            this.amountText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.amountText.Name = "amountText";
            this.amountText.PasswordChar = '\0';
            this.amountText.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.amountText.PlaceholderText = "1000$";
            this.amountText.SelectedText = "";
            this.amountText.Size = new System.Drawing.Size(222, 51);
            this.amountText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumPurple;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Convert From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumPurple;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Convert To";
            // 
            // DisplayAmount
            // 
            this.DisplayAmount.AutoSize = true;
            this.DisplayAmount.BackColor = System.Drawing.Color.MediumPurple;
            this.DisplayAmount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayAmount.ForeColor = System.Drawing.Color.White;
            this.DisplayAmount.Location = new System.Drawing.Point(158, 424);
            this.DisplayAmount.Name = "DisplayAmount";
            this.DisplayAmount.Size = new System.Drawing.Size(285, 38);
            this.DisplayAmount.TabIndex = 9;
            this.DisplayAmount.Text = "Converted Amount: ";
            // 
            // ConvTo
            // 
            this.ConvTo.AutoRoundedCorners = true;
            this.ConvTo.BackColor = System.Drawing.Color.Transparent;
            this.ConvTo.BorderRadius = 17;
            this.ConvTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ConvTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConvTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConvTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConvTo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ConvTo.ItemHeight = 30;
            this.ConvTo.Items.AddRange(new object[] {
            "USD-الدولار الأمريكي ",
            "EGP-جنيه مصري",
            "EUR-اليورو",
            "SAR-الريال السعودي",
            "AED-الدرهم الإماراتي"});
            this.ConvTo.Location = new System.Drawing.Point(385, 339);
            this.ConvTo.Name = "ConvTo";
            this.ConvTo.Size = new System.Drawing.Size(261, 36);
            this.ConvTo.TabIndex = 10;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Animated = true;
            this.ConvertButton.AutoRoundedCorners = true;
            this.ConvertButton.BackColor = System.Drawing.Color.Transparent;
            this.ConvertButton.BorderRadius = 25;
            this.ConvertButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConvertButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConvertButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConvertButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConvertButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.ConvertButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.ForeColor = System.Drawing.Color.White;
            this.ConvertButton.Location = new System.Drawing.Point(656, 187);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(163, 53);
            this.ConvertButton.TabIndex = 11;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseTransparentBackground = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(317, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 59);
            this.label4.TabIndex = 12;
            this.label4.Text = "Currency Converter";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(630, 522);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(62, 62);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // EXBackButton
            // 
            this.EXBackButton.Animated = true;
            this.EXBackButton.AutoRoundedCorners = true;
            this.EXBackButton.BackColor = System.Drawing.Color.Transparent;
            this.EXBackButton.BorderRadius = 30;
            this.EXBackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EXBackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EXBackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EXBackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EXBackButton.FillColor = System.Drawing.Color.Tomato;
            this.EXBackButton.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold);
            this.EXBackButton.ForeColor = System.Drawing.Color.White;
            this.EXBackButton.IndicateFocus = true;
            this.EXBackButton.Location = new System.Drawing.Point(698, 522);
            this.EXBackButton.Name = "EXBackButton";
            this.EXBackButton.PressedColor = System.Drawing.Color.Turquoise;
            this.EXBackButton.PressedDepth = 40;
            this.EXBackButton.Size = new System.Drawing.Size(131, 62);
            this.EXBackButton.TabIndex = 18;
            this.EXBackButton.Text = "Back";
            this.EXBackButton.Click += new System.EventHandler(this.EXBackButton_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(229, 19);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(82, 79);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 20;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Location = new System.Drawing.Point(-13, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(951, 117);
            this.guna2Panel1.TabIndex = 21;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 28;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(137, 496);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(325, 58);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Transfer to Account Balance";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // CurrencyExchangePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 612);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.EXBackButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConvTo);
            this.Controls.Add(this.DisplayAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvFrom);
            this.MaximizeBox = false;
            this.Name = "CurrencyExchangePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrencyExchangePage";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ConvFrom;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox amountText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DisplayAmount;
        private Guna.UI2.WinForms.Guna2ComboBox ConvTo;
        private Guna.UI2.WinForms.Guna2Button ConvertButton;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button EXBackButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}