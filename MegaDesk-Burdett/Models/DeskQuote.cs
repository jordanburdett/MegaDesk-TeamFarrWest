using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Burdett.Models
{
    public class DeskQuote
    {
        public DeskQuote(Desk desk, string customerName, DeliveryOptions delivery)
        {
            this.desk = desk;
            this.customerName = customerName;
            this.deliveryOptions = delivery;
        }

        public Desk desk {  get; set; }
        public string customerName {  get; set; }
        public DeliveryOptions deliveryOptions {  get; set; }

        public DateTime quoteDate = DateTime.Now;

        public const double BASEDESKPRICE = 200;
        public const double PRICEPERINCH = 1;
        public const double PRICEPERDRAWER = 50;
        public const double PRICEFOROAKTOP = 200;
        public const double PRICEFORLAMINATETOP = 100;
        public const double PRICEFORPINETOP = 50;
        public const double PRICEFORROSEWOODTOP = 300;
        public const double PRICEFORVENEERTOP = 125;

        


        public QuoteDetails calculateQuote()
        {
            QuoteDetails quote = new QuoteDetails();

            quote.deskBasePrice = DeskQuote.BASEDESKPRICE;
            quote.deskDrawersPrice = DeskQuote.PRICEPERDRAWER * this.desk.numOfDrawers;
            
            switch (desk.DesktopMaterial)
            {
                case MaterialType.Oak:
                    quote.deskMaterialPrice = DeskQuote.PRICEFOROAKTOP;
                    break;
                case MaterialType.Laminate:
                    quote.deskMaterialPrice = DeskQuote.PRICEFORLAMINATETOP;
                    break;
                case MaterialType.Rosewood:
                    quote.deskMaterialPrice = DeskQuote.PRICEFORROSEWOODTOP;
                    break;
                case MaterialType.Veneer:
                    quote.deskMaterialPrice = DeskQuote.PRICEFORVENEERTOP;
                    break;
                case MaterialType.Pine:
                    quote.deskMaterialPrice = DeskQuote.PRICEFORPINETOP;
                    break;
            }

            quote.deskSizePrice = (desk.width * desk.depth) * DeskQuote.PRICEPERINCH;

            switch (deliveryOptions)
            {
                case DeliveryOptions.Three:
                    quote.shippingCost = ((quote.deskSizePrice < 1000) ? 60 : (quote.deskSizePrice > 1000 && quote.deskSizePrice < 2000) ? 70 : 80);
                    break;
                case DeliveryOptions.Five:
                    quote.shippingCost = ((quote.deskSizePrice < 1000) ? 40 : (quote.deskSizePrice > 1000 && quote.deskSizePrice < 2000) ? 50 : 60);
                    break;
                case DeliveryOptions.Seven:
                    quote.shippingCost = ((quote.deskSizePrice < 1000) ? 30 : (quote.deskSizePrice > 1000 && quote.deskSizePrice < 2000) ? 35 : 40);
                    break;
            }

            quote.quoteDate = this.quoteDate;
            quote.customerName = this.customerName;

            return quote;
        }
    }


    public enum DeliveryOptions
    { 
        Three,Five,Seven
    }

    public struct QuoteDetails
    {
        public string customerName;
        public double shippingCost;
        public double deskBasePrice;
        public double deskMaterialPrice;
        public double deskSizePrice;
        public double deskDrawersPrice;
        public DateTime quoteDate;

        public double getTotalCost() { 
            return shippingCost + deskBasePrice + deskMaterialPrice + deskSizePrice + deskDrawersPrice;
        }
    }
}
