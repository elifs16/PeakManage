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
using takipSistemi16;

namespace takipSistemi16
{
    public partial class PerformansForm : Form
    {
        private string _userName;
        PerformansManager manager;
        private Form _previousForm;

        public PerformansForm(string userName, Form previousForm)
        {
            InitializeComponent();
            _userName = userName;
            _previousForm = previousForm;
            manager = new PerformansManager();


            numScore.Minimum = 0;
            numScore.Maximum = 10;

            lblUser.Text = "Personel: " + userName;
        }

        PerformansManager _manager = new PerformansManager();

        private void LoadPerformanslar()
        {
            dgvPerformans.DataSource = null;
            dgvPerformans.DataSource = _manager.GetAll();
        }

        private void PerformansForm_Load(object sender, EventArgs e)
        {
            LoadPerformanslar();

            PerformansManager manager = new PerformansManager();
            dgvPerformans.DataSource = manager.GetAll();

            dgvPerformans.Columns["PerformansID"].Visible = false;
            dgvPerformans.Columns["UserName"].HeaderText = "Personel";
            dgvPerformans.Columns["Puan"].HeaderText = "Performans Puanı";
            dgvPerformans.Columns["Tarih"].HeaderText = "Tarih";
            dgvPerformans.Columns["Aciklama"].HeaderText = "Açıklama";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                manager.AddScore(
                    _userName,
                    (int)numScore.Value,
                    txtAciklama.Text
                );

                MessageBox.Show("Performans başarıyla eklendi");
                LoadPerformanslar();
                numScore.Value = 0;
                txtAciklama.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_previousForm != null)
                _previousForm.Show();
            this.Close();
        }

        private void dgvPerformans_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPerformans.Columns[e.ColumnIndex].Name == "Puan")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int puan))
                {
                    if (puan >= 8)
                    {
                        dgvPerformans.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (puan >= 5)
                    {
                        dgvPerformans.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else
                    {
                        dgvPerformans.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }
    }
}
