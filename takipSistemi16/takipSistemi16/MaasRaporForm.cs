using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using takipSistemi16.BLL;
using takipSistemi16.Entity;


namespace takipSistemi16
{
    public partial class MaasRaporForm : Form
    {
        EmployeeManager _employeeManager;
        Form _previousForm;

        public MaasRaporForm(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
            _employeeManager = new EmployeeManager();

            LoadMaasRaporu();
        }
        private void LoadMaasRaporu()
        {
            var list = _employeeManager.GetEmployees();

            dgvMaas.DataSource = list;

            dgvMaas.Columns["UserID"].Visible = false;
            dgvMaas.Columns["Password"].Visible = false;
            dgvMaas.Columns["PersonelID"].Visible = false;
            dgvMaas.Columns["IsActive"].Visible = false;
            dgvMaas.Columns["Role"].Visible = false;
            dgvMaas.Columns["Id"].Visible = false;
            dgvMaas.Columns["CreatedDate"].Visible = false;

            dgvMaas.Columns["UserName"].HeaderText = "Personel Adı";
            dgvMaas.Columns["Department"].HeaderText = "Departman";
            dgvMaas.Columns["Maas"].HeaderText = "Maaş";

            decimal toplamMaas = list.Sum(x => x.Maas);
            lblToplamMaas.Text = $"Toplam Maaş: {toplamMaas:N0} TL";
            CalculateTotals(list);
        }
        void CalculateTotals(List<User> list)
        {
            decimal toplam = list.Sum(x => x.Maas);


            lblIT.Text = "IT: " + list.Where(x => x.Department == "IT").Sum(x => x.Maas).ToString("N2") + " TL";
            lblFinans.Text = "Finans: " + list.Where(x => x.Department == "Finans").Sum(x => x.Maas).ToString("N2") + " TL";
            lblIK.Text = "IK: " + list.Where(x => x.Department == "IK").Sum(x => x.Maas).ToString("N2") + " TL";
            lblPazarlama.Text = "Pazarlama: " + list.Where(x => x.Department == "Pazarlama").Sum(x => x.Maas).ToString("N2") + " TL";
        }


        private void MaasRaporForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _previousForm.Show();
            this.Close();
        }

        private void lblToplamMaas_Click(object sender, EventArgs e)
        {

        }

        private void dgvMaas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvMaas.Columns[e.ColumnIndex].Name == "Maas")
            {
                decimal maas = Convert.ToDecimal(e.Value);
                DataGridViewRow row = dgvMaas.Rows[e.RowIndex];

                if (maas >= 60000)
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (maas >= 45000)
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                else
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        
    }
    }
}
