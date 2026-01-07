namespace takipSistemi16
{
    partial class AdminForm
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
            dgvUsers = new DataGridView();
            btnIzinOnaylari = new Button();
            btnMaasRapor = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.ButtonFace;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(113, 12);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(704, 394);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // btnIzinOnaylari
            // 
            btnIzinOnaylari.BackColor = SystemColors.ActiveCaption;
            btnIzinOnaylari.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIzinOnaylari.Location = new Point(178, 437);
            btnIzinOnaylari.Name = "btnIzinOnaylari";
            btnIzinOnaylari.Size = new Size(94, 76);
            btnIzinOnaylari.TabIndex = 1;
            btnIzinOnaylari.Text = "İzin Talepleri";
            btnIzinOnaylari.UseVisualStyleBackColor = false;
            btnIzinOnaylari.Click += btnIzinOnaylari_Click;
            // 
            // btnMaasRapor
            // 
            btnMaasRapor.BackColor = SystemColors.ActiveCaption;
            btnMaasRapor.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnMaasRapor.Location = new Point(412, 437);
            btnMaasRapor.Name = "btnMaasRapor";
            btnMaasRapor.Size = new Size(94, 76);
            btnMaasRapor.TabIndex = 2;
            btnMaasRapor.Text = "Maaş Rapor";
            btnMaasRapor.UseVisualStyleBackColor = false;
            btnMaasRapor.Click += btnMaasRapor_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBack.Location = new Point(648, 437);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 76);
            btnBack.TabIndex = 3;
            btnBack.Text = "Çıkış";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(936, 548);
            Controls.Add(btnBack);
            Controls.Add(btnMaasRapor);
            Controls.Add(btnIzinOnaylari);
            Controls.Add(dgvUsers);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnIzinOnaylari;
        private Button btnMaasRapor;
        private Button btnBack;
    }
}