namespace MyStoreWinApp
{
    partial class frmLogin
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
            label1 = new System.Windows.Forms.Label();
            Email = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbEmail = new System.Windows.Forms.TextBox();
            tbPassword = new System.Windows.Forms.TextBox();
            btLogin = new System.Windows.Forms.Button();
            btQuit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(268, 32);
            label1.TabIndex = 0;
            label1.Text = "Member Management";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Email.Location = new System.Drawing.Point(10, 99);
            Email.Name = "Email";
            Email.Size = new System.Drawing.Size(47, 20);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(10, 129);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // tbEmail
            // 
            tbEmail.Location = new System.Drawing.Point(85, 94);
            tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new System.Drawing.Size(219, 27);
            tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(85, 127);
            tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new System.Drawing.Size(219, 27);
            tbPassword.TabIndex = 1;
            // 
            // btLogin
            // 
            btLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            btLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            btLogin.Location = new System.Drawing.Point(60, 175);
            btLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btLogin.Name = "btLogin";
            btLogin.Size = new System.Drawing.Size(83, 36);
            btLogin.TabIndex = 2;
            btLogin.Text = "&Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // btQuit
            // 
            btQuit.BackColor = System.Drawing.Color.WhiteSmoke;
            btQuit.Location = new System.Drawing.Point(190, 175);
            btQuit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btQuit.Name = "btQuit";
            btQuit.Size = new System.Drawing.Size(83, 36);
            btQuit.TabIndex = 3;
            btQuit.Text = "Close";
            btQuit.UseVisualStyleBackColor = false;
            btQuit.Click += btQuit_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(315, 248);
            Controls.Add(btQuit);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(Email);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btQuit;
    }
}