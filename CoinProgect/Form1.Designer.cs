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
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 726);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dataGridViewCoins);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(922, 698);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Монети";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_AddCoin);
            panel1.Controls.Add(btn_DeleteCoin);
            panel1.Controls.Add(btn_EditCoin);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 635);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 60);
            panel1.TabIndex = 10;
            // 
            // btn_AddCoin
            // 
            btn_AddCoin.Anchor = AnchorStyles.Bottom;
            btn_AddCoin.Location = new Point(242, 13);
            btn_AddCoin.Name = "btn_AddCoin";
            btn_AddCoin.Size = new Size(120, 35);
            btn_AddCoin.TabIndex = 10;
            btn_AddCoin.Text = "Додати";
            btn_AddCoin.UseVisualStyleBackColor = true;
            btn_AddCoin.Click += btn_AddCoin_Click;
            // 
            // btn_DeleteCoin
            // 
            btn_DeleteCoin.Anchor = AnchorStyles.Bottom;
            btn_DeleteCoin.Location = new Point(554, 13);
            btn_DeleteCoin.Name = "btn_DeleteCoin";
            btn_DeleteCoin.Size = new Size(120, 35);
            btn_DeleteCoin.TabIndex = 12;
            btn_DeleteCoin.Text = "Видалити";
            btn_DeleteCoin.UseVisualStyleBackColor = true;
            btn_DeleteCoin.Click += btn_DeleteCoin_Click;
            // 
            // btn_EditCoin
            // 
            btn_EditCoin.Anchor = AnchorStyles.Bottom;
            btn_EditCoin.Location = new Point(397, 13);
            btn_EditCoin.Name = "btn_EditCoin";
            btn_EditCoin.Size = new Size(120, 35);
            btn_EditCoin.TabIndex = 11;
            btn_EditCoin.Text = "Редагувати";
            btn_EditCoin.UseVisualStyleBackColor = true;
            btn_EditCoin.Click += btn_EditCoin_Click;
            // 
            // dataGridViewCoins
            // 
            dataGridViewCoins.AllowUserToAddRows = false;
            dataGridViewCoins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCoins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoins.Columns.AddRange(new DataGridViewColumn[] { columnCountryCoin, columnDenominationCoin, columnYearCoin, columnMetalCoin, columnMintageCoin, columnFeaturesCoin });
            dataGridViewCoins.Dock = DockStyle.Fill;
            dataGridViewCoins.Location = new Point(3, 153);
            dataGridViewCoins.Name = "dataGridViewCoins";
            dataGridViewCoins.ReadOnly = true;
            dataGridViewCoins.RowHeadersVisible = false;
            dataGridViewCoins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCoins.Size = new Size(916, 542);
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
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(916, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пошук монет";
            // 
            // btn_SearchCoins
            // 
            btn_SearchCoins.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_SearchCoins.Location = new Point(767, 98);
            btn_SearchCoins.Name = "btn_SearchCoins";
            btn_SearchCoins.Size = new Size(120, 35);
            btn_SearchCoins.TabIndex = 9;
            btn_SearchCoins.Text = "Пошук";
            btn_SearchCoins.UseVisualStyleBackColor = true;
            btn_SearchCoins.Click += btn_SearchCoins_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 113);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Метал";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 84);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 7;
            label3.Text = "Рік";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 55);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "Номінал";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Країна";
            // 
            // comboboxSearchCoin
            // 
            comboboxSearchCoin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxSearchCoin.FormattingEnabled = true;
            comboboxSearchCoin.Items.AddRange(new object[] { "", "Золото", "Срібло", "Платина", "Паладій", "Мідь", "Бронза", "Сталь", "Алюміній", "Мельхіор" });
            comboboxSearchCoin.Location = new Point(114, 110);
            comboboxSearchCoin.Name = "comboboxSearchCoin";
            comboboxSearchCoin.Size = new Size(100, 23);
            comboboxSearchCoin.TabIndex = 4;
            // 
            // tbYearSearchCoin
            // 
            tbYearSearchCoin.Location = new Point(114, 81);
            tbYearSearchCoin.MaxLength = 4;
            tbYearSearchCoin.Name = "tbYearSearchCoin";
            tbYearSearchCoin.Size = new Size(100, 23);
            tbYearSearchCoin.TabIndex = 2;
            tbYearSearchCoin.KeyPress += tbYearSearchCoin_KeyPress;
            // 
            // tbDenominationSearchCoin
            // 
            tbDenominationSearchCoin.Location = new Point(114, 52);
            tbDenominationSearchCoin.Name = "tbDenominationSearchCoin";
            tbDenominationSearchCoin.Size = new Size(100, 23);
            tbDenominationSearchCoin.TabIndex = 1;
            // 
            // tbCountrySearchCoin
            // 
            tbCountrySearchCoin.Location = new Point(114, 23);
            tbCountrySearchCoin.Name = "tbCountrySearchCoin";
            tbCountrySearchCoin.Size = new Size(100, 23);
            tbCountrySearchCoin.TabIndex = 0;
            tbCountrySearchCoin.KeyPress += tbCountrySearchCoin_KeyPress;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(dataGridViewCollectors);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(922, 698);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Колекціонери";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_AddCollector);
            panel2.Controls.Add(btn_DeleteCollector);
            panel2.Controls.Add(btn_EditCollector);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 635);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 60);
            panel2.TabIndex = 1;
            // 
            // btn_AddCollector
            // 
            btn_AddCollector.Anchor = AnchorStyles.Bottom;
            btn_AddCollector.Location = new Point(242, 13);
            btn_AddCollector.Name = "btn_AddCollector";
            btn_AddCollector.Size = new Size(120, 35);
            btn_AddCollector.TabIndex = 13;
            btn_AddCollector.Text = "Додати";
            btn_AddCollector.UseVisualStyleBackColor = true;
            btn_AddCollector.Click += btn_AddCollector_Click;
            // 
            // btn_DeleteCollector
            // 
            btn_DeleteCollector.Anchor = AnchorStyles.Bottom;
            btn_DeleteCollector.Location = new Point(554, 13);
            btn_DeleteCollector.Name = "btn_DeleteCollector";
            btn_DeleteCollector.Size = new Size(120, 35);
            btn_DeleteCollector.TabIndex = 15;
            btn_DeleteCollector.Text = "Видалити";
            btn_DeleteCollector.UseVisualStyleBackColor = true;
            btn_DeleteCollector.Click += btn_DeleteCollector_Click;
            // 
            // btn_EditCollector
            // 
            btn_EditCollector.Anchor = AnchorStyles.Bottom;
            btn_EditCollector.Location = new Point(397, 13);
            btn_EditCollector.Name = "btn_EditCollector";
            btn_EditCollector.Size = new Size(120, 35);
            btn_EditCollector.TabIndex = 14;
            btn_EditCollector.Text = "Редагувати";
            btn_EditCollector.UseVisualStyleBackColor = true;
            btn_EditCollector.Click += btn_EditCollector_Click;
            // 
            // dataGridViewCollectors
            // 
            dataGridViewCollectors.AllowUserToAddRows = false;
            dataGridViewCollectors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCollectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCollectors.Columns.AddRange(new DataGridViewColumn[] { columnNameCollectors, columnCountryCollectors, columnContactInfoCollectors, columnRareCoinsInfoCollectors, columnHasOwnCollectionCollectors });
            dataGridViewCollectors.Dock = DockStyle.Fill;
            dataGridViewCollectors.Location = new Point(3, 97);
            dataGridViewCollectors.Name = "dataGridViewCollectors";
            dataGridViewCollectors.ReadOnly = true;
            dataGridViewCollectors.RowHeadersVisible = false;
            dataGridViewCollectors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCollectors.Size = new Size(916, 598);
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
            groupBox2.Controls.Add(btn_SearchCollectors);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbCountrySearchCollector);
            groupBox2.Controls.Add(tbNameSearchCollector);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(916, 94);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Пошук колекціонерів";
            // 
            // btn_SearchCollectors
            // 
            btn_SearchCollectors.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_SearchCollectors.Location = new Point(771, 40);
            btn_SearchCollectors.Name = "btn_SearchCollectors";
            btn_SearchCollectors.Size = new Size(120, 35);
            btn_SearchCollectors.TabIndex = 18;
            btn_SearchCollectors.Text = "Пошук";
            btn_SearchCollectors.UseVisualStyleBackColor = true;
            btn_SearchCollectors.Click += btn_SearchCollectors_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 54);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 15;
            label7.Text = "Країна";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 25);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 14;
            label8.Text = "Ім'я";
            // 
            // tbCountrySearchCollector
            // 
            tbCountrySearchCollector.Location = new Point(116, 51);
            tbCountrySearchCollector.Name = "tbCountrySearchCollector";
            tbCountrySearchCollector.Size = new Size(100, 23);
            tbCountrySearchCollector.TabIndex = 11;
            tbCountrySearchCollector.KeyPress += tbCountrySearchCollector_KeyPress;
            // 
            // tbNameSearchCollector
            // 
            tbNameSearchCollector.Location = new Point(116, 22);
            tbNameSearchCollector.Name = "tbNameSearchCollector";
            tbNameSearchCollector.Size = new Size(100, 23);
            tbNameSearchCollector.TabIndex = 10;
            tbNameSearchCollector.KeyPress += tbNameSearchCollector_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 726);
            Controls.Add(tabControl1);
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
