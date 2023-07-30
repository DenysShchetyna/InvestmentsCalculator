namespace InvestmentsCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_Ticker = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_PriceForOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_DateTimeNow = new System.Windows.Forms.Label();
            this.timer_DateTimeNow = new System.Windows.Forms.Timer(this.components);
            this.groupBox_AddNewInvestment = new System.Windows.Forms.GroupBox();
            this.radioButton_Sell = new System.Windows.Forms.RadioButton();
            this.radioButton_Buy = new System.Windows.Forms.RadioButton();
            this.button_InvestAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.dataGridView_Investments = new System.Windows.Forms.DataGridView();
            this.button_UpdateDistinctTickersFromDb = new System.Windows.Forms.Button();
            this.listBox_distinctTickersFromDb = new System.Windows.Forms.ListBox();
            this.button_TickerFilterReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_TotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_AveragePrice = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_TokenDetailsCurrent = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_ProfitPerc = new System.Windows.Forms.Label();
            this.label_CurrentPrice = new System.Windows.Forms.Label();
            this.radioButton_apiCMC = new System.Windows.Forms.RadioButton();
            this.radioButton_apiWBT = new System.Windows.Forms.RadioButton();
            this.groupBox_apiSelector = new System.Windows.Forms.GroupBox();
            this.groupBox_TokenDetailsSold = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_TokensSold = new System.Windows.Forms.Label();
            this.label_totalSellProfit = new System.Windows.Forms.Label();
            this.label_averageSellPrice = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_TotalWorthNow = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_ProfitUsd = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox_AddNewInvestment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Investments)).BeginInit();
            this.groupBox_TokenDetailsCurrent.SuspendLayout();
            this.groupBox_apiSelector.SuspendLayout();
            this.groupBox_TokenDetailsSold.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Ticker
            // 
            this.textBox_Ticker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_Ticker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Ticker.Location = new System.Drawing.Point(178, 30);
            this.textBox_Ticker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Ticker.Name = "textBox_Ticker";
            this.textBox_Ticker.Size = new System.Drawing.Size(148, 26);
            this.textBox_Ticker.TabIndex = 0;
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Amount.Location = new System.Drawing.Point(178, 66);
            this.textBox_Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(148, 26);
            this.textBox_Amount.TabIndex = 1;
            // 
            // textBox_PriceForOne
            // 
            this.textBox_PriceForOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PriceForOne.Location = new System.Drawing.Point(178, 102);
            this.textBox_PriceForOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_PriceForOne.Name = "textBox_PriceForOne";
            this.textBox_PriceForOne.Size = new System.Drawing.Size(148, 26);
            this.textBox_PriceForOne.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ticker:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price for 1 ($):";
            // 
            // label_DateTimeNow
            // 
            this.label_DateTimeNow.AutoSize = true;
            this.label_DateTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DateTimeNow.Location = new System.Drawing.Point(13, 9);
            this.label_DateTimeNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DateTimeNow.Name = "label_DateTimeNow";
            this.label_DateTimeNow.Size = new System.Drawing.Size(25, 20);
            this.label_DateTimeNow.TabIndex = 1;
            this.label_DateTimeNow.Text = " - ";
            // 
            // timer_DateTimeNow
            // 
            this.timer_DateTimeNow.Enabled = true;
            this.timer_DateTimeNow.Interval = 1000;
            this.timer_DateTimeNow.Tick += new System.EventHandler(this.timer_DateTimeNow_Tick);
            // 
            // groupBox_AddNewInvestment
            // 
            this.groupBox_AddNewInvestment.Controls.Add(this.radioButton_Sell);
            this.groupBox_AddNewInvestment.Controls.Add(this.radioButton_Buy);
            this.groupBox_AddNewInvestment.Controls.Add(this.button_InvestAdd);
            this.groupBox_AddNewInvestment.Controls.Add(this.label3);
            this.groupBox_AddNewInvestment.Controls.Add(this.textBox_Ticker);
            this.groupBox_AddNewInvestment.Controls.Add(this.label6);
            this.groupBox_AddNewInvestment.Controls.Add(this.label4);
            this.groupBox_AddNewInvestment.Controls.Add(this.textBox_Comment);
            this.groupBox_AddNewInvestment.Controls.Add(this.textBox_Amount);
            this.groupBox_AddNewInvestment.Controls.Add(this.textBox_PriceForOne);
            this.groupBox_AddNewInvestment.Controls.Add(this.label2);
            this.groupBox_AddNewInvestment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_AddNewInvestment.Location = new System.Drawing.Point(17, 39);
            this.groupBox_AddNewInvestment.Name = "groupBox_AddNewInvestment";
            this.groupBox_AddNewInvestment.Size = new System.Drawing.Size(529, 204);
            this.groupBox_AddNewInvestment.TabIndex = 0;
            this.groupBox_AddNewInvestment.TabStop = false;
            this.groupBox_AddNewInvestment.Text = "Add Invest";
            // 
            // radioButton_Sell
            // 
            this.radioButton_Sell.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Sell.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton_Sell.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.radioButton_Sell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.radioButton_Sell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.radioButton_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Sell.Location = new System.Drawing.Point(436, 152);
            this.radioButton_Sell.Name = "radioButton_Sell";
            this.radioButton_Sell.Size = new System.Drawing.Size(70, 30);
            this.radioButton_Sell.TabIndex = 5;
            this.radioButton_Sell.Text = "SELL";
            this.radioButton_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Sell.UseVisualStyleBackColor = true;
            // 
            // radioButton_Buy
            // 
            this.radioButton_Buy.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Buy.Checked = true;
            this.radioButton_Buy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton_Buy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton_Buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton_Buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Buy.Location = new System.Drawing.Point(358, 152);
            this.radioButton_Buy.Name = "radioButton_Buy";
            this.radioButton_Buy.Size = new System.Drawing.Size(70, 30);
            this.radioButton_Buy.TabIndex = 4;
            this.radioButton_Buy.TabStop = true;
            this.radioButton_Buy.Text = "BUY";
            this.radioButton_Buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Buy.UseVisualStyleBackColor = true;
            // 
            // button_InvestAdd
            // 
            this.button_InvestAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_InvestAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InvestAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_InvestAdd.Location = new System.Drawing.Point(389, 28);
            this.button_InvestAdd.Name = "button_InvestAdd";
            this.button_InvestAdd.Size = new System.Drawing.Size(117, 26);
            this.button_InvestAdd.TabIndex = 6;
            this.button_InvestAdd.Text = "ADD";
            this.button_InvestAdd.UseVisualStyleBackColor = true;
            this.button_InvestAdd.Click += new System.EventHandler(this.button_InvestAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Comment";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Comment.Location = new System.Drawing.Point(178, 140);
            this.textBox_Comment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(148, 26);
            this.textBox_Comment.TabIndex = 3;
            // 
            // dataGridView_Investments
            // 
            this.dataGridView_Investments.AllowUserToAddRows = false;
            this.dataGridView_Investments.AllowUserToResizeColumns = false;
            this.dataGridView_Investments.AllowUserToResizeRows = false;
            this.dataGridView_Investments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Investments.Location = new System.Drawing.Point(17, 275);
            this.dataGridView_Investments.MultiSelect = false;
            this.dataGridView_Investments.Name = "dataGridView_Investments";
            this.dataGridView_Investments.RowHeadersWidth = 40;
            this.dataGridView_Investments.Size = new System.Drawing.Size(809, 515);
            this.dataGridView_Investments.TabIndex = 3;
            // 
            // button_UpdateDistinctTickersFromDb
            // 
            this.button_UpdateDistinctTickersFromDb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_UpdateDistinctTickersFromDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateDistinctTickersFromDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_UpdateDistinctTickersFromDb.Location = new System.Drawing.Point(653, 39);
            this.button_UpdateDistinctTickersFromDb.Name = "button_UpdateDistinctTickersFromDb";
            this.button_UpdateDistinctTickersFromDb.Size = new System.Drawing.Size(117, 37);
            this.button_UpdateDistinctTickersFromDb.TabIndex = 2;
            this.button_UpdateDistinctTickersFromDb.Text = "Update";
            this.button_UpdateDistinctTickersFromDb.UseVisualStyleBackColor = true;
            this.button_UpdateDistinctTickersFromDb.Click += new System.EventHandler(this.button_UpdateDistinctTickersFromDb_Click_1);
            // 
            // listBox_distinctTickersFromDb
            // 
            this.listBox_distinctTickersFromDb.FormattingEnabled = true;
            this.listBox_distinctTickersFromDb.ItemHeight = 20;
            this.listBox_distinctTickersFromDb.Location = new System.Drawing.Point(552, 39);
            this.listBox_distinctTickersFromDb.Name = "listBox_distinctTickersFromDb";
            this.listBox_distinctTickersFromDb.Size = new System.Drawing.Size(89, 204);
            this.listBox_distinctTickersFromDb.TabIndex = 5;
            this.listBox_distinctTickersFromDb.SelectedIndexChanged += new System.EventHandler(this.listBox_distinctTickersFromDb_SelectedIndexChanged);
            // 
            // button_TickerFilterReset
            // 
            this.button_TickerFilterReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_TickerFilterReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TickerFilterReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_TickerFilterReset.Location = new System.Drawing.Point(653, 82);
            this.button_TickerFilterReset.Name = "button_TickerFilterReset";
            this.button_TickerFilterReset.Size = new System.Drawing.Size(117, 37);
            this.button_TickerFilterReset.TabIndex = 2;
            this.button_TickerFilterReset.Text = "Reset";
            this.button_TickerFilterReset.UseVisualStyleBackColor = true;
            this.button_TickerFilterReset.Click += new System.EventHandler(this.button_TickerFilterReset_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(17, 805);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Row";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.AutoSize = true;
            this.label_TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TotalAmount.Location = new System.Drawing.Point(160, 35);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(14, 20);
            this.label_TotalAmount.TabIndex = 6;
            this.label_TotalAmount.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Average Price [$]: ";
            // 
            // label_AveragePrice
            // 
            this.label_AveragePrice.AutoSize = true;
            this.label_AveragePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AveragePrice.Location = new System.Drawing.Point(160, 95);
            this.label_AveragePrice.Name = "label_AveragePrice";
            this.label_AveragePrice.Size = new System.Drawing.Size(14, 20);
            this.label_AveragePrice.TabIndex = 6;
            this.label_AveragePrice.Text = "-";
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TotalPrice.Location = new System.Drawing.Point(160, 65);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(14, 20);
            this.label_TotalPrice.TabIndex = 6;
            this.label_TotalPrice.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Invested [$]:";
            // 
            // groupBox_TokenDetailsCurrent
            // 
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label5);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label15);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label9);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label12);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label7);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label_ProfitUsd);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label8);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label_ProfitPerc);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label_TotalWorthNow);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label_TotalAmount);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label_CurrentPrice);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label_AveragePrice);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label_TotalPrice);
            this.groupBox_TokenDetailsCurrent.Controls.Add(this.label1);
            this.groupBox_TokenDetailsCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_TokenDetailsCurrent.Location = new System.Drawing.Point(841, 275);
            this.groupBox_TokenDetailsCurrent.Name = "groupBox_TokenDetailsCurrent";
            this.groupBox_TokenDetailsCurrent.Size = new System.Drawing.Size(252, 265);
            this.groupBox_TokenDetailsCurrent.TabIndex = 7;
            this.groupBox_TokenDetailsCurrent.TabStop = false;
            this.groupBox_TokenDetailsCurrent.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Profit? [%]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Current Price [$]:";
            // 
            // label_ProfitPerc
            // 
            this.label_ProfitPerc.AutoSize = true;
            this.label_ProfitPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ProfitPerc.Location = new System.Drawing.Point(160, 185);
            this.label_ProfitPerc.Name = "label_ProfitPerc";
            this.label_ProfitPerc.Size = new System.Drawing.Size(14, 20);
            this.label_ProfitPerc.TabIndex = 6;
            this.label_ProfitPerc.Text = "-";
            // 
            // label_CurrentPrice
            // 
            this.label_CurrentPrice.AutoSize = true;
            this.label_CurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CurrentPrice.Location = new System.Drawing.Point(160, 125);
            this.label_CurrentPrice.Name = "label_CurrentPrice";
            this.label_CurrentPrice.Size = new System.Drawing.Size(14, 20);
            this.label_CurrentPrice.TabIndex = 6;
            this.label_CurrentPrice.Text = "-";
            // 
            // radioButton_apiCMC
            // 
            this.radioButton_apiCMC.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_apiCMC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton_apiCMC.FlatAppearance.CheckedBackColor = System.Drawing.Color.SkyBlue;
            this.radioButton_apiCMC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.radioButton_apiCMC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.radioButton_apiCMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_apiCMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_apiCMC.Location = new System.Drawing.Point(6, 25);
            this.radioButton_apiCMC.Name = "radioButton_apiCMC";
            this.radioButton_apiCMC.Size = new System.Drawing.Size(111, 35);
            this.radioButton_apiCMC.TabIndex = 3;
            this.radioButton_apiCMC.Text = "CMC";
            this.radioButton_apiCMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_apiCMC.UseVisualStyleBackColor = true;
            // 
            // radioButton_apiWBT
            // 
            this.radioButton_apiWBT.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_apiWBT.Checked = true;
            this.radioButton_apiWBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton_apiWBT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki;
            this.radioButton_apiWBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.radioButton_apiWBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.radioButton_apiWBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_apiWBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_apiWBT.Location = new System.Drawing.Point(6, 68);
            this.radioButton_apiWBT.Name = "radioButton_apiWBT";
            this.radioButton_apiWBT.Size = new System.Drawing.Size(111, 35);
            this.radioButton_apiWBT.TabIndex = 3;
            this.radioButton_apiWBT.TabStop = true;
            this.radioButton_apiWBT.Text = "WBT";
            this.radioButton_apiWBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_apiWBT.UseVisualStyleBackColor = true;
            // 
            // groupBox_apiSelector
            // 
            this.groupBox_apiSelector.Controls.Add(this.radioButton_apiCMC);
            this.groupBox_apiSelector.Controls.Add(this.radioButton_apiWBT);
            this.groupBox_apiSelector.Location = new System.Drawing.Point(647, 129);
            this.groupBox_apiSelector.Name = "groupBox_apiSelector";
            this.groupBox_apiSelector.Size = new System.Drawing.Size(123, 114);
            this.groupBox_apiSelector.TabIndex = 8;
            this.groupBox_apiSelector.TabStop = false;
            this.groupBox_apiSelector.Text = "API Selector";
            // 
            // groupBox_TokenDetailsSold
            // 
            this.groupBox_TokenDetailsSold.Controls.Add(this.label10);
            this.groupBox_TokenDetailsSold.Controls.Add(this.label13);
            this.groupBox_TokenDetailsSold.Controls.Add(this.label_TokensSold);
            this.groupBox_TokenDetailsSold.Controls.Add(this.label_totalSellProfit);
            this.groupBox_TokenDetailsSold.Controls.Add(this.label_averageSellPrice);
            this.groupBox_TokenDetailsSold.Controls.Add(this.label19);
            this.groupBox_TokenDetailsSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_TokenDetailsSold.Location = new System.Drawing.Point(1123, 275);
            this.groupBox_TokenDetailsSold.Name = "groupBox_TokenDetailsSold";
            this.groupBox_TokenDetailsSold.Size = new System.Drawing.Size(309, 196);
            this.groupBox_TokenDetailsSold.TabIndex = 7;
            this.groupBox_TokenDetailsSold.TabStop = false;
            this.groupBox_TokenDetailsSold.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(17, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Total Profit $:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(17, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Average Sell Price $:";
            // 
            // label_TokensSold
            // 
            this.label_TokensSold.AutoSize = true;
            this.label_TokensSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TokensSold.Location = new System.Drawing.Point(175, 33);
            this.label_TokensSold.Name = "label_TokensSold";
            this.label_TokensSold.Size = new System.Drawing.Size(14, 20);
            this.label_TokensSold.TabIndex = 6;
            this.label_TokensSold.Text = "-";
            // 
            // label_totalSellProfit
            // 
            this.label_totalSellProfit.AutoSize = true;
            this.label_totalSellProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_totalSellProfit.Location = new System.Drawing.Point(175, 97);
            this.label_totalSellProfit.Name = "label_totalSellProfit";
            this.label_totalSellProfit.Size = new System.Drawing.Size(14, 20);
            this.label_totalSellProfit.TabIndex = 6;
            this.label_totalSellProfit.Text = "-";
            // 
            // label_averageSellPrice
            // 
            this.label_averageSellPrice.AutoSize = true;
            this.label_averageSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_averageSellPrice.Location = new System.Drawing.Point(175, 65);
            this.label_averageSellPrice.Name = "label_averageSellPrice";
            this.label_averageSellPrice.Size = new System.Drawing.Size(14, 20);
            this.label_averageSellPrice.TabIndex = 6;
            this.label_averageSellPrice.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(17, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Tokens Sold:";
            // 
            // label_TotalWorthNow
            // 
            this.label_TotalWorthNow.AutoSize = true;
            this.label_TotalWorthNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TotalWorthNow.Location = new System.Drawing.Point(160, 155);
            this.label_TotalWorthNow.Name = "label_TotalWorthNow";
            this.label_TotalWorthNow.Size = new System.Drawing.Size(14, 20);
            this.label_TotalWorthNow.TabIndex = 6;
            this.label_TotalWorthNow.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total Worth Now [$]:";
            // 
            // label_ProfitUsd
            // 
            this.label_ProfitUsd.AutoSize = true;
            this.label_ProfitUsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ProfitUsd.Location = new System.Drawing.Point(160, 214);
            this.label_ProfitUsd.Name = "label_ProfitUsd";
            this.label_ProfitUsd.Size = new System.Drawing.Size(14, 20);
            this.label_ProfitUsd.TabIndex = 6;
            this.label_ProfitUsd.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(8, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Profit? [$]:";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1924, 863);
            this.Controls.Add(this.groupBox_apiSelector);
            this.Controls.Add(this.groupBox_TokenDetailsSold);
            this.Controls.Add(this.groupBox_TokenDetailsCurrent);
            this.Controls.Add(this.listBox_distinctTickersFromDb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_TickerFilterReset);
            this.Controls.Add(this.button_UpdateDistinctTickersFromDb);
            this.Controls.Add(this.dataGridView_Investments);
            this.Controls.Add(this.groupBox_AddNewInvestment);
            this.Controls.Add(this.label_DateTimeNow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Investments Calculator";
            this.groupBox_AddNewInvestment.ResumeLayout(false);
            this.groupBox_AddNewInvestment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Investments)).EndInit();
            this.groupBox_TokenDetailsCurrent.ResumeLayout(false);
            this.groupBox_TokenDetailsCurrent.PerformLayout();
            this.groupBox_apiSelector.ResumeLayout(false);
            this.groupBox_TokenDetailsSold.ResumeLayout(false);
            this.groupBox_TokenDetailsSold.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Ticker;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.TextBox textBox_PriceForOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_DateTimeNow;
        private System.Windows.Forms.Timer timer_DateTimeNow;
        private System.Windows.Forms.GroupBox groupBox_AddNewInvestment;
        private System.Windows.Forms.Button button_InvestAdd;
        private System.Windows.Forms.DataGridView dataGridView_Investments;
        private System.Windows.Forms.Button button_UpdateDistinctTickersFromDb;
        private System.Windows.Forms.ListBox listBox_distinctTickersFromDb;
        private System.Windows.Forms.Button button_TickerFilterReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_TotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_AveragePrice;
        private System.Windows.Forms.Label label_TotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox_TokenDetailsCurrent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_CurrentPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_ProfitPerc;
        private System.Windows.Forms.RadioButton radioButton_Sell;
        private System.Windows.Forms.RadioButton radioButton_Buy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.RadioButton radioButton_apiCMC;
        private System.Windows.Forms.RadioButton radioButton_apiWBT;
        private System.Windows.Forms.GroupBox groupBox_apiSelector;
        private System.Windows.Forms.GroupBox groupBox_TokenDetailsSold;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_TokensSold;
        private System.Windows.Forms.Label label_totalSellProfit;
        private System.Windows.Forms.Label label_averageSellPrice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_ProfitUsd;
        private System.Windows.Forms.Label label_TotalWorthNow;
    }
}

