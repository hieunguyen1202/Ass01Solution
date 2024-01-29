using System.Windows.Forms;

namespace MyStoreWinApp
{
    partial class frmMemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            tbMemberCountry = new TextBox();
            btDeleteMember = new Button();
            tbMemberCity = new TextBox();
            tbMemberEmail = new TextBox();
            tbMemberName = new TextBox();
            btnLoad = new Button();
            btNewMember = new Button();
            tbMemberPassword = new TextBox();
            tbMemberId = new TextBox();
            lbCountry = new Label();
            lbCity = new Label();
            lbMemberEmail = new Label();
            lbMemberName = new Label();
            lbPassword = new Label();
            lbMemberID = new Label();
            panel3 = new Panel();
            btFilter = new Button();
            cbFilterCountry = new ComboBox();
            cbFilterCity = new ComboBox();
            lbFIlterCountry = new Label();
            lbFilterCity = new Label();
            lbFilter = new Label();
            panel2 = new Panel();
            btSearch = new Button();
            tbSearchName = new TextBox();
            chbSort = new CheckBox();
            tbSearchId = new TextBox();
            lbSearch = new Label();
            lbSearchName = new Label();
            lbSearchId = new Label();
            btClose = new Button();
            grMemberList = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grMemberList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbMemberCountry);
            panel1.Controls.Add(btDeleteMember);
            panel1.Controls.Add(tbMemberCity);
            panel1.Controls.Add(tbMemberEmail);
            panel1.Controls.Add(tbMemberName);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btNewMember);
            panel1.Controls.Add(tbMemberPassword);
            panel1.Controls.Add(tbMemberId);
            panel1.Controls.Add(lbCountry);
            panel1.Controls.Add(lbCity);
            panel1.Controls.Add(lbMemberEmail);
            panel1.Controls.Add(lbMemberName);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(lbMemberID);
            panel1.Location = new System.Drawing.Point(5, 54);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1402, 220);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(644, 8);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 23);
            label4.TabIndex = 6;
            label4.Text = "List";
            // 
            // tbMemberCountry
            // 
            tbMemberCountry.Location = new System.Drawing.Point(447, 58);
            tbMemberCountry.Margin = new Padding(3, 4, 3, 4);
            tbMemberCountry.Name = "tbMemberCountry";
            tbMemberCountry.Size = new System.Drawing.Size(172, 27);
            tbMemberCountry.TabIndex = 11;
            // 
            // btDeleteMember
            // 
            btDeleteMember.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btDeleteMember.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btDeleteMember.Location = new System.Drawing.Point(477, 158);
            btDeleteMember.Margin = new Padding(3, 4, 3, 4);
            btDeleteMember.Name = "btDeleteMember";
            btDeleteMember.Size = new System.Drawing.Size(94, 32);
            btDeleteMember.TabIndex = 14;
            btDeleteMember.Text = "Delete";
            btDeleteMember.UseVisualStyleBackColor = false;
            btDeleteMember.Click += btDeleteMember_Click;
            // 
            // tbMemberCity
            // 
            tbMemberCity.Location = new System.Drawing.Point(446, 100);
            tbMemberCity.Margin = new Padding(3, 4, 3, 4);
            tbMemberCity.Name = "tbMemberCity";
            tbMemberCity.Size = new System.Drawing.Size(173, 27);
            tbMemberCity.TabIndex = 10;
            // 
            // tbMemberEmail
            // 
            tbMemberEmail.Location = new System.Drawing.Point(91, 100);
            tbMemberEmail.Margin = new Padding(3, 4, 3, 4);
            tbMemberEmail.Name = "tbMemberEmail";
            tbMemberEmail.Size = new System.Drawing.Size(173, 27);
            tbMemberEmail.TabIndex = 9;
            // 
            // tbMemberName
            // 
            tbMemberName.Location = new System.Drawing.Point(447, 15);
            tbMemberName.Margin = new Padding(3, 4, 3, 4);
            tbMemberName.Name = "tbMemberName";
            tbMemberName.Size = new System.Drawing.Size(172, 27);
            tbMemberName.TabIndex = 8;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btnLoad.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLoad.Location = new System.Drawing.Point(271, 158);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 30);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btNewMember
            // 
            btNewMember.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btNewMember.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btNewMember.Location = new System.Drawing.Point(62, 160);
            btNewMember.Margin = new Padding(3, 4, 3, 4);
            btNewMember.Name = "btNewMember";
            btNewMember.Size = new System.Drawing.Size(94, 30);
            btNewMember.TabIndex = 12;
            btNewMember.Text = "New";
            btNewMember.UseVisualStyleBackColor = false;
            btNewMember.Click += btNewMember_Click;
            // 
            // tbMemberPassword
            // 
            tbMemberPassword.Location = new System.Drawing.Point(91, 58);
            tbMemberPassword.Margin = new Padding(3, 4, 3, 4);
            tbMemberPassword.Name = "tbMemberPassword";
            tbMemberPassword.Size = new System.Drawing.Size(173, 27);
            tbMemberPassword.TabIndex = 7;
            // 
            // tbMemberId
            // 
            tbMemberId.Location = new System.Drawing.Point(91, 15);
            tbMemberId.Margin = new Padding(3, 4, 3, 4);
            tbMemberId.Name = "tbMemberId";
            tbMemberId.Size = new System.Drawing.Size(173, 27);
            tbMemberId.TabIndex = 6;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(305, 61);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(305, 103);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbMemberEmail
            // 
            lbMemberEmail.AutoSize = true;
            lbMemberEmail.Location = new System.Drawing.Point(3, 103);
            lbMemberEmail.Name = "lbMemberEmail";
            lbMemberEmail.Size = new System.Drawing.Size(46, 20);
            lbMemberEmail.TabIndex = 3;
            lbMemberEmail.Text = "Email";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(305, 18);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(109, 20);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(3, 61);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(3, 18);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btFilter);
            panel3.Controls.Add(cbFilterCountry);
            panel3.Controls.Add(cbFilterCity);
            panel3.Controls.Add(lbFIlterCountry);
            panel3.Controls.Add(lbFilterCity);
            panel3.Controls.Add(lbFilter);
            panel3.Location = new System.Drawing.Point(5, 271);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(640, 133);
            panel3.TabIndex = 2;
            // 
            // btFilter
            // 
            btFilter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btFilter.Location = new System.Drawing.Point(232, 67);
            btFilter.Margin = new Padding(3, 4, 3, 4);
            btFilter.Name = "btFilter";
            btFilter.Size = new System.Drawing.Size(182, 37);
            btFilter.TabIndex = 6;
            btFilter.Text = "Filter";
            btFilter.UseVisualStyleBackColor = false;
            btFilter.Click += btFilter_Click;
            // 
            // cbFilterCountry
            // 
            cbFilterCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterCountry.FormattingEnabled = true;
            cbFilterCountry.Location = new System.Drawing.Point(408, 23);
            cbFilterCountry.Margin = new Padding(3, 4, 3, 4);
            cbFilterCountry.Name = "cbFilterCountry";
            cbFilterCountry.Size = new System.Drawing.Size(202, 28);
            cbFilterCountry.TabIndex = 8;
            // 
            // cbFilterCity
            // 
            cbFilterCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterCity.FormattingEnabled = true;
            cbFilterCity.Location = new System.Drawing.Point(91, 23);
            cbFilterCity.Margin = new Padding(3, 4, 3, 4);
            cbFilterCity.Name = "cbFilterCity";
            cbFilterCity.Size = new System.Drawing.Size(202, 28);
            cbFilterCity.TabIndex = 7;
            // 
            // lbFIlterCountry
            // 
            lbFIlterCountry.AutoSize = true;
            lbFIlterCountry.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbFIlterCountry.Location = new System.Drawing.Point(314, 26);
            lbFIlterCountry.Name = "lbFIlterCountry";
            lbFIlterCountry.Size = new System.Drawing.Size(67, 23);
            lbFIlterCountry.TabIndex = 6;
            lbFIlterCountry.Text = "Country";
            // 
            // lbFilterCity
            // 
            lbFilterCity.AutoSize = true;
            lbFilterCity.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbFilterCity.Location = new System.Drawing.Point(35, 22);
            lbFilterCity.Name = "lbFilterCity";
            lbFilterCity.Size = new System.Drawing.Size(38, 23);
            lbFilterCity.TabIndex = 6;
            lbFilterCity.Text = "City";
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbFilter.Location = new System.Drawing.Point(6, -4);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new System.Drawing.Size(50, 23);
            lbFilter.TabIndex = 1;
            lbFilter.Text = "Filter";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btSearch);
            panel2.Controls.Add(tbSearchName);
            panel2.Controls.Add(chbSort);
            panel2.Controls.Add(tbSearchId);
            panel2.Controls.Add(lbSearch);
            panel2.Controls.Add(lbSearchName);
            panel2.Controls.Add(lbSearchId);
            panel2.Location = new System.Drawing.Point(5, 400);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(640, 129);
            panel2.TabIndex = 1;
            // 
            // btSearch
            // 
            btSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            btSearch.Location = new System.Drawing.Point(232, 85);
            btSearch.Margin = new Padding(3, 4, 3, 4);
            btSearch.Name = "btSearch";
            btSearch.Size = new System.Drawing.Size(201, 36);
            btSearch.TabIndex = 5;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // tbSearchName
            // 
            tbSearchName.Location = new System.Drawing.Point(408, 23);
            tbSearchName.Margin = new Padding(3, 4, 3, 4);
            tbSearchName.Name = "tbSearchName";
            tbSearchName.Size = new System.Drawing.Size(196, 27);
            tbSearchName.TabIndex = 4;
            // 
            // chbSort
            // 
            chbSort.AutoSize = true;
            chbSort.Location = new System.Drawing.Point(35, 55);
            chbSort.Margin = new Padding(3, 4, 3, 4);
            chbSort.Name = "chbSort";
            chbSort.Size = new System.Drawing.Size(204, 24);
            chbSort.TabIndex = 4;
            chbSort.Text = "Sort By Descending Name";
            chbSort.UseVisualStyleBackColor = true;
            chbSort.CheckedChanged += chbSort_CheckedChanged;
            chbSort.CheckStateChanged += chbSort_CheckStateChanged;
            // 
            // tbSearchId
            // 
            tbSearchId.Location = new System.Drawing.Point(145, 23);
            tbSearchId.Margin = new Padding(3, 4, 3, 4);
            tbSearchId.Name = "tbSearchId";
            tbSearchId.Size = new System.Drawing.Size(136, 27);
            tbSearchId.TabIndex = 3;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbSearch.Location = new System.Drawing.Point(3, -4);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(62, 23);
            lbSearch.TabIndex = 0;
            lbSearch.Text = "Search";
            // 
            // lbSearchName
            // 
            lbSearchName.AutoSize = true;
            lbSearchName.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbSearchName.Location = new System.Drawing.Point(328, 27);
            lbSearchName.Name = "lbSearchName";
            lbSearchName.Size = new System.Drawing.Size(53, 23);
            lbSearchName.TabIndex = 2;
            lbSearchName.Text = "Name";
            // 
            // lbSearchId
            // 
            lbSearchId.AutoSize = true;
            lbSearchId.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbSearchId.Location = new System.Drawing.Point(35, 24);
            lbSearchId.Name = "lbSearchId";
            lbSearchId.Size = new System.Drawing.Size(90, 23);
            lbSearchId.TabIndex = 1;
            lbSearchId.Text = "Member ID";
            // 
            // btClose
            // 
            btClose.BackColor = System.Drawing.Color.Transparent;
            btClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btClose.Location = new System.Drawing.Point(584, 537);
            btClose.Margin = new Padding(3, 4, 3, 4);
            btClose.Name = "btClose";
            btClose.Size = new System.Drawing.Size(146, 32);
            btClose.TabIndex = 9;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // grMemberList
            // 
            grMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grMemberList.Location = new System.Drawing.Point(651, 91);
            grMemberList.Margin = new Padding(3, 4, 3, 4);
            grMemberList.Name = "grMemberList";
            grMemberList.RowHeadersWidth = 62;
            grMemberList.RowTemplate.Height = 25;
            grMemberList.Size = new System.Drawing.Size(731, 438);
            grMemberList.TabIndex = 3;
            grMemberList.CellContentClick += grMemberList_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 19.8000011F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(525, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(368, 39);
            label1.TabIndex = 15;
            label1.Text = "Member Management";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1394, 573);
            Controls.Add(btClose);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(grMemberList);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMemberCountry;
        private System.Windows.Forms.TextBox tbMemberCity;
        private System.Windows.Forms.TextBox tbMemberEmail;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.TextBox tbMemberPassword;
        private System.Windows.Forms.TextBox tbMemberId;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbMemberEmail;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberID;
        public System.Windows.Forms.Button btDeleteMember;
        public System.Windows.Forms.Button btNewMember;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSearchName;
        private System.Windows.Forms.Label lbSearchId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchId;
        private System.Windows.Forms.ComboBox cbFilterCountry;
        private System.Windows.Forms.ComboBox cbFilterCity;
        private System.Windows.Forms.Label lbFIlterCountry;
        private System.Windows.Forms.Label lbFilterCity;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.DataGridView grMemberList;
        private System.Windows.Forms.CheckBox chbSort;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public Button btnLoad;
    }

    
}