namespace FitnessTracker
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnSignUp = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.FromArgb(50, 50, 50);
            txtUsername.Location = new Point(84, 92);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(225, 30);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.FromArgb(50, 50, 50);
            txtPassword.Location = new Point(84, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(225, 30);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(84, 184);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(225, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.White;
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.FromArgb(0, 123, 255);
            btnSignUp.Location = new Point(84, 230);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(225, 40);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 123, 255);
            lblTitle.Location = new Point(84, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(226, 41);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Fitness Tracker";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 483);
            Controls.Add(lblTitle);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(50, 50, 50);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblTitle;
    }
}