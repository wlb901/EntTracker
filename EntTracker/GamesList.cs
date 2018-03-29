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
    public partial class GamesList : Form
    {
        static string title = "";

        public GamesList()
        {
            InitializeComponent();
            //Add games to List
            
            try
            {
                string connectionInfo = "datasource = 127.0.0.1; port = 3306; username = root; password = password";
                MySqlConnection connect = new MySqlConnection(connectionInfo);

                //MessageBox.Show("Connected");

                string mySelectQuery = "use mydb; select * from games;";
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, connect);
                connect.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        this.gamesDataGridView.Rows.Add(myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4));
                        Console.WriteLine(myReader.GetString(1));
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

        private void booksButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGame addGameForm = new AddGame();
            addGameForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void videosButton_Click(object sender, EventArgs e)
        {

        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameListClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //Environment.Exit(0);
                Console.WriteLine("exit");
                Application.Exit();
            }
            if (this.DialogResult == DialogResult.Cancel)
            {
                Console.WriteLine("here");
                Application.Exit();
            }
            if (this.DialogResult == DialogResult.Abort)
            {
                Console.WriteLine("this");
                Application.Exit();
            }
        }

        private void gamesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 0)
            {
                title = gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Console.WriteLine(title);
                //this.Hide();
                Game gameForm = new Game();
                gameForm.ShowDialog();
            }
            //DataGridViewImageCell cell = (DataGridViewImageCell)
            //gamesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //Console.WriteLine(sender);
        }

        public static string getTitle()
        {
            return title;
        }
    }
}
