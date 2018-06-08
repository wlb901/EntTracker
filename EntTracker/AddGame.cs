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

//This form is used for adding a new game to the database
//Rating, Status, and Genres options are all listed in AddGame.Designer.cs
namespace EntTracker
{
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        //Submit Button adds the game to the database. Title is made to be unique in the database (Duplicate entry popup, returns to GamesList)
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Set Game information from form
            string title = titleTextBox.Text;
            string rating = ratingComboBox.Text;
            string status = statusComboBox.Text;
            string genres = "";

            //Genres starts off as a list and is converted to a single string
            List<string> genresList = new List<string>();

            //loop to add each item in the checkedListBox to genresList
            for(int i = 0; i < genresCheckedListBox.Items.Count; i++)
            {
                if (genresCheckedListBox.GetItemChecked(i))
                {
                    genresList.Add((string)genresCheckedListBox.Items[i] + " ");
                }
            }

            //loop to add each item of genresList to a single string
            for(int i = 0; i < genresList.Count; i++)
            {
                genres += genresList[i];
            }

            string review = reviewRichTextBox.Text;
            string location = pictureLocation.Text;
            
            //Add Game to database
            try
            {
                string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                MySqlConnection connect = new MySqlConnection(connectionInfo);

           
                string mySelectQuery = "use mydb; insert into games (Title, Rating, Status, Genres, Review, Location) Values( @0, @1, @2, @3, @4, @5);";

                connect.Open();
                MySqlCommand command = new MySqlCommand(mySelectQuery, connect);
                command.Parameters.AddWithValue("@0", title);
                command.Parameters.AddWithValue("@1", rating);
                command.Parameters.AddWithValue("@2", status);
                command.Parameters.AddWithValue("@3", genres);
                command.Parameters.AddWithValue("@4", review);
                command.Parameters.AddWithValue("@5", location);

                command.Prepare();
                command.ExecuteNonQuery();
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

        //Cancel Button returns to GamesList
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesList gamesListForm = new GamesList();
            gamesListForm.ShowDialog();
        }

        //The Picture box (actually a label) should be clickable and bring up a file selection
        private void pictureLocation_Click(object sender, EventArgs e)
        {
            //open file selection
            OpenFileDialog file = new OpenFileDialog();
            DialogResult picLocation = file.ShowDialog();
            pictureLocation.Text = file.FileName;
        }
    }
}
