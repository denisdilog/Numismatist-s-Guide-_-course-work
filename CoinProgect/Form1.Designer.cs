namespace CoinProgect {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btn_AddCoin = new Button();
            btn_DeleteCoin = new Button();
            btn_EditCoin = new Button();
            dataGridViewCoins = new DataGridView();
            columnCountryCoin = new DataGridViewTextBoxColumn();
            columnDenominationCoin = new DataGridViewTextBoxColumn();
            columnYearCoin = new DataGridViewTextBoxColumn();
            columnMetalCoin = new DataGridViewTextBoxColumn();
            columnMintageCoin = new DataGridViewTextBoxColumn();
            columnFeaturesCoin = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btn_SearchCoins = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboboxSearchCoin = new ComboBox();
            tbYearSearchCoin = new TextBox();
            tbDenominationSearchCoin = new TextBox();
            tbCountrySearchCoin = new TextBox();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            btn_AddCollector = new Button();
            btn_DeleteCollector = new Button();
            btn_EditCollector = new Button();
            dataGridViewCollectors = new DataGridView();
            columnNameCollectors = new DataGridViewTextBoxColumn();
            columnCountryCollectors = new DataGridViewTextBoxColumn();
            columnContactInfoCollectors = new DataGridViewTextBoxColumn();
            columnRareCoinsInfoCollectors = new DataGridViewTextBoxColumn();
            columnHasOwnCollectionCollectors = new DataGridViewCheckBoxColumn();
            groupBox2 = new GroupBox();
            btn_SearchCollectors = new Button();
            label7 = new Label();
            label8 = new Label();
            tbCountrySearchCollector = new TextBox();
            tbNameSearchCollector = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoins).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollectors).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Consolas", 11F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(957, 642);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dataGridViewCoins);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(949, 611);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Монети";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btn_AddCoin);
            panel1.Controls.Add(btn_DeleteCoin);
            panel1.Controls.Add(btn_EditCoin);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(4, 552);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 56);
            panel1.TabIndex = 10;
            // 
            // btn_AddCoin
            // 
            btn_AddCoin.Anchor = AnchorStyles.Bottom;
            btn_AddCoin.BackColor = Color.Aquamarine;
            btn_AddCoin.Cursor = Cursors.Hand;
            btn_AddCoin.FlatAppearance.BorderSize = 0;
            btn_AddCoin.FlatAppearance.MouseDownBackColor = Color.MediumTurquoise;
            btn_AddCoin.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_AddCoin.FlatStyle = FlatStyle.Flat;
            btn_AddCoin.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btn_AddCoin.Location = new Point(256, 12);
            btn_AddCoin.Margin = new Padding(4, 3, 4, 3);
            btn_AddCoin.Name = "btn_AddCoin";
            btn_AddCoin.Size = new Size(120, 33);
            btn_AddCoin.TabIndex = 10;
            btn_AddCoin.Text = "Додати";
            btn_AddCoin.UseVisualStyleBackColor = false;
            btn_AddCoin.Click += btn_AddCoin_Click;
            // 
            // btn_DeleteCoin
            // 
            btn_DeleteCoin.Anchor = AnchorStyles.Bottom;
            btn_DeleteCoin.BackColor = Color.Red;
            btn_DeleteCoin.Cursor = Cursors.Hand;
            btn_DeleteCoin.FlatAppearance.BorderSize = 0;
            btn_DeleteCoin.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btn_DeleteCoin.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_DeleteCoin.FlatStyle = FlatStyle.Flat;
            btn_DeleteCoin.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btn_DeleteCoin.Location = new Point(568, 12);
            btn_DeleteCoin.Margin = new Padding(4, 3, 4, 3);
            btn_DeleteCoin.Name = "btn_DeleteCoin";
            btn_DeleteCoin.Size = new Size(120, 33);
            btn_DeleteCoin.TabIndex = 12;
            btn_DeleteCoin.Text = "Видалити";
            btn_DeleteCoin.UseVisualStyleBackColor = false;
            btn_DeleteCoin.Click += btn_DeleteCoin_Click;
            // 
            // btn_EditCoin
            // 
            btn_EditCoin.Anchor = AnchorStyles.Bottom;
            btn_EditCoin.BackColor = Color.Aquamarine;
            btn_EditCoin.Cursor = Cursors.Hand;
            btn_EditCoin.FlatAppearance.BorderSize = 0;
            btn_EditCoin.FlatAppearance.MouseDownBackColor = Color.MediumTurquoise;
            btn_EditCoin.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_EditCoin.FlatStyle = FlatStyle.Flat;
            btn_EditCoin.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btn_EditCoin.Location = new Point(412, 12);
            btn_EditCoin.Margin = new Padding(4, 3, 4, 3);
            btn_EditCoin.Name = "btn_EditCoin";
            btn_EditCoin.Size = new Size(120, 33);
            btn_EditCoin.TabIndex = 11;
            btn_EditCoin.Text = "Редагувати";
            btn_EditCoin.UseVisualStyleBackColor = false;
            btn_EditCoin.Click += btn_EditCoin_Click;
            // 
            // dataGridViewCoins
            // 
            dataGridViewCoins.AllowUserToAddRows = false;
            dataGridViewCoins.AllowUserToResizeColumns = false;
            dataGridViewCoins.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCoins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCoins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCoins.BackgroundColor = Color.LightYellow;
            dataGridViewCoins.BorderStyle = BorderStyle.None;
            dataGridViewCoins.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCoins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoins.Columns.AddRange(new DataGridViewColumn[] { columnCountryCoin, columnDenominationCoin, columnYearCoin, columnMetalCoin, columnMintageCoin, columnFeaturesCoin });
            dataGridViewCoins.Dock = DockStyle.Fill;
            dataGridViewCoins.GridColor = SystemColors.ScrollBar;
            dataGridViewCoins.Location = new Point(4, 143);
            dataGridViewCoins.Margin = new Padding(4, 3, 4, 3);
            dataGridViewCoins.Name = "dataGridViewCoins";
            dataGridViewCoins.ReadOnly = true;
            dataGridViewCoins.RowHeadersVisible = false;
            dataGridViewCoins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCoins.Size = new Size(941, 465);
            dataGridViewCoins.TabIndex = 1;
            // 
            // columnCountryCoin
            // 
            columnCountryCoin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCountryCoin.DataPropertyName = "Country";
            columnCountryCoin.HeaderText = "Країна";
            columnCountryCoin.Name = "columnCountryCoin";
            columnCountryCoin.ReadOnly = true;
            // 
            // columnDenominationCoin
            // 
            columnDenominationCoin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnDenominationCoin.DataPropertyName = "Denomination";
            columnDenominationCoin.HeaderText = "Номінал";
            columnDenominationCoin.Name = "columnDenominationCoin";
            columnDenominationCoin.ReadOnly = true;
            // 
            // columnYearCoin
            // 
            columnYearCoin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnYearCoin.DataPropertyName = "Year";
            columnYearCoin.FillWeight = 50F;
            columnYearCoin.HeaderText = "Рік";
            columnYearCoin.Name = "columnYearCoin";
            columnYearCoin.ReadOnly = true;
            // 
            // columnMetalCoin
            // 
            columnMetalCoin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnMetalCoin.DataPropertyName = "Metal";
            columnMetalCoin.HeaderText = "Метал";
            columnMetalCoin.Name = "columnMetalCoin";
            columnMetalCoin.ReadOnly = true;
            // 
            // columnMintageCoin
            // 
            columnMintageCoin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnMintageCoin.DataPropertyName = "Mintage";
            columnMintageCoin.FillWeight = 150F;
            columnMintageCoin.HeaderText = "Тираж";
            columnMintageCoin.Name = "columnMintageCoin";
            columnMintageCoin.ReadOnly = true;
            // 
            // columnFeaturesCoin
            // 
            columnFeaturesCoin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnFeaturesCoin.DataPropertyName = "Features";
            columnFeaturesCoin.FillWeight = 250F;
            columnFeaturesCoin.HeaderText = "Особливості";
            columnFeaturesCoin.Name = "columnFeaturesCoin";
            columnFeaturesCoin.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btn_SearchCoins);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboboxSearchCoin);
            groupBox1.Controls.Add(tbYearSearchCoin);
            groupBox1.Controls.Add(tbDenominationSearchCoin);
            groupBox1.Controls.Add(tbCountrySearchCoin);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Consolas", 11F);
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(941, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пошук монет";
            // 
            // btn_SearchCoins
            // 
            btn_SearchCoins.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_SearchCoins.BackColor = Color.Orange;
            btn_SearchCoins.Cursor = Cursors.Hand;
            btn_SearchCoins.FlatAppearance.BorderSize = 0;
            btn_SearchCoins.FlatAppearance.MouseDownBackColor = Color.Coral;
            btn_SearchCoins.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            btn_SearchCoins.FlatStyle = FlatStyle.Flat;
            btn_SearchCoins.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btn_SearchCoins.ForeColor = Color.Black;
            btn_SearchCoins.Location = new Point(793, 92);
            btn_SearchCoins.Margin = new Padding(4, 3, 4, 3);
            btn_SearchCoins.Name = "btn_SearchCoins";
            btn_SearchCoins.Size = new Size(120, 33);
            btn_SearchCoins.TabIndex = 9;
            btn_SearchCoins.Text = "Пошук";
            btn_SearchCoins.UseVisualStyleBackColor = false;
            btn_SearchCoins.Click += btn_SearchCoins_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 104);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 8;
            label4.Text = "Метал";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 79);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 18);
            label3.TabIndex = 7;
            label3.Text = "Рік";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 6;
            label2.Text = "Номінал";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 5;
            label1.Text = "Країна";
            // 
            // comboboxSearchCoin
            // 
            comboboxSearchCoin.Cursor = Cursors.Hand;
            comboboxSearchCoin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxSearchCoin.FormattingEnabled = true;
            comboboxSearchCoin.Items.AddRange(new object[] { "", "Золото", "Срібло", "Платина", "Паладій", "Мідь", "Бронза", "Сталь", "Алюміній", "Мельхіор" });
            comboboxSearchCoin.Location = new Point(114, 103);
            comboboxSearchCoin.Margin = new Padding(4, 3, 4, 3);
            comboboxSearchCoin.Name = "comboboxSearchCoin";
            comboboxSearchCoin.Size = new Size(100, 26);
            comboboxSearchCoin.TabIndex = 4;
            // 
            // tbYearSearchCoin
            // 
            tbYearSearchCoin.Location = new Point(114, 75);
            tbYearSearchCoin.Margin = new Padding(4, 3, 4, 3);
            tbYearSearchCoin.MaxLength = 4;
            tbYearSearchCoin.Name = "tbYearSearchCoin";
            tbYearSearchCoin.Size = new Size(100, 25);
            tbYearSearchCoin.TabIndex = 2;
            tbYearSearchCoin.KeyPress += tbYearSearchCoin_KeyPress;
            // 
            // tbDenominationSearchCoin
            // 
            tbDenominationSearchCoin.Location = new Point(114, 48);
            tbDenominationSearchCoin.Margin = new Padding(4, 3, 4, 3);
            tbDenominationSearchCoin.Name = "tbDenominationSearchCoin";
            tbDenominationSearchCoin.Size = new Size(100, 25);
            tbDenominationSearchCoin.TabIndex = 1;
            // 
            // tbCountrySearchCoin
            // 
            tbCountrySearchCoin.Location = new Point(114, 20);
            tbCountrySearchCoin.Margin = new Padding(4, 3, 4, 3);
            tbCountrySearchCoin.Name = "tbCountrySearchCoin";
            tbCountrySearchCoin.Size = new Size(100, 25);
            tbCountrySearchCoin.TabIndex = 0;
            tbCountrySearchCoin.KeyPress += tbCountrySearchCoin_KeyPress;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(dataGridViewCollectors);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(949, 611);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Колекціонери";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(btn_AddCollector);
            panel2.Controls.Add(btn_DeleteCollector);
            panel2.Controls.Add(btn_EditCollector);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(4, 552);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 56);
            panel2.TabIndex = 1;
            // 
            // btn_AddCollector
            // 
            btn_AddCollector.Anchor = AnchorStyles.Bottom;
            btn_AddCollector.BackColor = Color.Aquamarine;
            btn_AddCollector.Cursor = Cursors.Hand;
            btn_AddCollector.FlatAppearance.BorderSize = 0;
            btn_AddCollector.FlatAppearance.MouseDownBackColor = Color.MediumTurquoise;
            btn_AddCollector.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_AddCollector.FlatStyle = FlatStyle.Flat;
            btn_AddCollector.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btn_AddCollector.Location = new Point(256, 12);
            btn_AddCollector.Margin = new Padding(4, 3, 4, 3);
            btn_AddCollector.Name = "btn_AddCollector";
            btn_AddCollector.Size = new Size(120, 33);
            btn_AddCollector.TabIndex = 13;
            btn_AddCollector.Text = "Додати";
            btn_AddCollector.UseVisualStyleBackColor = false;
            btn_AddCollector.Click += btn_AddCollector_Click;
            // 
            // btn_DeleteCollector
            // 
            btn_DeleteCollector.Anchor = AnchorStyles.Bottom;
            btn_DeleteCollector.BackColor = Color.Red;
            btn_DeleteCollector.Cursor = Cursors.Hand;
            btn_DeleteCollector.FlatAppearance.BorderSize = 0;
            btn_DeleteCollector.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btn_DeleteCollector.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_DeleteCollector.FlatStyle = FlatStyle.Flat;
            btn_DeleteCollector.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btn_DeleteCollector.ForeColor = Color.Black;
            btn_DeleteCollector.Location = new Point(568, 12);
            btn_DeleteCollector.Margin = new Padding(4, 3, 4, 3);
            btn_DeleteCollector.Name = "btn_DeleteCollector";
            btn_DeleteCollector.Size = new Size(120, 33);
            btn_DeleteCollector.TabIndex = 15;
            btn_DeleteCollector.Text = "Видалити";
            btn_DeleteCollector.UseVisualStyleBackColor = false;
            btn_DeleteCollector.Click += btn_DeleteCollector_Click;
            // 
            // btn_EditCollector
            // 
            btn_EditCollector.Anchor = AnchorStyles.Bottom;
            btn_EditCollector.BackColor = Color.Aquamarine;
            btn_EditCollector.Cursor = Cursors.Hand;
            btn_EditCollector.FlatAppearance.BorderSize = 0;
            btn_EditCollector.FlatAppearance.MouseDownBackColor = Color.MediumTurquoise;
            btn_EditCollector.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btn_EditCollector.FlatStyle = FlatStyle.Flat;
            btn_EditCollector.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btn_EditCollector.Location = new Point(412, 12);
            btn_EditCollector.Margin = new Padding(4, 3, 4, 3);
            btn_EditCollector.Name = "btn_EditCollector";
            btn_EditCollector.Size = new Size(120, 33);
            btn_EditCollector.TabIndex = 14;
            btn_EditCollector.Text = "Редагувати";
            btn_EditCollector.UseVisualStyleBackColor = false;
            btn_EditCollector.Click += btn_EditCollector_Click;
            // 
            // dataGridViewCollectors
            // 
            dataGridViewCollectors.AllowUserToAddRows = false;
            dataGridViewCollectors.AllowUserToResizeColumns = false;
            dataGridViewCollectors.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCollectors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCollectors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCollectors.BackgroundColor = Color.LightYellow;
            dataGridViewCollectors.BorderStyle = BorderStyle.None;
            dataGridViewCollectors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCollectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCollectors.Columns.AddRange(new DataGridViewColumn[] { columnNameCollectors, columnCountryCollectors, columnContactInfoCollectors, columnRareCoinsInfoCollectors, columnHasOwnCollectionCollectors });
            dataGridViewCollectors.Dock = DockStyle.Fill;
            dataGridViewCollectors.GridColor = SystemColors.ScrollBar;
            dataGridViewCollectors.Location = new Point(4, 91);
            dataGridViewCollectors.Margin = new Padding(4, 3, 4, 3);
            dataGridViewCollectors.Name = "dataGridViewCollectors";
            dataGridViewCollectors.ReadOnly = true;
            dataGridViewCollectors.RowHeadersVisible = false;
            dataGridViewCollectors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCollectors.Size = new Size(941, 517);
            dataGridViewCollectors.TabIndex = 1;
            // 
            // columnNameCollectors
            // 
            columnNameCollectors.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnNameCollectors.DataPropertyName = "Name";
            columnNameCollectors.FillWeight = 60F;
            columnNameCollectors.HeaderText = "Ім'я";
            columnNameCollectors.Name = "columnNameCollectors";
            columnNameCollectors.ReadOnly = true;
            // 
            // columnCountryCollectors
            // 
            columnCountryCollectors.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCountryCollectors.DataPropertyName = "Country";
            columnCountryCollectors.FillWeight = 50F;
            columnCountryCollectors.HeaderText = "Країна";
            columnCountryCollectors.Name = "columnCountryCollectors";
            columnCountryCollectors.ReadOnly = true;
            // 
            // columnContactInfoCollectors
            // 
            columnContactInfoCollectors.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnContactInfoCollectors.DataPropertyName = "ContactInfo";
            columnContactInfoCollectors.HeaderText = "Контактні дані";
            columnContactInfoCollectors.Name = "columnContactInfoCollectors";
            columnContactInfoCollectors.ReadOnly = true;
            // 
            // columnRareCoinsInfoCollectors
            // 
            columnRareCoinsInfoCollectors.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnRareCoinsInfoCollectors.DataPropertyName = "RareCoinsInfo";
            columnRareCoinsInfoCollectors.HeaderText = "Рідкісні монети";
            columnRareCoinsInfoCollectors.Name = "columnRareCoinsInfoCollectors";
            columnRareCoinsInfoCollectors.ReadOnly = true;
            // 
            // columnHasOwnCollectionCollectors
            // 
            columnHasOwnCollectionCollectors.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnHasOwnCollectionCollectors.DataPropertyName = "HasOwnCollection";
            columnHasOwnCollectionCollectors.FillWeight = 70F;
            columnHasOwnCollectionCollectors.HeaderText = "Власна колекція";
            columnHasOwnCollectionCollectors.Name = "columnHasOwnCollectionCollectors";
            columnHasOwnCollectionCollectors.ReadOnly = true;
            columnHasOwnCollectionCollectors.Resizable = DataGridViewTriState.True;
            columnHasOwnCollectionCollectors.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btn_SearchCollectors);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbCountrySearchCollector);
            groupBox2.Controls.Add(tbNameSearchCollector);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(4, 3);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(941, 88);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Пошук колекціонерів";
            // 
            // btn_SearchCollectors
            // 
            btn_SearchCollectors.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_SearchCollectors.BackColor = Color.Orange;
            btn_SearchCollectors.Cursor = Cursors.Hand;
            btn_SearchCollectors.FlatAppearance.BorderSize = 0;
            btn_SearchCollectors.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            btn_SearchCollectors.FlatStyle = FlatStyle.Flat;
            btn_SearchCollectors.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btn_SearchCollectors.Location = new Point(798, 37);
            btn_SearchCollectors.Margin = new Padding(4, 3, 4, 3);
            btn_SearchCollectors.Name = "btn_SearchCollectors";
            btn_SearchCollectors.Size = new Size(120, 33);
            btn_SearchCollectors.TabIndex = 18;
            btn_SearchCollectors.Text = "Пошук";
            btn_SearchCollectors.UseVisualStyleBackColor = false;
            btn_SearchCollectors.Click += btn_SearchCollectors_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 51);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 15;
            label7.Text = "Країна";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 23);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(40, 18);
            label8.TabIndex = 14;
            label8.Text = "Ім'я";
            // 
            // tbCountrySearchCollector
            // 
            tbCountrySearchCollector.Location = new Point(115, 47);
            tbCountrySearchCollector.Margin = new Padding(4, 3, 4, 3);
            tbCountrySearchCollector.Name = "tbCountrySearchCollector";
            tbCountrySearchCollector.Size = new Size(100, 25);
            tbCountrySearchCollector.TabIndex = 11;
            tbCountrySearchCollector.KeyPress += tbCountrySearchCollector_KeyPress;
            // 
            // tbNameSearchCollector
            // 
            tbNameSearchCollector.Location = new Point(115, 20);
            tbNameSearchCollector.Margin = new Padding(4, 3, 4, 3);
            tbNameSearchCollector.Name = "tbNameSearchCollector";
            tbNameSearchCollector.Size = new Size(100, 25);
            tbNameSearchCollector.TabIndex = 10;
            tbNameSearchCollector.KeyPress += tbNameSearchCollector_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(957, 642);
            Controls.Add(tabControl1);
            Font = new Font("Consolas", 9F);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Довідник нумізмата";
            FormClosing += Form1_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoins).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollectors).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TextBox tbYearSearchCoin;
        private TextBox tbDenominationSearchCoin;
        private TextBox tbCountrySearchCoin;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboboxSearchCoin;
        private Button btn_SearchCoins;
        private Label label4;
        private Button btn_DeleteCoin;
        private Button btn_EditCoin;
        private Button btn_AddCoin;
        private DataGridView dataGridViewCoins;
        private Panel panel1;
        private GroupBox groupBox2;
        private Button btn_SearchCollectors;
        private Label label7;
        private Label label8;
        private TextBox tbCountrySearchCollector;
        private TextBox tbNameSearchCollector;
        private DataGridView dataGridViewCollectors;
        private Panel panel2;
        private Button btn_AddCollector;
        private Button btn_DeleteCollector;
        private Button btn_EditCollector;
        private DataGridViewTextBoxColumn columnCountryCoin;
        private DataGridViewTextBoxColumn columnDenominationCoin;
        private DataGridViewTextBoxColumn columnYearCoin;
        private DataGridViewTextBoxColumn columnMetalCoin;
        private DataGridViewTextBoxColumn columnMintageCoin;
        private DataGridViewTextBoxColumn columnFeaturesCoin;
        private DataGridViewTextBoxColumn columnNameCollectors;
        private DataGridViewTextBoxColumn columnCountryCollectors;
        private DataGridViewTextBoxColumn columnContactInfoCollectors;
        private DataGridViewTextBoxColumn columnRareCoinsInfoCollectors;
        private DataGridViewCheckBoxColumn columnHasOwnCollectionCollectors;
    }
}
