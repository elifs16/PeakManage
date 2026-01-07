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

namespace takipSistemi16
{
    public partial class AdminForm : Form
    {
        EmployeeManager _employeeManager;
        Form _previousForm;
        public AdminForm(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
            _employeeManager = new EmployeeManager();
            LoadEmployees();
            AdminManager manager = new AdminManager();

        }

        private void LoadEmployees()
        {

            AdminManager manager = new AdminManager();
            dgvUsers.DataSource = manager.GetEmployeesWithPerformance();

            dgvUsers.DataSource = _employeeManager.GetEmployees();

            dgvUsers.Columns["UserID"].Visible = false;
            dgvUsers.Columns["Password"].Visible = false;
            dgvUsers.Columns["PersonelID"].Visible = false;
            dgvUsers.Columns["CreatedDate"].Visible = false;
            dgvUsers.Columns["Id"].Visible = false;

            dgvUsers.Columns["UserName"].HeaderText = "Kullanıcı Adı";
            dgvUsers.Columns["Role"].HeaderText = "Rol";
            dgvUsers.Columns["Department"].HeaderText = "Departman";
            dgvUsers.Columns["Maas"].HeaderText = "Maaş";
      
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnIzinOnaylari_Click(object sender, EventArgs e)
        {
            IzinOnayForm frm = new IzinOnayForm(this);
            frm.Show();
            this.Hide();
        }

        private void btnMaasRapor_Click(object sender, EventArgs e)
        {
            MaasRaporForm frm = new MaasRaporForm(this);
            frm.Show();
            this.Hide();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _previousForm.Show();
            this.Close();
        }
    }
}
