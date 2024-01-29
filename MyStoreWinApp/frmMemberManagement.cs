using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{

    public partial class frmMemberManagement : Form
    {
        //private IMemberRepository memberRepository;
        public frmMemberManagement()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
        }

        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        private void ClearText()
        {
            tbMemberId.Clear();
            tbMemberName.Clear();
            tbMemberPassword.Clear();
            tbMemberEmail.Clear();
            tbMemberCity.Clear();
            tbMemberCountry.Clear();
        }

        private void RefreshDataInForm(List<MemberObject> MemberList)
        {
            //re-load Member List in Data grid view 
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = MemberList;
            grMemberList.DataSource = bindingSource;
            //update Datasource in filter
            cbFilterCity.DataSource = MemberList.Select(q => q.City.ToUpper()).Distinct().ToList();
            cbFilterCountry.DataSource = MemberList.Select(q => q.Country.ToUpper()).Distinct().ToList();
            ClearText();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {

            //grMemberList.Columns[0].HeaderText = "Id";
            //grMemberList.Columns[1].HeaderText = "Name";
            //grMemberList.Columns[2].HeaderText = "Email";
            //grMemberList.Columns[3].HeaderText = "Password";
            //grMemberList.Columns[4].HeaderText = "City";
            //grMemberList.Columns[5].HeaderText = "Country";
 

            // mất dòng tự tạo ở thuộc tính này , chỉnh về false để chỉ hiện ra data
            btDeleteMember.Enabled = false;
            grMemberList.CellDoubleClick += grMemberList_CellContentClick;
            grMemberList.AllowUserToAddRows = false;
            //var memberList = memberRepository.GetAllMembers();
            //grMemberList.DataSource = memberList;
            //cbFilterCity.DataSource = memberList.Select(q => q.City.ToUpper()).Distinct().ToList();
            //cbFilterCountry.DataSource = memberList.Select(q => q.Country.ToUpper()).Distinct().ToList();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var searchId = tbSearchId.Text.Trim();
            var searchName = tbSearchName.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchId) || string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Please enter id and Name");
            }
            else
            {
                int memberId;
                bool isIdValid = int.TryParse(searchId, out memberId);

                if (!isIdValid)
                {
                    MessageBox.Show("Invalid Id");
                    return;
                }

                var member = memberRepository.getMemberByIdAndName(memberId, searchName.ToUpper());

                if (member == null)
                {
                    MessageBox.Show("Member not found");
                    return;
                }

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = member;
                grMemberList.DataSource = bindingSource;
            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            var city = cbFilterCity.SelectedItem?.ToString().ToUpper();
            var country = cbFilterCountry.SelectedItem?.ToString().ToUpper();

            if (string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("Please select City and Country");
            }
            else
            {
                var filteredList = memberRepository.FilterListByCityAndCountry(city, country);
                grMemberList.DataSource = filteredList;
            }
        }
        private void btNewMember_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmCarDetails = new frmMemberDetails
            {
                Text = "Add new member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }

        }
       

        private void ClearDataBindings()
        {
            tbMemberId.DataBindings.Clear();
            tbMemberPassword.DataBindings.Clear();
            tbMemberEmail.DataBindings.Clear();
            tbMemberCity.DataBindings.Clear();
            tbMemberName.DataBindings.Clear();
            tbMemberCountry.DataBindings.Clear();
        }

        private void BindDataControls()
        {
            tbMemberId.DataBindings.Add("Text", source, "MemberId");
            tbMemberPassword.DataBindings.Add("Text", source, "Password");
            tbMemberEmail.DataBindings.Add("Text", source, "Email");
            tbMemberCity.DataBindings.Add("Text", source, "City");
            tbMemberName.DataBindings.Add("Text", source, "MemberName");
            tbMemberCountry.DataBindings.Add("Text", source, "Country");
        }

    
   
        private void btDeleteMember_Click(object sender, EventArgs e)
        {

            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberId);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }



        private void chbSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbSort_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbSort.Checked)
            {
                RefreshDataInForm(memberRepository.SortMemberListDescendingName());
            }
            else
            {
                RefreshDataInForm(memberRepository.GetAllMembers());
            }
        }

        private void btClose_Click(object sender, EventArgs e) => Close();


        private void grMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmCarDetails = new frmMemberDetails
            {
                Text = "Update car",
                InsertOrUpdate = true,
                memberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
        private MemberObject GetMemberObject()
        {
            MemberObject member = new MemberObject(); // Initialize with a default instance
            try
            {
                member = new MemberObject
                {
                    MemberId = int.Parse(tbMemberId.Text),
                    MemberName = tbMemberName.Text,
                    Password = tbMemberPassword.Text,
                    Email = tbMemberEmail.Text,
                    City = tbMemberCity.Text,
                    Country = tbMemberCountry.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<MemberObject> memberList = LoadMemberList();
            cbFilterCity.DataSource = memberList.Select(q => q.City.ToUpper()).Distinct().ToList();
            cbFilterCountry.DataSource = memberList.Select(q => q.Country.ToUpper()).Distinct().ToList();
        }
        private List<BusinessObject.MemberObject> LoadMemberList()
        {
            try
            {
                var members = memberRepository.GetAllMembers();

                source = new BindingSource();
                source.DataSource = members;

                ClearDataBindings();

                BindDataControls();

                grMemberList.DataSource = null;
                grMemberList.DataSource = source;

                btDeleteMember.Enabled = (members.Count > 0);

                return members; // Return the member list
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
                return new List<BusinessObject.MemberObject>(); // Return an empty list in case of an error
            }
        }
        //public void LoadMemberList()
        //{
        //    try
        //    {
        //        var members = memberRepository.GetAllMembers();

        //        source = new BindingSource();
        //        source.DataSource = members;

        //        ClearDataBindings();

        //        BindDataControls();

        //        grMemberList.DataSource = null;
        //        grMemberList.DataSource = source;

        //        btDeleteMember.Enabled = (members.Count > 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Load member list");
        //    }
        //}

        //public bool IsAddNewEnabled
        //{
        //    get { return btNewMember.Enabled; }
        //    set { btNewMember.Enabled = value; }
        //}
    }
}
