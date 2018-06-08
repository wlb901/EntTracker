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

/*
 *This is now the main form shown at startup. 
 * It should be a list of all games and show Title, Rating, Status, Genres, and Review
 * Clicking the Title of a game will go to that game's page.
 * Buttons to Add a new game and Search for a game (Find).
 * Each column should be sortable. 
 */
namespace EntTracker
{
    public partial class GamesList : Form
    {
        static string title = "";
        static string rating = "";
        static string status = "";
        static string genres = "";
        static string review = "";
        static string location = "";

        public GamesList()
        {
            InitializeComponent();

            //Add games to List
            try
            {
                string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                MySqlConnection connect = new MySqlConnection(connectionInfo);

                string mySelectQuery = "use mydb; select * from games;";
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, connect);
                connect.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        this.gamesDataGridView.Rows.Add(myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4));
                        location = myReader.GetString(5);
                    }
                }
                finally
                {
                    myReader.Close();
                    connect.Close();
                }

                connect.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        //Add a new game
        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGame addGameForm = new AddGame();
            addGameForm.ShowDialog();
        }

        //Search for a game
        private void findButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindList findGamesList = new FindList();
            findGamesList.ShowDialog();
        }

        //Function for clicking game title. This should set all game strings to contents of cells
        private void gamesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Only clickable on fist Column and at least row 0
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                title = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                rating = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
                status = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
                genres = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value.ToString();
                review = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value.ToString();
                this.Hide();
                Game gameForm = new Game();
                gameForm.ShowDialog();
            };
        }

        //Getters to return all strings
        public static string getTitle()
        {
            return title;
        }
        public static string getRating()
        {
            return rating;
        }
        public static string getStatus()
        {
            return status;
        }
        public static string getGenres()
        {
            return genres;
        }
        public static string getReview()
        {
            return review;
        }
        //Picture location is not in GamesList. Must get it from the database
        public static string getLocation()
        {
            string location = "";
            try
            {
                string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                MySqlConnection connect = new MySqlConnection(connectionInfo);
                
                string mySelectQuery = "use mydb; select * from games where Title = '" + title + "';";
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, connect);
                connect.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        location = myReader.GetString(5);
                    }
                }
                finally
                {
                    myReader.Close();
                    connect.Close();
                }

                connect.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return location;
        }

        //Go to Videos list
        private void videosButton_Click(object sender, EventArgs e)
        {
            //Removed
        }

        //Go to Music list
        private void musicButton_Click(object sender, EventArgs e)
        {
            //Removed
        }

        //Go to books list
        private void booksButton_Click(object sender, EventArgs e)
        {
            //Removed
        }

        //Closes Program when X button clicked
        private void GamesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
