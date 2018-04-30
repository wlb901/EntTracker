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
           
            setTitle(title);
            setRating(rating);
            setGenres(genres);
            setStatus(status);
            setReview(review);
            
        }
    }
}
