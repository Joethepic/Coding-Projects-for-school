using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieListingApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewMovieForm newMovieForm = new NewMovieForm();
            newMovieForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MovieListForm movieListForm = new MovieListForm();
            movieListForm.Show();
        }

        private void newuserButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
