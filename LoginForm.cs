using MovieListingApp;
using System.Drawing.Text;
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
        private void Login()
        {
            try
            {
                StreamReader inputFileun;
                inputFileun = File.OpenText("username.txt");
                string username = inputFileun.ReadToEnd();
                inputFileun.Close();
                StreamReader inputFilepw;
                inputFilepw = File.OpenText("password.txt");
                string password = inputFilepw.ReadToEnd();
                inputFilepw.Close();
                string usernameTextB = usernameTB.Text;
                string passwordTextB = passwordTB.Text;
                if (usernameTextB == username && passwordTextB == password)
                {
                    MovieListForm listForm = new MovieListForm();
                    listForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Either your username or password was entered incorrectly; please try again.");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        public void ResetButton_Click(object sender, EventArgs e)
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
        }

    }
}
