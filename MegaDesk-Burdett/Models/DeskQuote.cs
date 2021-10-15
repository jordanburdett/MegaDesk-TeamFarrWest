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
            this.quoteDetails = calculateQuote();
            this.totalPrice = this.quoteDetails.getTotalCost();
        }

        public Desk desk {  get; set; }
        public string customerName {  get; set; }
        public DeliveryOptions deliveryOptions {  get; set; }

        public double totalPrice {  get; set; }

        public QuoteDetails quoteDetails {  get; set; }

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

            // this comes from the file
            var rushOrderPrices = DataStorage.getRushOrderPrices();

            switch (deliveryOptions)
            {
                case DeliveryOptions.Three:
                    quote.shippingCost = ((quote.deskSizePrice < 1000) ? rushOrderPrices[(int)DeliveryOptions.Three, 0] : (quote.deskSizePrice > 1000 && quote.deskSizePrice < 2000) ? rushOrderPrices[(int)DeliveryOptions.Three, 1] : rushOrderPrices[(int)DeliveryOptions.Three, 2]);
                    break;
                case DeliveryOptions.Five:
                    quote.shippingCost = ((quote.deskSizePrice < 1000) ? rushOrderPrices[(int)DeliveryOptions.Five, 0] : (quote.deskSizePrice > 1000 && quote.deskSizePrice < 2000) ? rushOrderPrices[(int)DeliveryOptions.Five, 1] : rushOrderPrices[(int)DeliveryOptions.Five, 2]);
                    break;
                case DeliveryOptions.Seven:
                    quote.shippingCost = ((quote.deskSizePrice < 1000) ? rushOrderPrices[(int)DeliveryOptions.Seven, 0] : (quote.deskSizePrice > 1000 && quote.deskSizePrice < 2000) ? rushOrderPrices[(int)DeliveryOptions.Seven, 1] : rushOrderPrices[(int)DeliveryOptions.Seven, 2]);
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
