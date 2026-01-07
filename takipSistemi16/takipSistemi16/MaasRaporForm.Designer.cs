namespace takipSistemi16
{
    partial class MaasRaporForm
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
            dgvMaas = new DataGridView();
            lblToplamMaas = new Label();
            btnExit = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblPazarlama = new Label();
            lblIK = new Label();
            lblFinans = new Label();
            lblIT = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMaas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMaas
            // 
            dgvMaas.BackgroundColor = SystemColors.Control;
            dgvMaas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaas.Location = new Point(43, 68);
            dgvMaas.Name = "dgvMaas";
            dgvMaas.RowHeadersWidth = 51;
            dgvMaas.Size = new Size(468, 395);
            dgvMaas.TabIndex = 0;
            dgvMaas.CellFormatting += dgvMaas_CellFormatting;
            // 
            // lblToplamMaas
            // 
            lblToplamMaas.AutoSize = true;
            lblToplamMaas.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblToplamMaas.Location = new Point(17, 256);
            lblToplamMaas.Name = "lblToplamMaas";
            lblToplamMaas.Size = new Size(156, 21);
            lblToplamMaas.TabIndex = 1;
            lblToplamMaas.Text = "Toplam Maaş: 0 TL";
            lblToplamMaas.Click += lblToplamMaas_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Location = new Point(736, 416);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 62);
            btnExit.TabIndex = 2;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 11);
            label1.Name = "label1";
            label1.Size = new Size(149, 26);
            label1.TabIndex = 3;
            label1.Text = "Maaş Raporu";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(lblPazarlama);
            groupBox1.Controls.Add(lblIK);
            groupBox1.Controls.Add(lblFinans);
            groupBox1.Controls.Add(lblToplamMaas);
            groupBox1.Controls.Add(lblIT);
            groupBox1.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(603, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 299);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Departman Maaşları";
            // 
            // lblPazarlama
            // 
            lblPazarlama.AutoSize = true;
            lblPazarlama.Location = new Point(18, 205);
            lblPazarlama.Name = "lblPazarlama";
            lblPazarlama.Size = new Size(89, 21);
            lblPazarlama.TabIndex = 5;
            lblPazarlama.Text = "Pazarlama";
            // 
            // lblIK
            // 
            lblIK.AutoSize = true;
            lblIK.Location = new Point(18, 142);
            lblIK.Name = "lblIK";
            lblIK.Size = new Size(27, 21);
            lblIK.TabIndex = 5;
            lblIK.Text = "IK";
            // 
            // lblFinans
            // 
            lblFinans.AutoSize = true;
            lblFinans.Location = new Point(17, 87);
            lblFinans.Name = "lblFinans";
            lblFinans.Size = new Size(61, 21);
            lblFinans.TabIndex = 1;
            lblFinans.Text = "Finans";
            // 
            // lblIT
            // 
            lblIT.AutoSize = true;
            lblIT.Location = new Point(17, 35);
            lblIT.Name = "lblIT";
            lblIT.Size = new Size(26, 21);
            lblIT.TabIndex = 0;
            lblIT.Text = "IT";
            // 
            // MaasRaporForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(936, 548);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(dgvMaas);
            Name = "MaasRaporForm";
            Text = "MaasRaporForm";
            Load += MaasRaporForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMaas;
        private Label lblToplamMaas;
        private Button btnExit;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblPazarlama;
        private Label lblIK;
        private Label lblFinans;
        private Label lblIT;
    }
}