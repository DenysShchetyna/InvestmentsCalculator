using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentsCalculator
{
    public class TokenResultsMetrics
    {
        public double Amount { get; set; }
        public double TotalInvested { get; set; }
        public double Profit { get; set; }
        public double AveragePrice { get; set; }
        public double CurrentPrice { get; set; }
        public double TokensSold { get; set; }
        public double AverageSellPrice { get; set; }
        public double TotalSellProfit { get; set; }

        public TokenResultsMetrics(double amount, double totalInvested, double profit, double averagePrice, double currentPrice)
        {
            Amount = amount;
            TotalInvested = totalInvested;
            Profit = profit;
            AveragePrice = averagePrice;
            CurrentPrice = currentPrice;
        }

        public TokenResultsMetrics()
        {

        }
    }
}
