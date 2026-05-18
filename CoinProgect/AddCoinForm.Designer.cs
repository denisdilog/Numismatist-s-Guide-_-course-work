namespace CoinProgect {
    partial class AddCoinForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboboxMetalCoin = new ComboBox();
            tbYearCoin = new TextBox();
            tbDenominationCoin = new TextBox();
            tbCountryCoin = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbFeaturesCoin = new TextBox();
            tbMintageCoin = new TextBox();
            btn_OKcoin = new Button();
            btn_Cancelcoin = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(38, 124);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 16;
            label4.Text = "Метал";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(38, 93);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 15;
            label3.Text = "Рік";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(38, 62);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 14;
            label2.Text = "Номінал";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 13;
            label1.Text = "Країна";
            // 
            // comboboxMetalCoin
            // 
            comboboxMetalCoin.Anchor = AnchorStyles.Top;
            comboboxMetalCoin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxMetalCoin.FormattingEnabled = true;
            comboboxMetalCoin.Items.AddRange(new object[] { "", "Золото", "Срібло", "Платина", "Паладій", "Мідь", "Бронза", "Сталь", "Алюміній", "Мельхіор" });
            comboboxMetalCoin.Location = new Point(127, 121);
            comboboxMetalCoin.Name = "comboboxMetalCoin";
            comboboxMetalCoin.Size = new Size(100, 23);
            comboboxMetalCoin.TabIndex = 12;
            // 
            // tbYearCoin
            // 
            tbYearCoin.Anchor = AnchorStyles.Top;
            tbYearCoin.Location = new Point(127, 90);
            tbYearCoin.MaxLength = 4;
            tbYearCoin.Name = "tbYearCoin";
            tbYearCoin.Size = new Size(100, 23);
            tbYearCoin.TabIndex = 11;
            tbYearCoin.KeyPress += tbYearCoin_KeyPress;
            // 
            // tbDenominationCoin
            // 
            tbDenominationCoin.Anchor = AnchorStyles.Top;
            tbDenominationCoin.Location = new Point(127, 59);
            tbDenominationCoin.Name = "tbDenominationCoin";
            tbDenominationCoin.Size = new Size(100, 23);
            tbDenominationCoin.TabIndex = 10;
            // 
            // tbCountryCoin
            // 
            tbCountryCoin.Anchor = AnchorStyles.Top;
            tbCountryCoin.Location = new Point(127, 28);
            tbCountryCoin.Name = "tbCountryCoin";
            tbCountryCoin.Size = new Size(100, 23);
            tbCountryCoin.TabIndex = 9;
            tbCountryCoin.KeyPress += tbCountryCoin_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(38, 186);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 20;
            label5.Text = "Особливості";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(38, 155);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 19;
            label6.Text = "Кількість";
            // 
            // tbFeaturesCoin
            // 
            tbFeaturesCoin.Anchor = AnchorStyles.Top;
            tbFeaturesCoin.Location = new Point(127, 183);
            tbFeaturesCoin.Name = "tbFeaturesCoin";
            tbFeaturesCoin.Size = new Size(100, 23);
            tbFeaturesCoin.TabIndex = 18;
            // 
            // tbMintageCoin
            // 
            tbMintageCoin.Anchor = AnchorStyles.Top;
            tbMintageCoin.Location = new Point(127, 152);
            tbMintageCoin.Name = "tbMintageCoin";
            tbMintageCoin.Size = new Size(100, 23);
            tbMintageCoin.TabIndex = 17;
            tbMintageCoin.KeyPress += tbMintageCoin_KeyPress;
            // 
            // btn_OKcoin
            // 
            btn_OKcoin.Anchor = AnchorStyles.Bottom;
            btn_OKcoin.Location = new Point(161, 259);
            btn_OKcoin.Name = "btn_OKcoin";
            btn_OKcoin.Size = new Size(85, 33);
            btn_OKcoin.TabIndex = 21;
            btn_OKcoin.Text = "OK";
            btn_OKcoin.UseVisualStyleBackColor = true;
            btn_OKcoin.Click += btn_OKcoin_Click;
            // 
            // btn_Cancelcoin
            // 
            btn_Cancelcoin.Anchor = AnchorStyles.Bottom;
            btn_Cancelcoin.DialogResult = DialogResult.Cancel;
            btn_Cancelcoin.Location = new Point(23, 259);
            btn_Cancelcoin.Name = "btn_Cancelcoin";
            btn_Cancelcoin.Size = new Size(85, 33);
            btn_Cancelcoin.TabIndex = 22;
            btn_Cancelcoin.Text = "Cancel";
            btn_Cancelcoin.UseVisualStyleBackColor = true;
            // 
            // AddCoinForm
            // 
            AcceptButton = btn_OKcoin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancelcoin;
            ClientSize = new Size(271, 324);
            Controls.Add(btn_Cancelcoin);
            Controls.Add(btn_OKcoin);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(tbFeaturesCoin);
            Controls.Add(tbMintageCoin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboboxMetalCoin);
            Controls.Add(tbYearCoin);
            Controls.Add(tbDenominationCoin);
            Controls.Add(tbCountryCoin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCoinForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Додавання монети";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboboxMetalCoin;
        private TextBox tbYearCoin;
        private TextBox tbDenominationCoin;
        private TextBox tbCountryCoin;
        private Label label5;
        private Label label6;
        private TextBox tbFeaturesCoin;
        private TextBox tbMintageCoin;
        private Button btn_OKcoin;
        private Button btn_Cancelcoin;
    }
}