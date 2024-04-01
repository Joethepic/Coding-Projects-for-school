using System.Windows.Forms;

namespace MovieListingApp
{
    partial class RegistrationForm
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
            exitButton = new Button();
            registerButton = new Button();
            resetButton = new Button();
            loginButton = new Button();
            passwordTB = new TextBox();
            usernameTB = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            registerLabel = new Label();
            firstnameLabel = new Label();
            lastnameLabel = new Label();
            emailLabel = new Label();
            lastnameTB = new TextBox();
            emailTB = new TextBox();
            firstnameTB = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(661, 390);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 16;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(254, 341);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 15;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(394, 341);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 14;
            resetButton.Text = "Reset Form";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(661, 301);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 13;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(304, 268);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(115, 23);
            passwordTB.TabIndex = 12;
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(304, 208);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(100, 23);
            usernameTB.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(233, 276);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(233, 208);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(63, 15);
            usernameLabel.TabIndex = 9;
            usernameLabel.Text = "Username:";
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 16F);
            registerLabel.Location = new Point(167, 60);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(410, 30);
            registerLabel.TabIndex = 17;
            registerLabel.Text = "Register for the Movie Listing Application";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(229, 107);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(64, 15);
            firstnameLabel.TabIndex = 18;
            firstnameLabel.Text = "First Name";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(457, 107);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(63, 15);
            lastnameLabel.TabIndex = 19;
            lastnameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(254, 171);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 20;
            emailLabel.Text = "Email:";
            // 
            // lastnameTB
            // 
            lastnameTB.Location = new Point(457, 125);
            lastnameTB.Name = "lastnameTB";
            lastnameTB.Size = new Size(100, 23);
            lastnameTB.TabIndex = 21;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(299, 163);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(100, 23);
            emailTB.TabIndex = 22;
            // 
            // firstnameTB
            // 
            firstnameTB.Location = new Point(229, 125);
            firstnameTB.Name = "firstnameTB";
            firstnameTB.Size = new Size(100, 23);
            firstnameTB.TabIndex = 23;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(firstnameTB);
            Controls.Add(emailTB);
            Controls.Add(lastnameTB);
            Controls.Add(emailLabel);
            Controls.Add(lastnameLabel);
            Controls.Add(firstnameLabel);
            Controls.Add(registerLabel);
            Controls.Add(exitButton);
            Controls.Add(registerButton);
            Controls.Add(resetButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button registerButton;
        private Button resetButton;
        private Button loginButton;
        private TextBox passwordTB;
        private TextBox usernameTB;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label registerLabel;
        private Label firstnameLabel;
        private Label lastnameLabel;
        private Label emailLabel;
        private TextBox lastnameTB;
        private TextBox emailTB;
        private TextBox firstnameTB;
        private SaveFileDialog saveFileDialog1;
    }
}