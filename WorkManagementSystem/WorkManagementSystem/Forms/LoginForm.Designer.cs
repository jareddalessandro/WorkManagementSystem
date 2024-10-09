namespace WorkManagementSystem
{
    partial class LoginForm
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
            usernameLabel = new Label();
            passwordLabel = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtLocationTag = new Label();
            btnLogin = new Button();
            txtLoginError = new Label();
            loginLabel = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 14F);
            usernameLabel.Location = new Point(213, 120);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 14F);
            passwordLabel.Location = new Point(227, 214);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(95, 25);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ScrollBar;
            txtUsername.Location = new Point(385, 125);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ScrollBar;
            txtPassword.Location = new Point(385, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(223, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtLocationTag
            // 
            txtLocationTag.AutoSize = true;
            txtLocationTag.Font = new Font("Segoe UI", 14F);
            txtLocationTag.Location = new Point(12, 416);
            txtLocationTag.Name = "txtLocationTag";
            txtLocationTag.Size = new Size(93, 25);
            txtLocationTag.TabIndex = 4;
            txtLocationTag.Text = "Location: ";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonFace;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(385, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 31);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginError
            // 
            txtLoginError.AutoSize = true;
            txtLoginError.Font = new Font("Segoe UI", 11F);
            txtLoginError.ForeColor = Color.Red;
            txtLoginError.Location = new Point(260, 327);
            txtLoginError.Name = "txtLoginError";
            txtLoginError.Size = new Size(291, 20);
            txtLoginError.TabIndex = 6;
            txtLoginError.Text = "Error: The Username or Password is invalid!";
            txtLoginError.Visible = false;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(410, 37);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(69, 30);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginLabel);
            Controls.Add(txtLoginError);
            Controls.Add(btnLogin);
            Controls.Add(txtLocationTag);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "LoginForm";
            Text = "Scheduling Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label txtLocationTag;
        private Button btnLogin;
        private Label txtLoginError;
        private Label loginLabel;
    }
}
