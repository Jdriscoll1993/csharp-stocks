using System;
using System.Collections.Generic;

namespace stock_purchase_report
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("AAPL", "Apple");
            stocks.Add("TWTR", "Twitter");
            stocks.Add("MSFT", "Microsoft");

            var stockPurchases = new Dictionary<string, List<double>>()
            {
                {"GM", new List<double>(){4892.12}},
                {"AAPL", new List<double>(){1214.90, 2881.95}},
                {"TWTR", new List<double>(){180.44, 298.01, 9092.45}},
                {"MSFT", new List<double>(){934.21, 9025.23, 4013.89}}
            };

            foreach (KeyValuePair<string, List<double>> stock in stockPurchases)
            {
                double totalSpend = 0.00;
                stock.Value.ForEach(purchaseVal => totalSpend += totalSpend + purchaseVal);
                Console.WriteLine($"Investor has spent a total of {totalSpend} on the stock for {stocks[stock.Key]}");
            }
        }
    }
}
// Once you've added your stocks and purchases, produce a total ownership report that computes the total amount of money spent by the investor on each stock. Note that the final report has the full company name, not the ticker symbol. You must use the ticker symbol and square bracket notation to get the full company name from the stocks Dictionary.






