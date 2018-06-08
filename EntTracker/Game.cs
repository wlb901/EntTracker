using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//This form shows everything about a game, including the picture.
//Has a back button to return to GamesList, an Edit button to edit the game, and a Delete button the delete the game.
//Delete button should ask "are you sure?"

namespace EntTracker
{
    public partial class Game : Form
    {
        
        
        public Game()
        {
            InitializeComponent();
            //Get and set everything
            string title = GamesList.getTitle();
            string rating = GamesList.getRating();
            string genres = GamesList.getGenres();
            string status = GamesList.getStatus();
            string review = GamesList.getReview();
            string location = GamesList.getLocation();
            
            pictureBox.ImageLocation = location;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            setTitle(title);
            setRating(rating);
            setGenres(genres);
            setStatus(status);
            setReview(review);
        }

        //Delete Button. Removes game from database by matching title. Make sure AddGame form blocks adding games with matching titles.
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Confirm Delete
            var confirmDelete = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);

            //If yes, delete from database then return to GamesList
            if (confirmDelete == DialogResult.Yes)
            {
                string title = titleBox.Text;
                try
                {
                    string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                    MySqlConnection connect = new MySqlConnection(connectionInfo);

                    string mySelectQuery = "use mydb; delete from games where title = '" + title + "';";
                    
                    connect.Open();
                    MySqlCommand myCommand = new MySqlCommand(mySelectQuery, connect);
                    myCommand.ExecuteNonQuery();

                    connect.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Hide();
                GamesList gamesListForm = new GamesList();
                gamesListForm.ShowDialog();

            }
            //If no, do nothing
            else
            {
                //Nothing
            }
        }

        //Back button returns to GamesList
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesList list = new GamesList();
            list.ShowDialog();
        }

        //Edit Button brings up EditGame form. This should also send all data for selected game to the EditGame form
        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            string location = GamesList.getLocation();
            EditGame edit = new EditGame(titleBox.Text, ratingBox.Text, statusBox.Text, genresBox.Text, reviewBox.Text, location);
            edit.ShowDialog();
        }

        //Closes Program when X button clicked
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
