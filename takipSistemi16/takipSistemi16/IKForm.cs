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
using takipSistemi16.Entity;
using takipSistemi16;



namespace takipSistemi16
{
    public partial class IKForm : Form
    {
        private string _userName;
        private Form _previousForm;
        EmployeeManager _employeeManager = new EmployeeManager();

        void LoadEmployees()
        {
            EmployeeManager manager = new EmployeeManager();
            dgvEmployees.DataSource = manager.GetEmployees();
            dgvEmployees.Columns["UserID"].Visible = false;
            dgvEmployees.Columns["Password"].Visible = false;
            dgvEmployees.Columns["PersonelID"].Visible = false;
            dgvEmployees.Columns["Id"].Visible = false;
            dgvEmployees.Columns["CreatedDate"].Visible = false;
        }

        string GetSelectedUserName()
        {
            if (dgvEmployees.SelectedRows.Count == 0)
                return "";

            return dgvEmployees.SelectedRows[0].Cells["UserName"].Value.ToString();
        }

        int GetSelectedUserId()
        {
            if (dgvEmployees.SelectedRows.Count == 0)
                return -1;

            return Convert.ToInt32(
                dgvEmployees.SelectedRows[0].Cells["UserID"].Value);
        }
        public IKForm(string userName, Form previousForm)
        {
            InitializeComponent();
            _userName = userName;
            _previousForm = previousForm;
            LoadEmployees();
            LoadRoles();
            LoadDepartment();


        }
        void LoadDepartment()
        {
            cmbDepartment.Items.Clear();
            cmbDepartment.Items.Add("Yönetici");
            cmbDepartment.Items.Add("Finans");
            cmbDepartment.Items.Add("IT");
            cmbDepartment.Items.Add("Pazarlama");
            cmbDepartment.Items.Add("IK");
        }

        void LoadRoles()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("User");
            cmbRole.Items.Add("IK");
            cmbRole.Items.Add("Admin");

            {
                EmployeeManager manager = new EmployeeManager();
                dgvEmployees.DataSource = manager.GetEmployees();
            }
        }




        private void IKForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGoLeave_Click(object sender, EventArgs e)
        {
            string userName = GetSelectedUserName();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Lütfen bir personel seçin");
                return;
            }

            UserForm uf = new UserForm(userName, this);
            uf.Show();
            this.Hide();
        }

        private void btnAddPerformance_Click(object sender, EventArgs e)
        {
            int userId = GetSelectedUserId();
            string userName = GetSelectedUserName();

            if (userId == -1)
            {
                MessageBox.Show("Lütfen personel seçin");
                return;
            }

            PerformansForm pf = new PerformansForm(userName, this);
            pf.Show();
            this.Hide();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewUserName.Text) ||
        string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Tüm alanları doldurun");
                return;
            }

            EmployeeManager manager = new EmployeeManager();

            manager.AddEmployee(new User
            {
                UserName = txtNewUserName.Text,
                Password = txtNewPassword.Text,
                Role = cmbRole.SelectedItem.ToString(),
                Maas = numMaas.Value,
                Department = cmbDepartment.SelectedItem.ToString(),
            });

            MessageBox.Show("Personel eklendi");

            txtNewUserName.Clear();
            txtNewPassword.Clear();

            cmbRole.SelectedIndex = 0;

            LoadEmployees();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _previousForm.Show();
            this.Close();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
