namespace MovieListingApp
{
    partial class FavoritesForm
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
            favoriteListBox = new ListBox();
            descriptionLabel = new Label();
            durationTB = new TextBox();
            yearTB = new TextBox();
            ratingTB = new TextBox();
            descriptionTB = new TextBox();
            genreTB = new TextBox();
            titleTB = new TextBox();
            ratingLabel = new Label();
            durationLabel = new Label();
            yearLabel = new Label();
            genreLabel = new Label();
            titleLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // favoriteListBox
            // 
            favoriteListBox.FormattingEnabled = true;
            favoriteListBox.ItemHeight = 15;
            favoriteListBox.Location = new Point(46, 81);
            favoriteListBox.Name = "favoriteListBox";
            favoriteListBox.Size = new Size(120, 229);
            favoriteListBox.TabIndex = 0;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(231, 237);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 35;
            descriptionLabel.Text = "Description:";
            // 
            // durationTB
            // 
            durationTB.Location = new Point(440, 185);
            durationTB.Name = "durationTB";
            durationTB.ReadOnly = true;
            durationTB.Size = new Size(65, 23);
            durationTB.TabIndex = 34;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(334, 185);
            yearTB.Name = "yearTB";
            yearTB.ReadOnly = true;
            yearTB.Size = new Size(62, 23);
            yearTB.TabIndex = 33;
            // 
            // ratingTB
            // 
            ratingTB.Location = new Point(231, 339);
            ratingTB.Name = "ratingTB";
            ratingTB.ReadOnly = true;
            ratingTB.Size = new Size(45, 23);
            ratingTB.TabIndex = 32;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(231, 255);
            descriptionTB.Multiline = true;
            descriptionTB.Name = "descriptionTB";
            descriptionTB.ReadOnly = true;
            descriptionTB.Size = new Size(309, 61);
            descriptionTB.TabIndex = 31;
            // 
            // genreTB
            // 
            genreTB.Location = new Point(228, 185);
            genreTB.Name = "genreTB";
            genreTB.ReadOnly = true;
            genreTB.Size = new Size(48, 23);
            genreTB.TabIndex = 30;
            // 
            // titleTB
            // 
            titleTB.Location = new Point(231, 52);
            titleTB.Name = "titleTB";
            titleTB.ReadOnly = true;
            titleTB.Size = new Size(285, 23);
            titleTB.TabIndex = 29;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new Point(222, 319);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(44, 15);
            ratingLabel.TabIndex = 28;
            ratingLabel.Text = "Rating:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(439, 167);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(56, 15);
            durationLabel.TabIndex = 27;
            durationLabel.Text = "Duration:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(334, 167);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 26;
            yearLabel.Text = "Year:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(228, 167);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(41, 15);
            genreLabel.TabIndex = 25;
            genreLabel.Text = "Genre:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(228, 34);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(68, 15);
            titleLabel.TabIndex = 24;
            titleLabel.Text = "Movie Title:";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(390, 339);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 36;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // FavoritesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
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
            Controls.Add(titleLabel);
            Controls.Add(favoriteListBox);
            Name = "FavoritesForm";
            Text = "My Movie Favorites";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox favoriteListBox;
        private Label descriptionLabel;
        private TextBox durationTB;
        private TextBox yearTB;
        private TextBox ratingTB;
        private TextBox descriptionTB;
        private TextBox genreTB;
        private TextBox titleTB;
        private Label ratingLabel;
        private Label durationLabel;
        private Label yearLabel;
        private Label genreLabel;
        private Label titleLabel;
        private Button exitButton;
    }
}