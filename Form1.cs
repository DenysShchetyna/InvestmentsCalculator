using Dapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InvestmentsCalculator
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private DataTable DataTable = new DataTable();

        private const string apiUrlCMC = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest";
        private const string apiUrlWBT = " https://whitebit.com/api/v4/public/ticker";
        private HttpClient httpClientCMC = new HttpClient();
        private HttpClient httpClientWBT = new HttpClient();

        List<TokenPrice> TokenPrices;
        string CurrentSelectedTicker = "";

        public MainForm()
        {
            InitializeComponent();
            timer_DateTimeNow.Start();

            bool connectionOK = DatabaseMethods.CreateDatabaseTable();
            if (connectionOK == false)
            {
                Console.WriteLine("Eror with connection to DB");
            }
            else
            {
                dataGridSetup();
                UpdateInvestmentsDatagridView();
                SetEqualColumnWidths();
                RefreshDistinctTickers();
                GetDataFromWBT();
            }
        }

        public async void GetDataFromCMC(string selectedTicker = "")
        {
            await LoadTokenPricesCMC(selectedTicker);
        }
        public async void GetDataFromWBT(string selectedTicker = "")
        {
            await LoadTokenPricesWBT(selectedTicker);
        }

        private void timer_DateTimeNow_Tick(object sender, EventArgs e)
        {
            label_DateTimeNow.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        public string GetSelectedRadioButton(Control container)
        {
            string output = "";

            foreach (Control c in container.Controls)
            {
                GetSelectedRadioButton(c);

                if (c is RadioButton)
                {
                    RadioButton radioBtn = (RadioButton)c;
                    if (radioBtn.Checked == true)
                        return radioBtn.Text;
                }
            }
            return output;
        }

        public InvestmentModel GetInvestmentModel()
        {
            InvestmentModel investmentModel = null;

            try
            {
                string buySell = GetSelectedRadioButton(groupBox_AddNewInvestment);

                investmentModel = new InvestmentModel
                {
                    Date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"),
                    Ticker = textBox_Ticker.Text,
                    Amount = Math.Round(Convert.ToDouble(textBox_Amount.Text), 5),
                    PriceForOne = Math.Round(Convert.ToDouble(textBox_PriceForOne.Text), 5),
                    BuySell = buySell,
                    Comment = textBox_Comment.Text
                };

                investmentModel.TotalPrice = Math.Round(investmentModel.Amount * investmentModel.PriceForOne, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return investmentModel;
        }

        private void button_InvestAdd_Click(object sender, EventArgs e)
        {
            try
            {
                InvestmentModel investmentModel = GetInvestmentModel();

                if (DatabaseMethods.DataBaseInsert(investmentModel) == true)
                {
                    //if (investmentModel.Ticker.ToUpper() != CurrentSelectedTicker.ToUpper())
                    //{
                    //    UpdateInvestmentsDatagridView();
                    //}

                    RefreshDistinctTickers();
                }

                BuildTokenMetrics();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void button_UpdateDistinctTickersFromDb_Click_1(object sender, EventArgs e)
        {
            RefreshDistinctTickers();
        }

        private void RefreshDistinctTickers()
        {
            try
            {
                listBox_distinctTickersFromDb.Items.Clear();

                List<InvestmentModel> investments = DatabaseMethods.GetInvestments().GroupBy(p => p.Ticker)
                                           .Select(g => g.First())
                                           .ToList();

                foreach (InvestmentModel model in investments)
                {
                    listBox_distinctTickersFromDb.Items.Add(model.Ticker);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void dataGridSetup()
        {
            DataTable.Clear(); // Clear existing data in the DataTable.
            DataTable.Columns.Clear(); // Clear existing columns in the DataTable.

            // Add columns to the DataTable based on the YourModelClass properties (modify as needed).
            DataTable.Columns.Add("Date", typeof(string));
            DataTable.Columns.Add("Ticker", typeof(string));
            DataTable.Columns.Add("Amount", typeof(double));
            DataTable.Columns.Add("PriceForOne", typeof(double));
            DataTable.Columns.Add("TotalPrice", typeof(double));
            DataTable.Columns.Add("BuySell", typeof(string));
            DataTable.Columns.Add("Comment", typeof(string));
        }

        private void ApplyRowFormatting()
        {
            foreach (DataGridViewRow dataGridViewRow in dataGridView_Investments.Rows)
            {
                string indicator = dataGridViewRow.Cells["BuySell"].Value.ToString().ToUpper();
                if (indicator == "SELL")
                {
                    dataGridViewRow.DefaultCellStyle.BackColor = Color.FromArgb(0xFF, 0x31, 0x31); ;
                }
                else if (indicator == "BUY")
                {
                    dataGridViewRow.DefaultCellStyle.BackColor = Color.FromArgb(0x86, 0xFF, 0x78);
                }
            }
        }

        public List<InvestmentModel> UpdateInvestmentsDatagridView(string filterTicker = "")
        {
            List<InvestmentModel> data = new List<InvestmentModel>(); ;
            try
            {
                DataTable.Rows.Clear();
                data = DatabaseMethods.GetInvestments(filterTicker);

                // Add rows to the DataTable from the retrieved data.
                for (int i = 0; i < data.Count; i++)
                {
                    DataTable.Rows.Add(data[i].Date, data[i].Ticker, data[i].Amount, data[i].PriceForOne, data[i].TotalPrice, data[i].BuySell, data[i].Comment);
                }

                dataGridView_Investments.DataSource = DataTable;

                ApplyRowFormatting();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return data;
        }

        private void SetEqualColumnWidths()
        {
            int totalWidth = dataGridView_Investments.Width;
            int columnCount = dataGridView_Investments.Columns.Count;
            int columnWidth = totalWidth / columnCount;

            foreach (DataGridViewColumn column in dataGridView_Investments.Columns)
            {
                column.Width = columnWidth;
            }
            double onePercOfTableWithPix = dataGridView_Investments.Width / 100;

            dataGridView_Investments.Columns["Date"].Width = Convert.ToInt32(25 * onePercOfTableWithPix);
            dataGridView_Investments.Columns["Ticker"].Width = Convert.ToInt32(10 * onePercOfTableWithPix);
            dataGridView_Investments.Columns["Amount"].Width = Convert.ToInt32(10 * onePercOfTableWithPix);
            dataGridView_Investments.Columns["PriceForOne"].Width = Convert.ToInt32(10 * onePercOfTableWithPix);
            dataGridView_Investments.Columns["TotalPrice"].Width = Convert.ToInt32(10 * onePercOfTableWithPix);
            dataGridView_Investments.Columns["BuySell"].Width = Convert.ToInt32(10 * onePercOfTableWithPix);
            dataGridView_Investments.Columns["Comment"].Width = Convert.ToInt32(25 * onePercOfTableWithPix);
        }

        private void button_TickerFilterReset_Click(object sender, EventArgs e)
        {
            CurrentSelectedTicker = "";

            UpdateInvestmentsDatagridView();
            ResetTokenDetails();
        }



        private void listBox_distinctTickersFromDb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox_distinctTickersFromDb.SelectedIndex >= 0)
                {
                    string selectedTicker = listBox_distinctTickersFromDb.SelectedItem as string;
                    CurrentSelectedTicker = selectedTicker;
                    BuildTokenMetrics();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void BuildTokenMetrics()
        {
            string SelectedApi = GetSelectedRadioButton(groupBox_apiSelector);

            switch (SelectedApi)
            {
                case "WBT":
                    GetDataFromWBT(CurrentSelectedTicker);
                    break;
                case "CMC":
                    GetDataFromCMC(CurrentSelectedTicker);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView_Investments.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView_Investments.SelectedRows[0].Index;
                string primaryKeyValue = dataGridView_Investments["Date", rowIndex].Value.ToString();
                DatabaseMethods.DeleteRecordFromDatabase(primaryKeyValue);
                dataGridView_Investments.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        public async Task LoadTokenPricesCMC(string selectedTicker = "")
        {
            try
            {
                // Prepare the API request.
                httpClientCMC.DefaultRequestHeaders.Clear();
                httpClientCMC.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", GlobalVariables.ApiKeyCMC);

                // Perform the API request.
                HttpResponseMessage response = await httpClientCMC.GetAsync(apiUrlCMC);
                string responseContent = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to get token prices.
                JObject json = JObject.Parse(responseContent);
                JArray data = (JArray)json["data"];

                // Create a list to store token prices.
                TokenPrices = new List<TokenPrice>();

                foreach (JToken item in data)
                {
                    string name = item["name"].ToString();
                    string symbol = item["symbol"].ToString();

                    if (listBox_distinctTickersFromDb.Items.Contains(symbol) == true)
                    {
                        double price = Math.Round(double.Parse(item["quote"]["USD"]["price"].ToString()), 3);
                        TokenPrices.Add(new TokenPrice { Name = name, Symbol = symbol, Price = price });
                    }
                }

                if (selectedTicker != "")
                {
                    List<InvestmentModel> models = UpdateInvestmentsDatagridView(selectedTicker);
                    groupBox_TokenDetailsCurrent.Text = selectedTicker;
                    groupBox_TokenDetailsSold.Text = selectedTicker;

                    TokenResultsMetrics tokenMetrics = Calculator.CalculateCurrent(selectedTicker, models, TokenPrices);

                    label_TotalAmount.Text = tokenMetrics.Amount.ToString();
                    label_TotalPrice.Text = tokenMetrics.TotalInvested.ToString();
                    label_AveragePrice.Text = tokenMetrics.AveragePrice.ToString();
                    label_ProfitPerc.Text = tokenMetrics.ProfitPerc.ToString() + "%";
                    label_CurrentPrice.Text = tokenMetrics.CurrentPrice.ToString();
                    label_TotalWorthNow.Text = tokenMetrics.TotalWorthNow.ToString();
                    label_ProfitUsd.Text = tokenMetrics.ProfitUsd.ToString();

                    label_TokensSold.Text = tokenMetrics.TokensSold.ToString();
                    label_averageSellPrice.Text = tokenMetrics.AverageSellPrice.ToString();
                    label_totalSellProfit.Text = tokenMetrics.TotalSellProfit.ToString();

                    if (tokenMetrics.ProfitPerc > 0)
                    {
                        label_ProfitPerc.BackColor = Color.Green;
                        label_ProfitUsd.BackColor = Color.Green;
                    }
                    else
                    {
                        label_ProfitPerc.BackColor = Color.Red;
                        label_ProfitUsd.BackColor = Color.Red;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task LoadTokenPricesWBT(string selectedTicker = "")
        {
            try
            {
                // Prepare the API request.
                httpClientWBT.DefaultRequestHeaders.Clear();
                httpClientWBT.DefaultRequestHeaders.Add("X-TXC-APIKEY", GlobalVariables.ApiKeyWBT);

                // Perform the API request.
                HttpResponseMessage response = await httpClientCMC.GetAsync(apiUrlWBT);
                string responseContent = await response.Content.ReadAsStringAsync();

                JObject parsedData = JsonConvert.DeserializeObject<JObject>(responseContent);

                // Extract all "last_price" parameters
                var lastPrices = new JObject();
                //foreach (var entry in parsedData)
                //{
                //    lastPrices[entry.Key] = entry.Value["last_price"];
                //}

                // Print the results
                //Console.WriteLine(lastPrices);

                // Create a list to store token prices.
                TokenPrices = new List<TokenPrice>();

                foreach (var item in parsedData)
                {
                    if (listBox_distinctTickersFromDb.Items.Contains(item.Key.Split('_')[0]) == true && item.Key.Contains("_USDT"))
                    {
                        TokenPrices.Add(new TokenPrice
                        {
                            Name = item.Key.Split('_')[0],
                            Symbol = item.Key.Split('_')[0],
                            Price = Convert.ToDouble(item.Value["last_price"])
                        });

                    }
                    //      
                    //        if (listBox_distinctTickersFromDb.Items.Contains(symbol) == true)
                    //        {
                    //            double price = Math.Round(double.Parse(item["quote"]["USD"]["price"].ToString()), 3);
                    //            TokenPrices.Add(new TokenPrice { Name = name, Symbol = symbol, Price = price });
                    //        }
                    //    }
                }
                if (selectedTicker != "")
                {
                    List<InvestmentModel> models = UpdateInvestmentsDatagridView(selectedTicker);
                    groupBox_TokenDetailsCurrent.Text = selectedTicker + " - current";
                    groupBox_TokenDetailsSold.Text = selectedTicker + " - sold";

                    TokenResultsMetrics tokenMetrics = Calculator.CalculateCurrent(selectedTicker, models, TokenPrices);

                    label_TotalAmount.Text = tokenMetrics.Amount.ToString();
                    label_TotalPrice.Text = tokenMetrics.TotalInvested.ToString();
                    label_AveragePrice.Text = tokenMetrics.AveragePrice.ToString();
                    label_ProfitPerc.Text = tokenMetrics.ProfitPerc.ToString() + "%";
                    label_CurrentPrice.Text = tokenMetrics.CurrentPrice.ToString();
                    label_TotalWorthNow.Text = tokenMetrics.TotalWorthNow.ToString();
                    label_ProfitUsd.Text = tokenMetrics.ProfitUsd.ToString();

                    label_TokensSold.Text = tokenMetrics.TokensSold.ToString();
                    label_averageSellPrice.Text = tokenMetrics.AverageSellPrice.ToString();
                    label_totalSellProfit.Text = tokenMetrics.TotalSellProfit.ToString();

                    if (tokenMetrics.ProfitPerc > 0)
                    {
                        label_ProfitPerc.BackColor = Color.Green;
                        label_ProfitUsd.BackColor = Color.Green;
                    }
                    else
                    {
                        label_ProfitPerc.BackColor = Color.Red;
                        label_ProfitUsd.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ResetTokenDetails()
        {
            label_TotalAmount.Text = "-";
            label_TotalPrice.Text = "-";
            label_AveragePrice.Text = "-";
            label_ProfitPerc.Text = "-";
            label_CurrentPrice.Text = "-";
            label_ProfitPerc.Text = "-";
            label_ProfitPerc.BackColor = Color.DarkGray;
            label_TokensSold.Text = "-";
            label_averageSellPrice.Text = "-";
            label_totalSellProfit.Text = "-";

            groupBox_TokenDetailsCurrent.Text = "-";
            groupBox_TokenDetailsSold.Text = "-";
        }
    }
}
