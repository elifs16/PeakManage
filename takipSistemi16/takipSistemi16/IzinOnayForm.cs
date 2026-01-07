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


namespace takipSistemi16
{
    public partial class IzinOnayForm : Form
    {
        IzinManager _manager = new IzinManager();
        Form _previousForm;

        public IzinOnayForm(Form previousForm)
        {
            InitializeComponent();

            _previousForm = previousForm;

            LoadIzinler();
        }
        private void LoadIzinler()
        {
            var tumIzinler = _manager.GetAllIzinler();

            dgvIzinler.DataSource = tumIzinler
                .Where(x => x.Durum == "Beklemede")
                .ToList();

            dgvIzinler.Columns["IzinID"].Visible = false;
        }



        private void IzinOnayForm_Load(object sender, EventArgs e)
        {
            dgvIzinler.DataSource = _manager.GetAllIzinler();

        }
        int GetSelectedIzinId()
        {
            if (dgvIzinler.CurrentRow == null)
                return -1;

            return Convert.ToInt32(
                dgvIzinler.CurrentRow.Cells["IzinID"].Value
            );
        }


        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int izinId = GetSelectedIzinId();

            if (izinId == -1)
            {
                MessageBox.Show("Lütfen izin seçin");
                return;
            }

            _manager.Onayla(izinId);
            dgvIzinler.DataSource = _manager.GetAllIzinler();
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            int izinId = GetSelectedIzinId();

            if (izinId == -1)
            {
                MessageBox.Show("Lütfen izin seçin");
                return;
            }

            _manager.Reddet(izinId);
            dgvIzinler.DataSource = _manager.GetAllIzinler();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _previousForm.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            _previousForm.Show();
        }

        private void dgvIzinler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvIzinler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvIzinler.Columns[e.ColumnIndex].Name == "Durum")
            {
                if (e.Value != null)
                {
                    string durum = e.Value.ToString();

                    if (durum == "Onaylandı")
                    {
                        dgvIzinler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (durum == "Reddedildi")
                    {
                        dgvIzinler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else if (durum == "Beklemede")
                    {
                        dgvIzinler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                }
            }
        }
    }
}
