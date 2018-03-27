﻿namespace EntTracker
{
    partial class GamesList
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
            this.addButton = new System.Windows.Forms.Button();
            this.videosButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.gamesDataGridView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(26, 470);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 33);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // videosButton
            // 
            this.videosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videosButton.Location = new System.Drawing.Point(428, 470);
            this.videosButton.Name = "videosButton";
            this.videosButton.Size = new System.Drawing.Size(79, 33);
            this.videosButton.TabIndex = 6;
            this.videosButton.Text = "Videos";
            this.videosButton.UseVisualStyleBackColor = true;
            this.videosButton.Click += new System.EventHandler(this.videosButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.Location = new System.Drawing.Point(513, 470);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(75, 33);
            this.booksButton.TabIndex = 7;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicButton.Location = new System.Drawing.Point(594, 470);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(75, 33);
            this.musicButton.TabIndex = 8;
            this.musicButton.Text = "Music";
            this.musicButton.UseVisualStyleBackColor = true;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // sortComboBox
            // 
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Sort by Name",
            "Sort by Rating"});
            this.sortComboBox.Location = new System.Drawing.Point(26, 34);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(156, 30);
            this.sortComboBox.TabIndex = 9;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "All",
            "Playing",
            "Plan to Play",
            "On Hold",
            "Dropped"});
            this.statusComboBox.Location = new System.Drawing.Point(209, 34);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(140, 30);
            this.statusComboBox.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(107, 470);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 33);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // gamesDataGridView
            // 
            this.gamesDataGridView.AllowUserToAddRows = false;
            this.gamesDataGridView.AllowUserToDeleteRows = false;
            this.gamesDataGridView.AllowUserToOrderColumns = true;
            this.gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Rating,
            this.Status,
            this.Genres});
            this.gamesDataGridView.Location = new System.Drawing.Point(26, 70);
            this.gamesDataGridView.Name = "gamesDataGridView";
            this.gamesDataGridView.ReadOnly = true;
            this.gamesDataGridView.RowTemplate.Height = 24;
            this.gamesDataGridView.Size = new System.Drawing.Size(643, 394);
            this.gamesDataGridView.TabIndex = 12;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Title.Width = 200;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 55;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Genres
            // 
            this.Genres.HeaderText = "Genres";
            this.Genres.Name = "Genres";
            this.Genres.ReadOnly = true;
            this.Genres.Width = 245;


            //Add games to List
            this.gamesDataGridView.Rows.Add("Batman", "9/10", "Completed", "Action, Fighting");
            this.gamesDataGridView.Rows.Add("Baseball", "8/10", "Completed", "Sports");


            // 
            // GamesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 529);
            this.Controls.Add(this.gamesDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.videosButton);
            this.Controls.Add(this.addButton);
            this.Name = "GamesList";
            this.Text = "Games List";
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button videosButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView gamesDataGridView;
        private System.Windows.Forms.DataGridViewLinkColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genres;
    }
}