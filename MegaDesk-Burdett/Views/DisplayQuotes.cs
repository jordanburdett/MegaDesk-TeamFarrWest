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
    public partial class DisplayQuotes : Form
    {
        
        public DisplayQuotes()
        {
            InitializeComponent();
        }

        public DeskQuote Quote { get; set; }

        public void showQuote(DeskQuote quote)
        { 
            this.Quote = quote;
            var quoteDetails = quote.calculateQuote();

            CustomerName.Text = quoteDetails.customerName;
            ShippingCost.Text = "$" + quoteDetails.shippingCost.ToString();
            DeskBasePrice.Text = "$" + quoteDetails.deskBasePrice.ToString();
            PriceForDrawers.Text = "$" + quoteDetails.deskDrawersPrice.ToString();
            DeskMaterialPrice.Text = "$" + quoteDetails.deskMaterialPrice.ToString();
            DeskSizePrice.Text = "$" + quoteDetails.deskSizePrice.ToString();

            TotalPrice.Text = "$" + quoteDetails.getTotalCost().ToString();


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenuView = (AddQuote)this.Tag;
            this.Close();
            mainMenuView.Show();
        }

        private void DisplayQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
