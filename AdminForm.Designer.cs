namespace MovieListingApp
{
    partial class AdminForm
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
            newButton = new Button();
            updateButton = new Button();
            viewButton = new Button();
            newuserButton = new Button();
            SuspendLayout();
            // 
            // newButton
            // 
            newButton.Location = new Point(139, 48);
            newButton.Name = "newButton";
            newButton.Size = new Size(166, 55);
            newButton.TabIndex = 0;
            newButton.Text = "Add a New Movie";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(139, 142);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(166, 54);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update/Edit Existing Movie";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(139, 222);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(166, 57);
            viewButton.TabIndex = 4;
            viewButton.Text = "View All Movies and Users";
            viewButton.UseVisualStyleBackColor = true;
            // 
            // newuserButton
            // 
            newuserButton.Location = new Point(139, 328);
            newuserButton.Name = "newuserButton";
            newuserButton.Size = new Size(166, 49);
            newuserButton.TabIndex = 6;
            newuserButton.Text = "Add a New User Account";
            newuserButton.UseVisualStyleBackColor = true;
            newuserButton.Click += newuserButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 450);
            Controls.Add(newuserButton);
            Controls.Add(viewButton);
            Controls.Add(updateButton);
            Controls.Add(newButton);
            Name = "AdminForm";
            Text = "Administrator View";
            ResumeLayout(false);
        }

        #endregion

        private Button newButton;
        private Button updateButton;
        private Button viewButton;
        private Button newuserButton;
    }
}