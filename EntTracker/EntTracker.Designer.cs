namespace EntTracker
{
    partial class EntTracker
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
            this.gamesButton = new System.Windows.Forms.Button();
            this.videosButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gamesButton
            // 
            this.gamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesButton.Location = new System.Drawing.Point(35, 47);
            this.gamesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gamesButton.Name = "gamesButton";
            this.gamesButton.Size = new System.Drawing.Size(112, 43);
            this.gamesButton.TabIndex = 0;
            this.gamesButton.Text = "Games";
            this.gamesButton.UseVisualStyleBackColor = true;
            this.gamesButton.Click += new System.EventHandler(this.gamesButton_Click);
            // 
            // videosButton
            // 
            this.videosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videosButton.Location = new System.Drawing.Point(244, 47);
            this.videosButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videosButton.Name = "videosButton";
            this.videosButton.Size = new System.Drawing.Size(112, 43);
            this.videosButton.TabIndex = 1;
            this.videosButton.Text = "Videos";
            this.videosButton.UseVisualStyleBackColor = true;
            this.videosButton.Click += new System.EventHandler(this.videosButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.Location = new System.Drawing.Point(35, 129);
            this.booksButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(112, 41);
            this.booksButton.TabIndex = 2;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicButton.Location = new System.Drawing.Point(244, 129);
            this.musicButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(112, 41);
            this.musicButton.TabIndex = 3;
            this.musicButton.Text = "Music";
            this.musicButton.UseVisualStyleBackColor = true;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // EntTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 206);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.videosButton);
            this.Controls.Add(this.gamesButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EntTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ent Tracker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gamesButton;
        private System.Windows.Forms.Button videosButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button musicButton;
    }
}

