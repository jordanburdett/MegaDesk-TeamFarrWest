using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Burdett.Models
{
    public static class DataStorage
    {
        // array of quotes
        private static List<DeskQuote> deskQuotes = new List<DeskQuote>();

        // returns all the quotes
        public static List<DeskQuote> getQuotes()
        {
            if (deskQuotes.Count <= 0)
            {
                // read json
                readJSON();
            }
            
            return deskQuotes;
        }

        // adds the new quote to deskquotes and saves to the file.
        public static bool addNewQuote(DeskQuote quote)
        {
            // ensure we have the latest deskQuotes saved
            readJSON();

            // add quote to deskquotes array
            deskQuotes.Add(quote);
            writeJSON();


            return false;
        }

        // not sure if we need this.
        public static bool editQuote(int id)
        {

            return false;
        }

        // not sure if we need this
        public static bool deleteQuote(int id)
        {

            return false;
        }

        // read in the deskQuotes.json
        private static void readJSON()
        {
            // if the file doesn't exist return.
            if (!System.IO.File.Exists("../../Data/quotes.json"))
            {
                return;
            }

            // just in case try catch.
            try
            {
                string json = System.IO.File.ReadAllText("../../Data/quotes.json");

                // deserialize json into object
                deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        // writes the current quotes to a json file.
        private static bool writeJSON()
        {
            // serialize our object
            var json = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);

            try
            {
                System.IO.File.WriteAllText("../../Data/quotes.json", json);
                return true;
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        // gets the current rushOrderPrices from a file.
        public static int[,] getRushOrderPrices()
        {
            // read in the prices from a file alerady written
            // This needs some kind of error handling in case the file can't open. TODO
            string[] numbers = System.IO.File.ReadAllLines("../../Data/rushOrderPrices.txt");

            int[,] rushOrderPrices = new int[3, 3];
          

            int indexFirst = 0;
            int indexSecond = 0;

            // loop through string array and parse to int
            foreach (var number in numbers)
            {
                if (indexSecond == 3)
                {
                    indexSecond = 0;
                    indexFirst++;
                }

                // we could add some error handling here. maybe a try catch! TODO
                int parsedNumber = int.Parse(number);

                rushOrderPrices[indexFirst, indexSecond] = parsedNumber;

                indexSecond++;
            }

            

            return rushOrderPrices;
        }
    }
}
