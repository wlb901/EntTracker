namespace EntTracker
{
    partial class Game
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.reviewBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.genresBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(13, 13);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 179);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 217);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(13, 264);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(68, 24);
            this.ratingLabel.TabIndex = 2;
            this.ratingLabel.Text = "Rating:";
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genresLabel.Location = new System.Drawing.Point(13, 371);
            this.genresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(77, 24);
            this.genresLabel.TabIndex = 3;
            this.genresLabel.Text = "Genres:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(13, 318);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(65, 24);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status:";
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewLabel.Location = new System.Drawing.Point(13, 413);
            this.reviewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(77, 24);
            this.reviewLabel.TabIndex = 5;
            this.reviewLabel.Text = "Review:";
            // 
            // reviewBox
            // 
            this.reviewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewBox.Location = new System.Drawing.Point(13, 441);
            this.reviewBox.Margin = new System.Windows.Forms.Padding(4);
            this.reviewBox.Multiline = true;
            this.reviewBox.Name = "reviewBox";
            this.reviewBox.ReadOnly = true;
            this.reviewBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reviewBox.Size = new System.Drawing.Size(682, 400);
            this.reviewBox.TabIndex = 6;
            this.reviewBox.TabStop = false;
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(98, 213);
            this.titleBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(572, 28);
            this.titleBox.TabIndex = 7;
            this.titleBox.TabStop = false;
            // 
            // ratingBox
            // 
            this.ratingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingBox.Location = new System.Drawing.Point(98, 264);
            this.ratingBox.Margin = new System.Windows.Forms.Padding(4);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.ReadOnly = true;
            this.ratingBox.Size = new System.Drawing.Size(44, 28);
            this.ratingBox.TabIndex = 8;
            this.ratingBox.TabStop = false;
            // 
            // genresBox
            // 
            this.genresBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genresBox.Location = new System.Drawing.Point(98, 371);
            this.genresBox.Margin = new System.Windows.Forms.Padding(4);
            this.genresBox.Name = "genresBox";
            this.genresBox.ReadOnly = true;
            this.genresBox.Size = new System.Drawing.Size(572, 28);
            this.genresBox.TabIndex = 9;
            this.genresBox.TabStop = false;
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.Location = new System.Drawing.Point(98, 315);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(164, 28);
            this.statusBox.TabIndex = 10;
            this.statusBox.TabStop = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(539, 848);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 45);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(620, 848);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 45);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 848);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 45);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 901);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.genresBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.reviewBox);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.TextBox reviewBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox genresBox;
        private System.Windows.Forms.TextBox statusBox;

        public void setTitle(string title)
        {
            titleBox.Text = title;
        }

        public void setRating(string rating)
        {
            ratingBox.Text = rating;
        }

        public void setGenres(string genres)
        {
            genresBox.Text = genres;
        }

        public void setStatus(string status)
        {
            statusBox.Text = status;
        }

        public void setReview(string review)
        {
            reviewBox.Text = review;
        }

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
    }
}