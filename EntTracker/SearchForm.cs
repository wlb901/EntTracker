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
    public partial class SearchForm : Form
    {
        string searchText;

        public SearchForm()
        {
            InitializeComponent();
            
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchText = titleTextBox.Text;
            this.Hide();
            //FindList search = new FindList();
            //search.ShowDialog();
            
        }

        public string getSearchText()
        {
            return searchText;
        }
    }
}
