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
        public double ProfitUsd { get; set; }
        public double ProfitPerc { get; set; }
        public double AveragePrice { get; set; }
        public double CurrentPrice { get; set; }
        public double TokensSold { get; set; }
        public double AverageSellPrice { get; set; }
        public double TotalSellProfit { get; set; }
        public double TotalWorthNow { get; set; }

        public TokenResultsMetrics()
        {

        }

        public TokenResultsMetrics(double amount, double totalInvested, double profitUsd, double profitPerc, double averagePrice, double currentPrice, double tokensSold, double averageSellPrice, double totalSellProfit, double totalWorthNow)
        {
            Amount = amount;
            TotalInvested = totalInvested;
            ProfitUsd = profitUsd;
            ProfitPerc = profitPerc;
            AveragePrice = averagePrice;
            CurrentPrice = currentPrice;
            TokensSold = tokensSold;
            AverageSellPrice = averageSellPrice;
            TotalSellProfit = totalSellProfit;
            TotalWorthNow = totalWorthNow;
        }
    }
}
