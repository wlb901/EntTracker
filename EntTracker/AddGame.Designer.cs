namespace EntTracker
{
    partial class AddGame
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.reviewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.genresCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.pictureLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(191, 60);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.MaxLength = 100;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(349, 28);
            this.titleTextBox.TabIndex = 0;
            // 
            // reviewRichTextBox
            // 
            this.reviewRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewRichTextBox.Location = new System.Drawing.Point(74, 492);
            this.reviewRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reviewRichTextBox.MaxLength = 65535;
            this.reviewRichTextBox.Name = "reviewRichTextBox";
            this.reviewRichTextBox.Size = new System.Drawing.Size(466, 308);
            this.reviewRichTextBox.TabIndex = 8;
            this.reviewRichTextBox.Text = "";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(160, 829);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(104, 47);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(361, 829);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 47);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(69, 60);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(45, 24);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(69, 120);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(63, 24);
            this.ratingLabel.TabIndex = 12;
            this.ratingLabel.Text = "Rating";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(69, 184);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(72, 24);
            this.genreLabel.TabIndex = 13;
            this.genreLabel.Text = "Genres";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "-",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.ratingComboBox.Location = new System.Drawing.Point(191, 120);
            this.ratingComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(85, 30);
            this.ratingComboBox.TabIndex = 14;
            // 
            // genresCheckedListBox
            // 
            this.genresCheckedListBox.CheckOnClick = true;
            this.genresCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genresCheckedListBox.FormattingEnabled = true;
            this.genresCheckedListBox.Items.AddRange(new object[] {
            "4X",
            "Action",
            "Adventure",
            "Casual",
            "Educational",
            "Fantasy",
            "Fighting",
            "Horror",
            "Indie",
            "Logic",
            "MMO",
            "MOBA",
            "Platformer",
            "Puzzle",
            "Racing",
            "Rhythm",
            "RPG",
            "RTS",
            "Sandbox",
            "Shooter",
            "Simulation",
            "Sports",
            "Stealth",
            "Strategy",
            "Survival",
            "Trivia",
            "Turn-Based"});
            this.genresCheckedListBox.Location = new System.Drawing.Point(191, 184);
            this.genresCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.genresCheckedListBox.Name = "genresCheckedListBox";
            this.genresCheckedListBox.Size = new System.Drawing.Size(215, 114);
            this.genresCheckedListBox.TabIndex = 15;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(69, 327);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 24);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Completed",
            "Plan to Play",
            "Playing",
            "On Hold",
            "Dropped"});
            this.statusComboBox.Location = new System.Drawing.Point(191, 327);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(215, 30);
            this.statusComboBox.TabIndex = 17;
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewLabel.Location = new System.Drawing.Point(69, 455);
            this.reviewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(72, 24);
            this.reviewLabel.TabIndex = 18;
            this.reviewLabel.Text = "Review";
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureLabel.Location = new System.Drawing.Point(69, 392);
            this.pictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(68, 24);
            this.pictureLabel.TabIndex = 19;
            this.pictureLabel.Text = "Picture";
            // 
            // pictureLocation
            // 
            this.pictureLocation.BackColor = System.Drawing.SystemColors.Window;
            this.pictureLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureLocation.Location = new System.Drawing.Point(187, 392);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.Size = new System.Drawing.Size(353, 30);
            this.pictureLocation.TabIndex = 20;
            this.pictureLocation.Click += new System.EventHandler(this.pictureLocation_Click);
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 913);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.genresCheckedListBox);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.reviewRichTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RichTextBox reviewRichTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.CheckedListBox genresCheckedListBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Label pictureLocation;
    }
}