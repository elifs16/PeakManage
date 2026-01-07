namespace takipSistemi16
{
    partial class IKForm
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
            dgvEmployees = new DataGridView();
            btnGoLeave = new Button();
            btnAddPerformance = new Button();
            groupBox1 = new GroupBox();
            cmbDepartment = new ComboBox();
            label5 = new Label();
            numMaas = new NumericUpDown();
            label4 = new Label();
            btnAddEmployee = new Button();
            cmbRole = new ComboBox();
            txtNewPassword = new TextBox();
            txtNewUserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaas).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = SystemColors.ControlLight;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(349, 24);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(575, 398);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // btnGoLeave
            // 
            btnGoLeave.BackColor = SystemColors.GradientActiveCaption;
            btnGoLeave.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGoLeave.Location = new Point(415, 442);
            btnGoLeave.Name = "btnGoLeave";
            btnGoLeave.Size = new Size(109, 75);
            btnGoLeave.TabIndex = 1;
            btnGoLeave.Text = "İzin Ekle";
            btnGoLeave.UseVisualStyleBackColor = false;
            btnGoLeave.Click += btnGoLeave_Click;
            // 
            // btnAddPerformance
            // 
            btnAddPerformance.BackColor = SystemColors.GradientActiveCaption;
            btnAddPerformance.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAddPerformance.Location = new Point(598, 442);
            btnAddPerformance.Name = "btnAddPerformance";
            btnAddPerformance.Size = new Size(123, 75);
            btnAddPerformance.TabIndex = 2;
            btnAddPerformance.Text = "Performans Ekle";
            btnAddPerformance.UseVisualStyleBackColor = false;
            btnAddPerformance.Click += btnAddPerformance_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(cmbDepartment);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numMaas);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAddEmployee);
            groupBox1.Controls.Add(cmbRole);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtNewUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 472);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Ekle";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(137, 225);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 26);
            cmbDepartment.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(11, 175);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 9;
            label5.Text = "Rol:";
            // 
            // numMaas
            // 
            numMaas.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numMaas.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            numMaas.Location = new Point(137, 287);
            numMaas.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numMaas.Name = "numMaas";
            numMaas.Size = new Size(150, 25);
            numMaas.TabIndex = 8;
            numMaas.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 287);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 7;
            label4.Text = "Maaş:";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.AntiqueWhite;
            btnAddEmployee.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAddEmployee.Location = new Point(149, 360);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(125, 70);
            btnAddEmployee.TabIndex = 6;
            btnAddEmployee.Text = "Personeli Kaydet";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(136, 174);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(151, 26);
            cmbRole.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(151, 122);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(125, 25);
            txtNewPassword.TabIndex = 4;
            // 
            // txtNewUserName
            // 
            txtNewUserName.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewUserName.Location = new Point(149, 62);
            txtNewUserName.Name = "txtNewUserName";
            txtNewUserName.Size = new Size(125, 25);
            txtNewUserName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(5, 225);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 2;
            label3.Text = "Departman:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(10, 120);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(11, 62);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientActiveCaption;
            btnExit.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(792, 442);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 75);
            btnExit.TabIndex = 4;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // IKForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(936, 548);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Controls.Add(btnAddPerformance);
            Controls.Add(btnGoLeave);
            Controls.Add(dgvEmployees);
            Name = "IKForm";
            Text = "IKForm";
            Load += IKForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployees;
        private Button btnGoLeave;
        private Button btnAddPerformance;
        private GroupBox groupBox1;
        private ComboBox cmbRole;
        private TextBox txtNewPassword;
        private TextBox txtNewUserName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddEmployee;
        private Button btnExit;
        private NumericUpDown numMaas;
        private Label label4;
        private ComboBox cmbDepartment;
        private Label label5;
    }
}