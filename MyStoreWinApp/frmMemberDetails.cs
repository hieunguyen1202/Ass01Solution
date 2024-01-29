using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject memberInfo { get; set; }
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            tbMemberId.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate && memberInfo != null)
            {
                tbMemberId.Text = memberInfo.MemberId.ToString();
                tbMemberName.Text = memberInfo.MemberName;
                tbMemberEmail.Text = memberInfo.Email;
                tbMemberPassword.Text = memberInfo.Password;
                tbMemberCity.Text = memberInfo.City;
                tbMemberCountry.Text = memberInfo.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberId = Convert.ToInt32(tbMemberId.Text),
                    Password = tbMemberPassword.Text,
                    Email = tbMemberEmail.Text,
                    City = tbMemberCity.Text.ToUpper(),
                    MemberName = tbMemberName.Text.ToUpper(),
                    Country = tbMemberCountry.Text.ToUpper()
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.AddNewMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();


    }
}
