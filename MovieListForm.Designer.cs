namespace MovieListingApp
{
    partial class MovieListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            movieListBox = new ListBox();
            titleLabel = new Label();
            genreLabel = new Label();
            yearLabel = new Label();
            durationLabel = new Label();
            ratingLabel = new Label();
            titleTB = new TextBox();
            genreTB = new TextBox();
            searchTB = new TextBox();
            descriptionTB = new TextBox();
            ratingTB = new TextBox();
            yearTB = new TextBox();
            durationTB = new TextBox();
            descriptionLabel = new Label();
            rateButton = new Button();
            addFavButton = new Button();
            newButton = new Button();
            favoriteButton = new Button();
            exitButton = new Button();
            searchButton = new Button();
            searchGroup = new GroupBox();
            filterGroup = new GroupBox();
            yearCheckBox = new CheckBox();
            genreCheckBox = new CheckBox();
            label2 = new Label();
            searchGroup.SuspendLayout();
            filterGroup.SuspendLayout();
            SuspendLayout();
            // 
            // movieListBox
            // 
            movieListBox.FormattingEnabled = true;
            movieListBox.ItemHeight = 15;
            movieListBox.Items.AddRange(new object[] { "Bad Boys for Life", "Click", "Despicable Me", "Inception", "The Matrix" });
            movieListBox.Location = new Point(72, 76);
            movieListBox.Name = "movieListBox";
            movieListBox.Size = new Size(120, 94);
            movieListBox.TabIndex = 0;
            movieListBox.SelectedIndexChanged += movieListBox_SelectedIndexChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(313, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(68, 15);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Movie Title:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(313, 164);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(41, 15);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "Genre:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(419, 164);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 4;
            yearLabel.Text = "Year:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(524, 164);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(56, 15);
            durationLabel.TabIndex = 6;
            durationLabel.Text = "Duration:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new Point(307, 316);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(44, 15);
            ratingLabel.TabIndex = 8;
            ratingLabel.Text = "Rating:";
            // 
            // titleTB
            // 
            titleTB.Location = new Point(316, 49);
            titleTB.Name = "titleTB";
            titleTB.ReadOnly = true;
            titleTB.Size = new Size(100, 23);
            titleTB.TabIndex = 9;
            // 
            // genreTB
            // 
            genreTB.Location = new Point(313, 182);
            genreTB.Name = "genreTB";
            genreTB.ReadOnly = true;
            genreTB.Size = new Size(48, 23);
            genreTB.TabIndex = 10;
            // 
            // searchTB
            // 
            searchTB.Location = new Point(6, 22);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(185, 23);
            searchTB.TabIndex = 11;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(316, 252);
            descriptionTB.Multiline = true;
            descriptionTB.Name = "descriptionTB";
            descriptionTB.ReadOnly = true;
            descriptionTB.Size = new Size(309, 61);
            descriptionTB.TabIndex = 12;
            // 
            // ratingTB
            // 
            ratingTB.Location = new Point(316, 336);
            ratingTB.Name = "ratingTB";
            ratingTB.ReadOnly = true;
            ratingTB.Size = new Size(45, 23);
            ratingTB.TabIndex = 13;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(419, 182);
            yearTB.Name = "yearTB";
            yearTB.ReadOnly = true;
            yearTB.Size = new Size(62, 23);
            yearTB.TabIndex = 14;
            // 
            // durationTB
            // 
            durationTB.Location = new Point(525, 182);
            durationTB.Name = "durationTB";
            durationTB.ReadOnly = true;
            durationTB.Size = new Size(65, 23);
            durationTB.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(316, 234);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 16;
            descriptionLabel.Text = "Description:";
            // 
            // rateButton
            // 
            rateButton.Location = new Point(461, 335);
            rateButton.Name = "rateButton";
            rateButton.Size = new Size(149, 23);
            rateButton.TabIndex = 17;
            rateButton.Text = "Rate This Movie";
            rateButton.UseVisualStyleBackColor = true;
            rateButton.Click += rateButton_Click;
            // 
            // addFavButton
            // 
            addFavButton.Location = new Point(461, 364);
            addFavButton.Name = "addFavButton";
            addFavButton.Size = new Size(149, 23);
            addFavButton.TabIndex = 18;
            addFavButton.Text = "Add to My Favorites";
            addFavButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            newButton.Location = new Point(461, 405);
            newButton.Name = "newButton";
            newButton.Size = new Size(149, 23);
            newButton.TabIndex = 19;
            newButton.Text = "Add a New Movie";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // favoriteButton
            // 
            favoriteButton.Location = new Point(99, 325);
            favoriteButton.Name = "favoriteButton";
            favoriteButton.Size = new Size(127, 23);
            favoriteButton.TabIndex = 20;
            favoriteButton.Text = "View My Favorites";
            favoriteButton.UseVisualStyleBackColor = true;
            favoriteButton.Click += favoriteButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(688, 405);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 21;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(71, 70);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 24);
            searchButton.TabIndex = 22;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // searchGroup
            // 
            searchGroup.Controls.Add(searchTB);
            searchGroup.Controls.Add(searchButton);
            searchGroup.Location = new Point(597, 31);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(200, 100);
            searchGroup.TabIndex = 23;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search for a Movie By Title";
            // 
            // filterGroup
            // 
            filterGroup.Controls.Add(yearCheckBox);
            filterGroup.Controls.Add(genreCheckBox);
            filterGroup.Location = new Point(645, 195);
            filterGroup.Name = "filterGroup";
            filterGroup.Size = new Size(143, 153);
            filterGroup.TabIndex = 24;
            filterGroup.TabStop = false;
            filterGroup.Text = "Filter Movie By";
            // 
            // yearCheckBox
            // 
            yearCheckBox.AutoSize = true;
            yearCheckBox.Location = new Point(12, 81);
            yearCheckBox.Name = "yearCheckBox";
            yearCheckBox.Size = new Size(48, 19);
            yearCheckBox.TabIndex = 1;
            yearCheckBox.Text = "Year";
            yearCheckBox.UseVisualStyleBackColor = true;
            // 
            // genreCheckBox
            // 
            genreCheckBox.AutoSize = true;
            genreCheckBox.Location = new Point(12, 46);
            genreCheckBox.Name = "genreCheckBox";
            genreCheckBox.Size = new Size(57, 19);
            genreCheckBox.TabIndex = 0;
            genreCheckBox.Text = "Genre";
            genreCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            // 
            // MovieListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(filterGroup);
            Controls.Add(searchGroup);
            Controls.Add(exitButton);
            Controls.Add(favoriteButton);
            Controls.Add(newButton);
            Controls.Add(addFavButton);
            Controls.Add(rateButton);
            Controls.Add(descriptionLabel);
            Controls.Add(durationTB);
            Controls.Add(yearTB);
            Controls.Add(ratingTB);
            Controls.Add(descriptionTB);
            Controls.Add(genreTB);
            Controls.Add(titleTB);
            Controls.Add(ratingLabel);
            Controls.Add(durationLabel);
            Controls.Add(yearLabel);
            Controls.Add(genreLabel);
            Controls.Add(label2);
            Controls.Add(titleLabel);
            Controls.Add(movieListBox);
            Name = "MovieListForm";
            Text = "Movie Listing";
            searchGroup.ResumeLayout(false);
            searchGroup.PerformLayout();
            filterGroup.ResumeLayout(false);
            filterGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox movieListBox;
        private Label titleLabel;
        private Label genreLabel;
        private Label yearLabel;
        private Label durationLabel;
        private Label ratingLabel;
        private TextBox titleTB;
        private TextBox genreTB;
        private TextBox searchTB;
        private TextBox descriptionTB;
        private TextBox ratingTB;
        private TextBox yearTB;
        private TextBox durationTB;
        private Label descriptionLabel;
        private Button rateButton;
        private Button addFavButton;
        private Button newButton;
        private Button favoriteButton;
        private Button exitButton;
        private Button searchButton;
        private GroupBox searchGroup;
        private GroupBox filterGroup;
        private CheckBox yearCheckBox;
        private CheckBox genreCheckBox;
        private Label label2;
    }
}