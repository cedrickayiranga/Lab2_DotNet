namespace Lab2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginTxt = new Label();
            Username = new Label();
            Password = new Label();
            btnLogin = new Button();
            txtPassword = new MaskedTextBox();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // loginTxt
            // 
            loginTxt.AutoSize = true;
            loginTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginTxt.Location = new Point(319, 26);
            loginTxt.Name = "loginTxt";
            loginTxt.Size = new Size(63, 25);
            loginTxt.TabIndex = 0;
            loginTxt.Text = "Login";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(191, 74);
            Username.Name = "Username";
            Username.Size = new Size(88, 21);
            Username.TabIndex = 1;
            Username.Text = "Username :";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(191, 134);
            Password.Name = "Password";
            Password.Size = new Size(83, 21);
            Password.TabIndex = 2;
            Password.Text = "Password :";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(319, 198);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(282, 132);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(183, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(282, 72);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(183, 23);
            txtUsername.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(loginTxt);
            Name = "Login";
            Text = "Login";
            FormClosed += Login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginTxt;
        private Label Username;
        private Label Password;
        private Button btnLogin;
        private MaskedTextBox txtPassword;
        private TextBox txtUsername;
    }
}
