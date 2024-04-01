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
    public partial class MovieListForm : Form
    {
        public MovieListForm()
        {
            InitializeComponent();
        }
        private void LoadMovies()
        {
            StreamReader outputFile;
            outputFile = File.OpenText("movies.txt");
            string movies = outputFile.ReadToEnd();
            string movie = outputFile.ReadLine();
            movieListBox.Items.Add(movies);
        }
        private void MovieListForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void rateButton_Click(object sender, EventArgs e)
        {
            ReviewForm reviewForm = new ReviewForm();
            reviewForm.Show();

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewMovieForm newMovieForm = new NewMovieForm();
            newMovieForm.Show();
            this.Close();
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            FavoritesForm favoritesForm = new FavoritesForm();
            favoritesForm.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}