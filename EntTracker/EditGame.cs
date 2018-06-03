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
    public partial class EditGame : Form
    {
        string originalTitle;
        
        public EditGame(string title, string rating, string status, string genres, string review, string location)
        {
            InitializeComponent();
            titleTextBox.Text = title;
            ratingComboBox.Text = rating;
            statusComboBox.Text = status;

            string[] genresArray = genres.Split(' ');
            for (int i = 0; i < genresCheckedListBox.Items.Count; i++)
            {
                if (genresArray.Contains(genresCheckedListBox.Items[i].ToString()))
                {
                    genresCheckedListBox.SetItemChecked(i, true);
                }
            }

            reviewRichTextBox.Text = review;
            locationLabel.Text = location;
            originalTitle = title;
        }
        
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Set Game information from form
            string newTitle = titleTextBox.Text;
            string newRating = ratingComboBox.Text;
            string newStatus = statusComboBox.Text;
            string newGenres = "";
            List<string> genresList = new List<string>();
            for (int i = 0; i < genresCheckedListBox.Items.Count; i++)
            {
                if (genresCheckedListBox.GetItemChecked(i))
                {
                    genresList.Add((string)genresCheckedListBox.Items[i]);
                }
            }
            for (int i = 0; i < genresList.Count; i++)
            {
                newGenres += genresList[i] + " ";
            }
            string newReview = reviewRichTextBox.Text;
            string newLocation = locationLabel.Text;
            newLocation = newLocation.Replace("\\", "\\\\");

            //Add Game
            try
            {
                string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                MySqlConnection connect = new MySqlConnection(connectionInfo);

                string mySelectQuery = "use mydb; update games set Title = '" + newTitle + "', Rating = '" + newRating + "', Status = '" 
                    + newStatus + "', Genres = '" + newGenres + "', Review = '" + newReview + "', Location = '" + newLocation 
                    + "' where Title = '" + originalTitle + "';";

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


            this.Hide();
            GamesList gamesListForm = new GamesList();
            gamesListForm.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesList gamesListForm = new GamesList();
            gamesListForm.ShowDialog();
        }

        private void pictureTextBox_TextChanged(object sender, EventArgs e)
        {
            //open file selection
        }

        private void locationLabel_Click(object sender, EventArgs e)
        {
            //open file selection
            OpenFileDialog file = new OpenFileDialog();
            DialogResult picLocation = file.ShowDialog();
            locationLabel.Text = file.FileName;
        }
    }
}
