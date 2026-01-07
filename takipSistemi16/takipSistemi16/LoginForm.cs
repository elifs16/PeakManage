using System.Windows.Forms;
using takipSistemi16.BLL;
using takipSistemi16.BLL.Concrete;
using takipSistemi16.Entity;
using takipSistemi16;

namespace takipSistemi16
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        List<string> motivasyonSozleri = new List<string>
{
    "Baþarý, küçük çabalarýn her gün tekrarlanmasýdýr. – Robert Collier",
    "Hayal edebildiðin her þey gerçektir. – Pablo Picasso",
    "Yola çýkmak için mükemmel olmak zorunda deðilsin, ama mükemmel olmak için yola çýkmalýsýn. – Zig Ziglar",
    "Çalýþmadan, öðrenmeden, yorulmadan rahat yaþamanýn yollarýný arayanlar önce haysiyetlerini, sonra hürriyetlerini kaybederler. – Atatürk",
    "Baþarý cesaretle baþlar. – Winston Churchill",
    "Ýnsan, inandýðý kadar güçlüdür. – Mevlânâ",
    "Bugün attýðýn küçük adýmlar, yarýnýn büyük baþarýsýdýr.",
    "Disiplin, hedefler ile baþarý arasýndaki köprüdür. – Jim Rohn"
};


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager manager = new UserManager();
                User user = manager.Login(txtUsername.Text, txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý");
                    return;
                }

                string secim = cmbYetki.SelectedItem.ToString();


                if (secim == "Admin" && user.Role == "Admin")
                {
                    AdminForm af = new AdminForm(this);
                    af.Show();
                    this.Hide();
                }

                else if (secim == "IK" && user.Role == "IK")
                {
                    IKForm ikForm = new IKForm(user.UserName, this);
                    ikForm.Show();
                    this.Hide();
                }

                else if (
                    user.Role == "User")
                {
                    UserForm uf = new UserForm(user.UserName, this);
                    uf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yetkisiz giriþ");
                }

                txtUsername.Clear();
                txtPassword.Clear();
                cmbYetki.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbYetki.Items.Add("Admin");
            cmbYetki.Items.Add("IK");
            cmbYetki.Items.Add("User");

            Random rnd = new Random();
            int index = rnd.Next(motivasyonSozleri.Count);
            lblMotivation.Text = motivasyonSozleri[index];
            lblMotivation.ForeColor = Color.FromArgb(90, 90, 90);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblMotivation_Click(object sender, EventArgs e)
        {

        }
    }
}
