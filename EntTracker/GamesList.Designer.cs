using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace EntTracker
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
            this.findButton = new System.Windows.Forms.Button();
            this.gamesDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenresColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(32, 563);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 45);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // videosButton
            // 
            this.videosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videosButton.Location = new System.Drawing.Point(548, 563);
            this.videosButton.Margin = new System.Windows.Forms.Padding(4);
            this.videosButton.Name = "videosButton";
            this.videosButton.Size = new System.Drawing.Size(99, 45);
            this.videosButton.TabIndex = 6;
            this.videosButton.Text = "Videos";
            this.videosButton.UseVisualStyleBackColor = true;
            this.videosButton.Click += new System.EventHandler(this.videosButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.Location = new System.Drawing.Point(655, 563);
            this.booksButton.Margin = new System.Windows.Forms.Padding(4);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(94, 45);
            this.booksButton.TabIndex = 7;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicButton.Location = new System.Drawing.Point(757, 563);
            this.musicButton.Margin = new System.Windows.Forms.Padding(4);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(94, 45);
            this.musicButton.TabIndex = 8;
            this.musicButton.Text = "Music";
            this.musicButton.UseVisualStyleBackColor = true;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(134, 563);
            this.findButton.Margin = new System.Windows.Forms.Padding(4);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(94, 45);
            this.findButton.TabIndex = 11;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // gamesDataGridView
            // 
            this.gamesDataGridView.AllowUserToAddRows = false;
            this.gamesDataGridView.AllowUserToDeleteRows = false;
            this.gamesDataGridView.AllowUserToOrderColumns = true;
            this.gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.RatingColumn,
            this.StatusColumn,
            this.GenresColumn,
            this.ReviewColumn});
            this.gamesDataGridView.Location = new System.Drawing.Point(32, 13);
            this.gamesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.gamesDataGridView.Name = "gamesDataGridView";
            this.gamesDataGridView.ReadOnly = true;
            this.gamesDataGridView.RowTemplate.Height = 24;
            this.gamesDataGridView.Size = new System.Drawing.Size(819, 542);
            this.gamesDataGridView.TabIndex = 12;
            this.gamesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gamesDataGridView_CellContentClick);
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Width = 200;
            // 
            // RatingColumn
            // 
            this.RatingColumn.HeaderText = "Rating";
            this.RatingColumn.Name = "RatingColumn";
            this.RatingColumn.ReadOnly = true;
            this.RatingColumn.Width = 75;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Width = 125;
            // 
            // GenresColumn
            // 
            this.GenresColumn.HeaderText = "Genres";
            this.GenresColumn.Name = "GenresColumn";
            this.GenresColumn.ReadOnly = true;
            this.GenresColumn.Width = 200;
            // 
            // ReviewColumn
            // 
            this.ReviewColumn.HeaderText = "Review";
            this.ReviewColumn.Name = "ReviewColumn";
            this.ReviewColumn.ReadOnly = true;
            this.ReviewColumn.Width = 175;
            // 
            // GamesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 618);
            this.Controls.Add(this.gamesDataGridView);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.videosButton);
            this.Controls.Add(this.addButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GamesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games List";
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button videosButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridView gamesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenresColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewColumn;
    }
}