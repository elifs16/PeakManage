using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using takipSistemi16.BLL;
using takipSistemi16.BLL.Concrete;
using takipSistemi16.Entity;

namespace takipSistemi16
{
    public partial class UserForm : Form
    {
        string _userName;
        Form _previousForm;
        public UserForm(string userName, Form previousForm)
        {
            InitializeComponent();
            _userName = userName;
            _previousForm = previousForm;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            IzinManager manager = new IzinManager();
            dgvLeaves.DataSource = manager.GetMyLeaves(_userName);
            LoadMyLeaves();
        }

        private void btnLeaveRequest_Click(object sender, EventArgs e)
        {
            try
            {
                IzinManager manager = new IzinManager();

                Izin izin = new Izin
                {
                    UserName = _userName,
                    Baslangic = dtStart.Value,
                    Bitis = dtEnd.Value,
                    Aciklama = txtDescription.Text
                };

                manager.Add(izin);
                MessageBox.Show("İzin talebi alındı");
                LoadMyLeaves();
                dtStart.Value = DateTime.Today;
                dtEnd.Value = DateTime.Today;
                txtDescription.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLeaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _previousForm.Show();
            this.Close();
        }
        void LoadMyLeaves()
        {
            IzinManager manager = new IzinManager();
            dgvLeaves.DataSource = manager.GetMyLeaves(_userName);
            if (dgvLeaves.Columns["IzinID"] != null)
                dgvLeaves.Columns["IzinID"].Visible = false;

            dgvLeaves.Columns["UserName"].Visible = false;
        }

        private void dgvLeaves_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvLeaves.Columns[e.ColumnIndex].Name == "Durum")
            {
                if (e.Value != null)
                {
                    string durum = e.Value.ToString();

                    if (durum == "Onaylandı")
                    {
                        dgvLeaves.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (durum == "Reddedildi")
                    {
                        dgvLeaves.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else if (durum == "Beklemede")
                    {
                        dgvLeaves.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
            }
        }
    }
}
