namespace takipSistemi16
{
    partial class IzinOnayForm
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
            dgvIzinler = new DataGridView();
            btnOnayla = new Button();
            btnReddet = new Button();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIzinler).BeginInit();
            SuspendLayout();
            // 
            // dgvIzinler
            // 
            dgvIzinler.BackgroundColor = SystemColors.Control;
            dgvIzinler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIzinler.Location = new Point(82, 59);
            dgvIzinler.Name = "dgvIzinler";
            dgvIzinler.RowHeadersWidth = 51;
            dgvIzinler.Size = new Size(731, 354);
            dgvIzinler.TabIndex = 0;
            dgvIzinler.CellContentClick += dgvIzinler_CellContentClick;
            dgvIzinler.CellFormatting += dgvIzinler_CellFormatting;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.LightGreen;
            btnOnayla.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOnayla.Location = new Point(153, 464);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(94, 62);
            btnOnayla.TabIndex = 1;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnReddet
            // 
            btnReddet.BackColor = Color.LightCoral;
            btnReddet.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnReddet.Location = new Point(418, 464);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(94, 62);
            btnReddet.TabIndex = 2;
            btnReddet.Text = "Reddet";
            btnReddet.UseVisualStyleBackColor = false;
            btnReddet.Click += btnReddet_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBack.Location = new Point(673, 464);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 62);
            btnBack.TabIndex = 3;
            btnBack.Text = "Çıkış";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 11);
            label1.Name = "label1";
            label1.Size = new Size(117, 26);
            label1.TabIndex = 4;
            label1.Text = "İzin Onay ";
            // 
            // IzinOnayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(936, 548);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnReddet);
            Controls.Add(btnOnayla);
            Controls.Add(dgvIzinler);
            Name = "IzinOnayForm";
            Text = "IzinOnayForm";
            Load += IzinOnayForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIzinler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIzinler;
        private Button btnOnayla;
        private Button btnReddet;
        private Button btnBack;
        private Label label1;
    }
}