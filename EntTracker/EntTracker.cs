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
    public partial class EntTracker : Form
    {
        public EntTracker()
        {
            InitializeComponent();
        }

        private void gamesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamesList gamesListForm = new GamesList();
            gamesListForm.ShowDialog();
        }

        private void videosButton_Click(object sender, EventArgs e)
        {

        }

        private void booksButton_Click(object sender, EventArgs e)
        {

        }

        private void musicButton_Click(object sender, EventArgs e)
        {

        }

        private void EntTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }

}
