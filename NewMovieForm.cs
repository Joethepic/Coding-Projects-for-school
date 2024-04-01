using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MovieListingApp
{
    public partial class NewMovieForm : Form
    {
        public NewMovieForm()
        {
            InitializeComponent();
        }

        private void AddMovie()
        {
            // This allows you to add to add movie to the movie list
            //try
            //{
                string filename = ("movies.txt");
                var inputFile = new StreamWriter(filename);
                inputFile = File.AppendText(filename);
                string title = titleTB.Text;
                string genre = genreTB.Text;
                string year = yearTB.Text;
                string duration = durationTB.Text;
                string description = descriptionTB.Text;
                string rating = ratingTB.Text;
                inputFile.WriteLine(title + "," + genre + "," + year + "," + duration + "," + description + "," + rating);
            //}
            /*catch (Exception)
            {
                MessageBox.Show("An error has occured");
            }*/
            }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddMovie();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
