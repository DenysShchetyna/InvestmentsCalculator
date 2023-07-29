using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsCalculator
{
    public class InvestmentModel
    {
        public string Date { get; set; }
        public string Ticker { get; set; }
        public double Amount { get; set; }
        public double PriceForOne { get; set; }
        public double TotalPrice { get; set; }
        public string BuySell { get; set; }
        public string Comment { get; set; }

        public InvestmentModel(
            string date,
            string ticker,
            double amount,
            double priceForOne,
            double totalPrice,
            string buySell,
            string comment)
        {
            Date = date;
            Ticker = ticker;
            Amount = amount;
            PriceForOne = priceForOne;
            TotalPrice = totalPrice;
            BuySell = buySell;
            Comment = comment;
        }

        public InvestmentModel()
        {

        }
    }
}
