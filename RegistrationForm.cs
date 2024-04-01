using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieListingApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Application.Exit();
        }
        public void RegisterUserUN()
        {
                string username = usernameTB.Text;
                string filename = saveFileDialog1.FileName;
                StreamWriter outputFile;
                outputFile = File.CreateText("username.txt");
                outputFile.WriteLine(username);
                outputFile.Close();
        }
        private void RegisterUserPW()
        {
                string password = passwordTB.Text;
                string filename = saveFileDialog1.FileName;
                StreamWriter outputFile;
                outputFile = File.AppendText("password.txt");
                outputFile.WriteLine(password);
                outputFile.Close();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            firstnameTB.Text = "";
            lastnameTB.Text = "";
            emailTB.Text = "";
            usernameTB.Text = "";
            passwordTB.Text = "";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUserUN();
            RegisterUserPW();
        }
    }
}
