using System.Drawing;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            btnSave = new Button();
            btnCancel = new Button();
            lbMemberID = new Label();
            lbPassword = new Label();
            lbMemberEmail = new Label();
            lbCity = new Label();
            lbMemberName = new Label();
            lbCountry = new Label();
            tbMemberCountry = new TextBox();
            tbMemberCity = new TextBox();
            tbMemberEmail = new TextBox();
            tbMemberName = new TextBox();
            tbMemberPassword = new TextBox();
            tbMemberId = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(123, 297);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(300, 297);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(50, 35);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 13;
            lbMemberID.Text = "Member ID";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(50, 71);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 14;
            lbPassword.Text = "Password";
            // 
            // lbMemberEmail
            // 
            lbMemberEmail.AutoSize = true;
            lbMemberEmail.Location = new Point(50, 108);
            lbMemberEmail.Name = "lbMemberEmail";
            lbMemberEmail.Size = new Size(46, 20);
            lbMemberEmail.TabIndex = 15;
            lbMemberEmail.Text = "Email";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(50, 142);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 16;
            lbCity.Text = "City";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(50, 181);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 17;
            lbMemberName.Text = "Member Name";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(50, 222);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 18;
            lbCountry.Text = "Country";
            // 
            // tbMemberCountry
            // 
            tbMemberCountry.Location = new Point(217, 222);
            tbMemberCountry.Margin = new Padding(3, 4, 3, 4);
            tbMemberCountry.Name = "tbMemberCountry";
            tbMemberCountry.Size = new Size(262, 27);
            tbMemberCountry.TabIndex = 5;
            // 
            // tbMemberCity
            // 
            tbMemberCity.Location = new Point(217, 142);
            tbMemberCity.Margin = new Padding(3, 4, 3, 4);
            tbMemberCity.Name = "tbMemberCity";
            tbMemberCity.Size = new Size(263, 27);
            tbMemberCity.TabIndex = 3;
            // 
            // tbMemberEmail
            // 
            tbMemberEmail.Location = new Point(217, 103);
            tbMemberEmail.Margin = new Padding(3, 4, 3, 4);
            tbMemberEmail.Name = "tbMemberEmail";
            tbMemberEmail.Size = new Size(263, 27);
            tbMemberEmail.TabIndex = 2;
            // 
            // tbMemberName
            // 
            tbMemberName.Location = new Point(217, 181);
            tbMemberName.Margin = new Padding(3, 4, 3, 4);
            tbMemberName.Name = "tbMemberName";
            tbMemberName.Size = new Size(262, 27);
            tbMemberName.TabIndex = 4;
            // 
            // tbMemberPassword
            // 
            tbMemberPassword.Location = new Point(217, 64);
            tbMemberPassword.Margin = new Padding(3, 4, 3, 4);
            tbMemberPassword.Name = "tbMemberPassword";
            tbMemberPassword.Size = new Size(263, 27);
            tbMemberPassword.TabIndex = 1;
            // 
            // tbMemberId
            // 
            tbMemberId.Location = new Point(217, 28);
            tbMemberId.Margin = new Padding(3, 4, 3, 4);
            tbMemberId.Name = "tbMemberId";
            tbMemberId.Size = new Size(263, 27);
            tbMemberId.TabIndex = 0;
            // 
            // frmCarDetails
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 354);
            Controls.Add(tbMemberCountry);
            Controls.Add(tbMemberCity);
            Controls.Add(tbMemberEmail);
            Controls.Add(tbMemberName);
            Controls.Add(tbMemberPassword);
            Controls.Add(tbMemberId);
            Controls.Add(lbCountry);
            Controls.Add(lbMemberName);
            Controls.Add(lbCity);
            Controls.Add(lbMemberEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbMemberID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Margin = new Padding(2);
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Button btnCancel;
        private Label lbMemberID;
        private Label lbPassword;
        private Label lbMemberEmail;
        private Label lbCity;
        private Label lbMemberName;
        private Label lbCountry;
        private TextBox tbMemberCountry;
        private TextBox tbMemberCity;
        private TextBox tbMemberEmail;
        private TextBox tbMemberName;
        private TextBox tbMemberPassword;
        private TextBox tbMemberId;
    }
}