using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;
using Newtonsoft.Json;


namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private IMemberRepository memberRepository;
        //private AdminObject admin;
        private UserObject user;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            var Email = tbEmail.Text;
            var Password = tbPassword.Text;

            if (String.IsNullOrEmpty(Email) || String.IsNullOrWhiteSpace(Email)
                || String.IsNullOrEmpty(Password) || String.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter Email and Password!!");
                return;
            }

            UserObject user = UserObject.listAccount.FirstOrDefault(u => u.Email == Email && u.Password == Password);

            if (user == null)
            {
                MessageBox.Show("Invalid Email or Password!!");
                return;
            }

            if (user.IsAdmin)
            {
                this.Hide();
                frmMemberManagement AdminForm = new frmMemberManagement();
                AdminForm.Closed += (sender, e) => this.Close();
                AdminForm.Show();
            }
            else
            {
                frmMemberManagement userForm = new frmMemberManagement();
                userForm.Closed += (sender, e) => this.Close();
                userForm.btNewMember.Hide(); // Hide the "Add New" button for non-admin users
                userForm.btDeleteMember.Hide(); // Hide the "Add New" button for non-admin users
                userForm.Show();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            //using StreamReader streamReader = new StreamReader(@"D:\PRN211\MyCode\Assignment01\Ass01Solution\appsettings.json");
            //string json = streamReader.ReadToEnd();
            //admin = JsonConvert.DeserializeObject<AdminObject>(json);
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
