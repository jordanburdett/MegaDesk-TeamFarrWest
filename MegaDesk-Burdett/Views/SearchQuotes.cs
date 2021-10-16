using MegaDesk_Burdett.Models;
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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenuView = (MainMenu)this.Tag;
            this.Close();
            mainMenuView.Show();
        }

        private void OnValueSelected(object sender, EventArgs e)
        {
            var selection = MaterialComboBox.SelectedIndex;

            var quotes = DataStorage.getQuotes();

            var filteredQuotes = quotes.FindAll(quote => (int)quote.desk.DesktopMaterial == selection);
            

            SearchQuotesResults.DataSource = filteredQuotes;

            SearchQuotesResults.Columns["desk"].Visible = false;
            SearchQuotesResults.Columns["quoteDetails"].Visible = false;

            SearchQuotesResults.Columns["customerName"].HeaderText = "Name";
            SearchQuotesResults.Columns["deliveryOptions"].HeaderText = "Rush Order";
            SearchQuotesResults.Columns["totalPrice"].HeaderText = "Price";

            SearchQuotesResults.Columns["dateDisplayString"].HeaderText = "Date";

            // to allow each column to be sortable.
            foreach (DataGridViewColumn column in SearchQuotesResults.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedQuote = SearchQuotesResults.SelectedRows[0].DataBoundItem as DeskQuote;

                var viewDetails = new DisplayQuotes();
                viewDetails.Tag = this;
                viewDetails.showQuote(selectedQuote);
                viewDetails.Show();
                this.Hide();
            }
            catch
            {
                SearchQuotesErrorText.Text = "Please select a quote!";
            }
        }
    }
}
