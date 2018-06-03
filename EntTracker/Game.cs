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

namespace EntTracker
{
    public partial class Game : Form
    {
        
        
        public Game()
        {
            InitializeComponent();
            string title = GamesList.getTitle();
            string rating = GamesList.getRating();
            string genres = GamesList.getGenres();
            string status = GamesList.getStatus();
            string review = GamesList.getReview();
            string location = GamesList.getLocation();
            
            location = location.Replace("\\", "\\\\");
            //pictureBox.Image = new Bitmap(location);
            //Console.WriteLine("location: " + location);
            pictureBox.ImageLocation = location;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            setTitle(title);
            setRating(rating);
            setGenres(genres);
            setStatus(status);
            setReview(review);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmDelete == DialogResult.Yes)
            {
                //Console.WriteLine("Deleted");
                string title = titleBox.Text;
                //Console.WriteLine(title + " will be deleted");
                //Remove from database
                try
                {
                    string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                    MySqlConnection connect = new MySqlConnection(connectionInfo);

                    string mySelectQuery = "use mydb; delete from games where title = '" + title + "';";

                    //Console.WriteLine(mySelectQuery);

                    connect.Open();
                    MySqlCommand myCommand = new MySqlCommand(mySelectQuery, connect);
                    myCommand.ExecuteNonQuery();

                    connect.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Close Game.cs Form
                this.Hide();
                GamesList gamesListForm = new GamesList();
                gamesListForm.ShowDialog();

            }
            else
            {
                //Console.WriteLine("Not Deleted");
                this.Hide();
                GamesList gamesListForm = new GamesList();
                gamesListForm.ShowDialog();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesList list = new GamesList();
            list.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //string location = "";
            this.Hide();
            string location = GamesList.getLocation();
            //location = location.Replace("\\", "\\\\");
            EditGame edit = new EditGame(titleBox.Text, ratingBox.Text, statusBox.Text, genresBox.Text, reviewBox.Text, location);
            edit.ShowDialog();
        }
        
        private void Game_Load (object sender, EventArgs e)
        {
            

            
        }
    }
}
