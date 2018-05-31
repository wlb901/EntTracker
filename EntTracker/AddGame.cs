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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Set Game information from form
            string title = titleTextBox.Text;
            string rating = ratingComboBox.Text;
            string status = statusComboBox.Text;
            string genres = "";
            List<string> genresList = new List<string>();
            for(int i = 0; i < genresCheckedListBox.Items.Count; i++)
            {
                if (genresCheckedListBox.GetItemChecked(i))
                {
                    genresList.Add((string)genresCheckedListBox.Items[i]);
                }
            }
            for(int i = 0; i < genresList.Count; i++)
            {
                genres += genresList[i];
            }
            string review = reviewRichTextBox.Text;
            string location = pictureTextBox.Text;

            Console.WriteLine("Here!!!!! " + title + " " + rating + " " + status + " " + genres + " " + review + " " + location);
            //Add Game
            try
            {
                string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                MySqlConnection connect = new MySqlConnection(connectionInfo);

                string mySelectQuery = "use mydb; insert into games values (idGames, '" + title + "', '" + rating + "', '" + status 
                    + "', '" + genres + "', '" + review + "', '" + location + "');";

                Console.WriteLine(mySelectQuery);

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

        
    }
}
