namespace takipSistemi16
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            cmbYetki = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lblMotivation = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(199, 210);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(200, 263);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(42, 213);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(78, 269);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumAquamarine;
            btnLogin.Font = new Font("Sitka Banner", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.Location = new Point(407, 391);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 90);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbYetki
            // 
            cmbYetki.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYetki.FormattingEnabled = true;
            cmbYetki.Location = new Point(188, 320);
            cmbYetki.Name = "cmbYetki";
            cmbYetki.Size = new Size(151, 28);
            cmbYetki.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(55, 322);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 6;
            label3.Text = "Departman:";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_7_Oca_2026_15_05_55;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(710, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(306, 19);
            label4.Name = "label4";
            label4.Size = new Size(226, 33);
            label4.TabIndex = 8;
            label4.Text = "Personel Takip Sistemi";
            // 
            // lblMotivation
            // 
            lblMotivation.Font = new Font("Century Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMotivation.ForeColor = Color.DimGray;
            lblMotivation.Location = new Point(563, 241);
            lblMotivation.Name = "lblMotivation";
            lblMotivation.Size = new Size(212, 144);
            lblMotivation.TabIndex = 9;
            lblMotivation.Text = "label5";
            lblMotivation.TextAlign = ContentAlignment.MiddleCenter;
            lblMotivation.Click += lblMotivation_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(760, 499);
            label5.Name = "label5";
            label5.Size = new Size(151, 34);
            label5.TabIndex = 10;
            label5.Text = "© 2026 PeakManage\nDeveloped by Şahika Elif";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(218, 52);
            label6.Name = "label6";
            label6.Size = new Size(379, 19);
            label6.TabIndex = 11;
            label6.Text = "İzin, performans ve maaş süreçlerini tek yerden yönetin.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(42, 118);
            label7.Name = "label7";
            label7.Size = new Size(301, 42);
            label7.TabIndex = 12;
            label7.Text = "Hoş Geldiniz \r\nPeakManage’e giriş yaparak devam edin.";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(936, 548);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblMotivation);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(cmbYetki);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private ComboBox cmbYetki;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblMotivation;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
