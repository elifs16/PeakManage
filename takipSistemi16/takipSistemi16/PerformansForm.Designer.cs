namespace takipSistemi16
{
    partial class PerformansForm
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
            lblUser = new Label();
            numScore = new NumericUpDown();
            label2 = new Label();
            btnSave = new Button();
            btnBack = new Button();
            label1 = new Label();
            txtAciklama = new TextBox();
            dgvPerformans = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerformans).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUser.Location = new Point(56, 107);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(55, 21);
            lblUser.TabIndex = 0;
            lblUser.Text = "label1";
            // 
            // numScore
            // 
            numScore.Location = new Point(172, 181);
            numScore.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numScore.Name = "numScore";
            numScore.Size = new Size(150, 27);
            numScore.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(29, 166);
            label2.Name = "label2";
            label2.Size = new Size(103, 42);
            label2.TabIndex = 2;
            label2.Text = "Performans \r\nPuanı:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(38, 336);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 57);
            btnSave.TabIndex = 3;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBack.Location = new Point(213, 336);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 57);
            btnBack.TabIndex = 4;
            btnBack.Text = "Çıkış";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(29, 243);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 5;
            label1.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(172, 243);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(125, 27);
            txtAciklama.TabIndex = 6;
            // 
            // dgvPerformans
            // 
            dgvPerformans.BackgroundColor = SystemColors.Control;
            dgvPerformans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerformans.Location = new Point(342, 45);
            dgvPerformans.Name = "dgvPerformans";
            dgvPerformans.RowHeadersWidth = 51;
            dgvPerformans.Size = new Size(555, 468);
            dgvPerformans.TabIndex = 7;
            dgvPerformans.CellFormatting += dgvPerformans_CellFormatting;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 21);
            label3.Name = "label3";
            label3.Size = new Size(214, 26);
            label3.TabIndex = 8;
            label3.Text = "Performans Ekleme";
            // 
            // PerformansForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(936, 548);
            Controls.Add(label3);
            Controls.Add(dgvPerformans);
            Controls.Add(txtAciklama);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(numScore);
            Controls.Add(lblUser);
            Name = "PerformansForm";
            Text = "PerformansForm";
            Load += PerformansForm_Load;
            ((System.ComponentModel.ISupportInitialize)numScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerformans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private NumericUpDown numScore;
        private Label label2;
        private Button btnSave;
        private Button btnBack;
        private Label label1;
        private TextBox txtAciklama;
        private DataGridView dgvPerformans;
        private Label label3;
    }
}