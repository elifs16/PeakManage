namespace takipSistemi16
{
    partial class UserForm
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
            grpLeaveRequest = new GroupBox();
            btnLeaveRequest = new Button();
            txtDescription = new TextBox();
            label3 = new Label();
            dtEnd = new DateTimePicker();
            label2 = new Label();
            dtStart = new DateTimePicker();
            label1 = new Label();
            dgvLeaves = new DataGridView();
            btnExit = new Button();
            label4 = new Label();
            grpLeaveRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLeaves).BeginInit();
            SuspendLayout();
            // 
            // grpLeaveRequest
            // 
            grpLeaveRequest.BackColor = Color.LightGray;
            grpLeaveRequest.Controls.Add(btnLeaveRequest);
            grpLeaveRequest.Controls.Add(txtDescription);
            grpLeaveRequest.Controls.Add(label3);
            grpLeaveRequest.Controls.Add(dtEnd);
            grpLeaveRequest.Controls.Add(label2);
            grpLeaveRequest.Controls.Add(dtStart);
            grpLeaveRequest.Controls.Add(label1);
            grpLeaveRequest.Location = new Point(23, 84);
            grpLeaveRequest.Name = "grpLeaveRequest";
            grpLeaveRequest.Size = new Size(305, 400);
            grpLeaveRequest.TabIndex = 0;
            grpLeaveRequest.TabStop = false;
            grpLeaveRequest.Text = "İzin Talep Et";
            // 
            // btnLeaveRequest
            // 
            btnLeaveRequest.BackColor = Color.LightBlue;
            btnLeaveRequest.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnLeaveRequest.Location = new Point(191, 333);
            btnLeaveRequest.Name = "btnLeaveRequest";
            btnLeaveRequest.Size = new Size(94, 51);
            btnLeaveRequest.TabIndex = 5;
            btnLeaveRequest.Text = "İzin Talep Et";
            btnLeaveRequest.UseVisualStyleBackColor = false;
            btnLeaveRequest.Click += btnLeaveRequest_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(24, 277);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 34);
            txtDescription.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(24, 235);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Açıklama";
            // 
            // dtEnd
            // 
            dtEnd.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtEnd.Location = new Point(24, 183);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(250, 28);
            dtEnd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(24, 137);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 1;
            label2.Text = "Bitiş Tarihi";
            // 
            // dtStart
            // 
            dtStart.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtStart.Location = new Point(24, 80);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(250, 28);
            dtStart.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 42);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 0;
            label1.Text = "Başlangıç Tarihi";
            // 
            // dgvLeaves
            // 
            dgvLeaves.AllowUserToAddRows = false;
            dgvLeaves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLeaves.BackgroundColor = SystemColors.Control;
            dgvLeaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaves.Location = new Point(352, 84);
            dgvLeaves.Name = "dgvLeaves";
            dgvLeaves.ReadOnly = true;
            dgvLeaves.RowHeadersWidth = 51;
            dgvLeaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaves.Size = new Size(553, 342);
            dgvLeaves.TabIndex = 1;
            dgvLeaves.CellContentClick += dgvLeaves_CellContentClick;
            dgvLeaves.CellFormatting += dgvLeaves_CellFormatting;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnExit.Location = new Point(776, 470);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 42);
            btnExit.TabIndex = 2;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(392, 20);
            label4.Name = "label4";
            label4.Size = new Size(152, 26);
            label4.TabIndex = 3;
            label4.Text = "İzin İşlemleri";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(936, 548);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(dgvLeaves);
            Controls.Add(grpLeaveRequest);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Paneli - İzin İşlemleri";
            Load += UserForm_Load;
            grpLeaveRequest.ResumeLayout(false);
            grpLeaveRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLeaves).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLeaveRequest;
        private Button btnLeaveRequest;
        private TextBox txtDescription;
        private Label label3;
        private DateTimePicker dtEnd;
        private Label label2;
        private DateTimePicker dtStart;
        private Label label1;
        private DataGridView dgvLeaves;
        private Button btnExit;
        private Label label4;
    }
}