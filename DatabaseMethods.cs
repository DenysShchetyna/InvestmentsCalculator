using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentsCalculator
{
    public static class DatabaseMethods
    {
        public static bool DataBaseInsert(InvestmentModel model)
        {
            bool insertOK = false;

            try
            {
                string insertOrder = "Insert into Investments (Date,Ticker,Amount,PriceForOne,TotalPrice,BuySell,Comment) Values (@Date,@Ticker,@Amount,@PriceForOne,@TotalPrice,@BuySell,@Comment)";

                using (SQLiteConnection cnn = new SQLiteConnection(GlobalVariables.ConnectionString))
                {
                    cnn.Execute(insertOrder, model);
                }

                insertOK = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return insertOK;
        }

        public static bool CreateDatabaseTable()
        {
            bool connectionOK = false;
            string tableCreationOrder = "CREATE TABLE if not exists \"Investments\" (\r\n\t\"Date\"\tTEXT NOT NULL UNIQUE,\r\n\t\"Ticker\"\tTEXT NOT NULL,\r\n\t\"Amount\"\tREAL NOT NULL,\r\n\t\"PriceForOne\"\tREAL NOT NULL,\r\n\t\"TotalPrice\"\tREAL NOT NULL,\r\n\t\"BuySell\"\tTEXT NOT NULL\r\n, \"Comment\"\tTEXT)";
            using (SQLiteConnection cnn = new SQLiteConnection(GlobalVariables.ConnectionString))
            {
                try
                {
                    cnn.Open();

                    using (SQLiteCommand createTableCmd = new SQLiteCommand(tableCreationOrder
                        , cnn))
                    {
                        createTableCmd.ExecuteNonQuery();
                    }
                    connectionOK = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return connectionOK;
        }

        public static List<InvestmentModel> GetInvestments(string tickerSpecification = "")
        {
            List<InvestmentModel> investments = new List<InvestmentModel>();

            try
            {
                string getOrder = "";

                if (string.IsNullOrEmpty(tickerSpecification))
                {
                    getOrder = "select * from Investments";
                }
                else
                {
                    getOrder = $"select * from Investments where Ticker == '{tickerSpecification}'";
                }

                using (SQLiteConnection cnn = new SQLiteConnection(GlobalVariables.ConnectionString))
                {
                    investments = cnn.Query<InvestmentModel>(getOrder).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return investments;
        }

        public static void DeleteRecordFromDatabase(string date)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(GlobalVariables.ConnectionString))
                {
                    connection.Open();

                    string deleteQuery = $"DELETE FROM Investments WHERE Date = '{date}'";
                    connection.Execute(deleteQuery);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
