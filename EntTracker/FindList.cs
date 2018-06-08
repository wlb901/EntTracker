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

//This form return results from the SearchForm. Results displayed exactly like GamesList
//Start on this form after the Find button is clicked on GamesList

namespace EntTracker
{
    public partial class FindList : Form
    {
        static string title = "";
        static string rating = "";
        static string status = "";
        static string genres = "";
        static string review = "";

        public FindList()
        {
            InitializeComponent();

            //First pull up search box
            SearchForm search = new SearchForm();
            search.ShowDialog();
            string title = search.getSearchText();

            //Get and show results form the SearchForm
            try
            {
                string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                MySqlConnection connect = new MySqlConnection(connectionInfo);
                

                string mySelectQuery = "use mydb; select * from games where title like '" + title + "%';";
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, connect);
                connect.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        this.gamesDataGridView.Rows.Add(myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4));
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

        //Back Button return to GamesList
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesList gamesList = new GamesList();
            gamesList.ShowDialog();
        }

        //Find Button starts another FindList to search again
        private void findButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindList find = new FindList();
            find.ShowDialog();
        }

        //Handle title click in gamesDataGridView, just like on the GamesList form
        private void gamesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                title = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                rating = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
                status = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
                genres = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value.ToString();
                review = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value.ToString();
                Console.WriteLine(title);
                this.Hide();
                Game gameForm = new Game();
                gameForm.ShowDialog();
            }
        }

        //Get strings
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

        //Closes Program when X button clicked
        private void GamesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
    }
}
