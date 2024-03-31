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
        
            private void Add Movie() 
            {
            StreamWriter inputFile;
            inputFile = File.CreateText("movies.txt");
            string title = titleTB.Text;
            inputFile = File.AppendText(title + ",");
            inputFile.Close();
            string genre = genreTB.Text;
            inputFile = File.AppendText(genre);
            inputFile.Close();
            string year = yearTB.Text;
            inputFile = File.AppendText(year);
            string duration = durationTB.Text;
            inputFile = File.AppendText(duration);
            string description = descriptionTB.Text;
            inputFile = File.AppendText(description);
            }

    }
}
