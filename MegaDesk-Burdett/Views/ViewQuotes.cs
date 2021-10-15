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

namespace MegaDesk_Burdett.Views
{
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
            var quotes = DataStorage.getQuotes();

            QuotesDataGrid.DataSource = quotes;

            QuotesDataGrid.Columns["desk"].Visible = false;
            QuotesDataGrid.Columns["quoteDetails"].Visible = false;

            QuotesDataGrid.Columns["customerName"].HeaderText = "Name";
            QuotesDataGrid.Columns["deliveryOptions"].HeaderText = "Rush Order";
            QuotesDataGrid.Columns["totalPrice"].HeaderText = "Price";

            QuotesDataGrid.Columns["dateDisplayString"].HeaderText = "Date";

            // to allow each column to be sortable.
            foreach (DataGridViewColumn column in QuotesDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuView = this.Tag as MainMenu;
            mainMenuView.Show();
            this.Hide();
        }

        private void SelectQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedQuote = QuotesDataGrid.SelectedRows[0].DataBoundItem as DeskQuote;

                var viewDetails = new DisplayQuotes();
                viewDetails.Tag = this;
                viewDetails.showQuote(selectedQuote);
                viewDetails.Show();
                this.Hide();
            }
            catch
            {
                QuoteErrorLabel.Text = "Please select a quote!";
            }
        }
    }
}
