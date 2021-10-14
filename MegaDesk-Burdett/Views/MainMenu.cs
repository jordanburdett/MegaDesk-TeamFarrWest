using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Burdett
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteView = new AddQuote();
            addQuoteView.Tag = this;
            this.Hide();
            addQuoteView.Show();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            DisplayQuotes displayQuoteView = new DisplayQuotes();
            displayQuoteView.Tag = this;
            this.Hide();
            displayQuoteView.Show();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesView = new SearchQuotes();
            searchQuotesView.Tag = this;
            this.Hide();
            searchQuotesView.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
