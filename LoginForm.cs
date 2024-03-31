using System.Windows.Forms;

namespace MovieListingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFileun;
                inputFileun = File.OpenText("users.txt");
                StreamReader inputFilepw;
                inputFilepw = File.OpenText("passw.txt");
                string usernameTextB = usernameTB.Text;
                string passwordTextB = passwordTB.Text;
                if (usernameTB == inputFileun) 
                { 
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Either your username or password was entered incorrectly; please try again.");
            }
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
        }

    }
}
