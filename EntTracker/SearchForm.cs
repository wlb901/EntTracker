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
 * This is a form to search through the list of games by title/
 * Can search by partial names (search 'B' to see all results for title starting with letter 'B')
 */
namespace EntTracker
{
    public partial class SearchForm : Form
    {
        string searchText;

        public SearchForm()
        {
            InitializeComponent();
        }
        
        //Search buuton should only return what the user wants to search for
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchText = titleTextBox.Text;
            this.Hide();
        }

        public string getSearchText()
        {
            return searchText;
        }

        //Cancel Button should return to the main game list
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesList list = new GamesList();
            list.ShowDialog();
        }
    }
}
