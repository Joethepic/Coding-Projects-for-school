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
        public void RegisterUserUN(object sender, EventArgs e)
        {
            try 
            {
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid login");
            }
        }
        private void RegisterUserPW(object senderm, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("passw.txt");
                outputFile.WriteLine(passwordTB.Text);
                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid login");
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            firstnameTB.Text = "";
            lastnameTB.Text = "";
            emailTB.Text = "";
            usernameTB.Text = "";
            passwordTB.Text = "";
        }
    }
}
