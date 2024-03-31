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
            StreamWriter outputFile;
            outputFile = File.CreateText("movies.txt");
            outputFile = File.AppendText("movies.txt");
            outputFile.WriteLine(movieListBox);
        }
        private void MovieListForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string movie = movieListBox.SelectedItem.ToString();
            switch (movie)
            {

                case "Bad Boys for Life":
                    titleTB.Text = "Bad Boys for Life";
                    break;
                case "Click":
                    titleTB.Text = "Click";
                    break;
                case "Despicable Me":
                    titleTB.Text = "Despicable Me";
                    break;
                case "Inception":
                    titleTB.Text = "Inception";
                    break;
                case "The Matrix":
                    titleTB.Text = "The Matrix";
                    break;
            }
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
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            FavoritesForm favoritesForm = new FavoritesForm();
            favoritesForm.Show();
        }
    }
}