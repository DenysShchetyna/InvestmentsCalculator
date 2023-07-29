using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentsCalculator
{
    public static class Calculator
    {
        public static TokenResultsMetrics CalculateCurrent(string ticker, List<InvestmentModel> data, List<TokenPrice> tokenPrices)
        {
            TokenResultsMetrics tokenResultsMetrics = new TokenResultsMetrics();

            try
            {
                List<double> allAmountsBought = new List<double>();
                List<double> allTotalPricesBought = new List<double>();
                List<double> allAmountsSold = new List<double>();
                List<double> allTotalPricesSold = new List<double>();

                foreach (InvestmentModel invest in data)
                {
                    if (invest.BuySell.ToUpper() == "BUY")
                    {
                        allAmountsBought.Add(invest.Amount);
                        allTotalPricesBought.Add(invest.TotalPrice);
                    }

                    else if (invest.BuySell.ToUpper() == "SELL")
                    {
                        allAmountsSold.Add(invest.Amount);
                        allTotalPricesSold.Add(invest.TotalPrice);
                    }
                }

                tokenResultsMetrics.Amount = Math.Round(allAmountsBought.Sum(), 5);
                tokenResultsMetrics.TotalInvested = Math.Round(allTotalPricesBought.Sum(), 5);
                tokenResultsMetrics.AveragePrice = Math.Round((tokenResultsMetrics.TotalInvested / tokenResultsMetrics.Amount), 3);
                tokenResultsMetrics.CurrentPrice = tokenPrices.FirstOrDefault(symbol => symbol.Symbol == ticker).Price;
                tokenResultsMetrics.Profit = Math.Round((tokenResultsMetrics.CurrentPrice / tokenResultsMetrics.AveragePrice) - 1, 3) * 100;
                tokenResultsMetrics.Amount = Math.Round(allAmountsBought.Sum() - allAmountsSold.Sum(), 5);
                tokenResultsMetrics.TotalInvested = Math.Round(allTotalPricesBought.Sum() - (allAmountsSold.Sum() * tokenResultsMetrics.AveragePrice), 5);


                tokenResultsMetrics.TokensSold = Math.Round(allAmountsSold.Sum(), 5);
                tokenResultsMetrics.TotalSellProfit = Math.Round(allTotalPricesSold.Sum(), 5);
                tokenResultsMetrics.AverageSellPrice = Math.Round((tokenResultsMetrics.TotalSellProfit / tokenResultsMetrics.TokensSold), 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select another api for this token.");
            }
            return tokenResultsMetrics;
        }
    }
}
