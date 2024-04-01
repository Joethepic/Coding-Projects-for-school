namespace MovieListingApp
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
            loginLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            loginButton = new Button();
            ResetButton = new Button();
            registerButton = new Button();
            exitButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 16F);
            loginLabel.Location = new Point(223, 72);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(377, 30);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Login to the Movie Listing Application";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(223, 140);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(63, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(223, 208);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(294, 140);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(100, 23);
            usernameTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(294, 200);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(100, 23);
            passwordTB.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(256, 336);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(404, 336);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 23);
            ResetButton.TabIndex = 6;
            ResetButton.Text = "Reset Form";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(671, 290);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(671, 385);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(registerButton);
            Controls.Add(ResetButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(loginLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label loginLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button loginButton;
        private Button ResetButton;
        private Button registerButton;
        private Button exitButton;
        private OpenFileDialog openFileDialog1;
    }
}
