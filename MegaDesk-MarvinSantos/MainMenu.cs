using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_MarvinSantos
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote();

            addQuoteForm.Tag = this;

            addQuoteForm.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            // Create View quotes form 
            var viewQuotes = new ViewAllQuotes(this);

            //Show view quotes form 
            viewQuotes.Show();

            //hide main Menu
            this.Hide();




        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            // Create View quotes form 
            var SearchQuotes = new SearchQuotes(this);

            //Show view quotes form 
           SearchQuotes.Show();

            //hide main Menu
            this.Hide();
        }
    }
}
