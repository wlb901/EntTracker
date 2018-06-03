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

            SearchForm search = new SearchForm();
            search.ShowDialog();
            string title = search.getSearchText();
            Console.WriteLine(title + " results of search");

            try
            {
                string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                MySqlConnection connect = new MySqlConnection(connectionInfo);

                //MessageBox.Show("Connected");

                string mySelectQuery = "use mydb; select * from games where title like '" + title + "%';";
                Console.WriteLine("Test");
                Console.WriteLine(mySelectQuery);
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, connect);
                connect.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        this.gamesDataGridView.Rows.Add(myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4));
                        //review = myReader.GetString(5);
                        //Console.WriteLine(myReader.GetString(1));
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

        

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesList gamesList = new GamesList();
            gamesList.ShowDialog();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindList find = new FindList();
            find.ShowDialog();
        }

        

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

        private void GamesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
    }
}
