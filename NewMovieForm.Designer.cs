namespace MovieListingApp
{
    partial class NewMovieForm
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
            addButton = new Button();
            exitButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(164, 264);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 35;
            descriptionLabel.Text = "Description:";
            // 
            // durationTB
            // 
            durationTB.Location = new Point(228, 195);
            durationTB.Name = "durationTB";
            durationTB.Size = new Size(65, 23);
            durationTB.TabIndex = 34;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(228, 147);
            yearTB.Name = "yearTB";
            yearTB.Size = new Size(62, 23);
            yearTB.TabIndex = 33;
            // 
            // ratingTB
            // 
            ratingTB.Location = new Point(205, 338);
            ratingTB.Name = "ratingTB";
            ratingTB.Size = new Size(45, 23);
            ratingTB.TabIndex = 32;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(237, 246);
            descriptionTB.Multiline = true;
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(309, 61);
            descriptionTB.TabIndex = 31;
            // 
            // genreTB
            // 
            genreTB.Location = new Point(228, 100);
            genreTB.Name = "genreTB";
            genreTB.Size = new Size(48, 23);
            genreTB.TabIndex = 30;
            // 
            // titleTB
            // 
            titleTB.Location = new Point(242, 58);
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(100, 23);
            titleTB.TabIndex = 29;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new Point(155, 346);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(44, 15);
            ratingLabel.TabIndex = 28;
            ratingLabel.Text = "Rating:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(164, 195);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(56, 15);
            durationLabel.TabIndex = 27;
            durationLabel.Text = "Duration:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(177, 147);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(32, 15);
            yearLabel.TabIndex = 26;
            yearLabel.Text = "Year:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(168, 103);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(41, 15);
            genreLabel.TabIndex = 25;
            genreLabel.Text = "Genre:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(161, 61);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(68, 15);
            titleLabel.TabIndex = 24;
            titleLabel.Text = "Movie Title:";
            // 
            // addButton
            // 
            addButton.Location = new Point(327, 345);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 36;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(449, 346);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 37;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // NewMovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(addButton);
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
            Name = "NewMovieForm";
            Text = "Add New Movie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button addButton;
        private Button exitButton;
        private SaveFileDialog saveFileDialog1;
    }
}