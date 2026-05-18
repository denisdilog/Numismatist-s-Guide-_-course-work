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
            label4.Location = new Point(32, 149);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 16;
            label4.Text = "Метал:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(32, 112);
            label3.Name = "label3";
            label3.Size = new Size(40, 18);
            label3.TabIndex = 15;
            label3.Text = "Рік:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(32, 75);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 14;
            label2.Text = "Номінал:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 13;
            label1.Text = "Країна:";
            // 
            // comboboxMetalCoin
            // 
            comboboxMetalCoin.Anchor = AnchorStyles.Top;
            comboboxMetalCoin.Cursor = Cursors.Hand;
            comboboxMetalCoin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxMetalCoin.Font = new Font("Consolas", 9F);
            comboboxMetalCoin.FormattingEnabled = true;
            comboboxMetalCoin.Items.AddRange(new object[] { "", "Золото", "Срібло", "Платина", "Паладій", "Мідь", "Бронза", "Сталь", "Алюміній", "Мельхіор" });
            comboboxMetalCoin.Location = new Point(141, 145);
            comboboxMetalCoin.Margin = new Padding(3, 4, 3, 4);
            comboboxMetalCoin.Name = "comboboxMetalCoin";
            comboboxMetalCoin.Size = new Size(114, 22);
            comboboxMetalCoin.TabIndex = 12;
            // 
            // tbYearCoin
            // 
            tbYearCoin.Anchor = AnchorStyles.Top;
            tbYearCoin.Location = new Point(141, 108);
            tbYearCoin.Margin = new Padding(3, 4, 3, 4);
            tbYearCoin.MaxLength = 4;
            tbYearCoin.Name = "tbYearCoin";
            tbYearCoin.Size = new Size(114, 25);
            tbYearCoin.TabIndex = 11;
            tbYearCoin.KeyPress += tbYearCoin_KeyPress;
            // 
            // tbDenominationCoin
            // 
            tbDenominationCoin.Anchor = AnchorStyles.Top;
            tbDenominationCoin.Location = new Point(141, 71);
            tbDenominationCoin.Margin = new Padding(3, 4, 3, 4);
            tbDenominationCoin.Name = "tbDenominationCoin";
            tbDenominationCoin.Size = new Size(114, 25);
            tbDenominationCoin.TabIndex = 10;
            // 
            // tbCountryCoin
            // 
            tbCountryCoin.Anchor = AnchorStyles.Top;
            tbCountryCoin.Location = new Point(141, 33);
            tbCountryCoin.Margin = new Padding(3, 4, 3, 4);
            tbCountryCoin.Name = "tbCountryCoin";
            tbCountryCoin.Size = new Size(114, 25);
            tbCountryCoin.TabIndex = 9;
            tbCountryCoin.KeyPress += tbCountryCoin_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(32, 224);
            label5.Name = "label5";
            label5.Size = new Size(104, 18);
            label5.TabIndex = 20;
            label5.Text = "Особливості:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(32, 186);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 19;
            label6.Text = "Кількість:";
            // 
            // tbFeaturesCoin
            // 
            tbFeaturesCoin.Anchor = AnchorStyles.Top;
            tbFeaturesCoin.Location = new Point(141, 220);
            tbFeaturesCoin.Margin = new Padding(3, 4, 3, 4);
            tbFeaturesCoin.Name = "tbFeaturesCoin";
            tbFeaturesCoin.Size = new Size(114, 25);
            tbFeaturesCoin.TabIndex = 18;
            // 
            // tbMintageCoin
            // 
            tbMintageCoin.Anchor = AnchorStyles.Top;
            tbMintageCoin.Location = new Point(141, 183);
            tbMintageCoin.Margin = new Padding(3, 4, 3, 4);
            tbMintageCoin.Name = "tbMintageCoin";
            tbMintageCoin.Size = new Size(114, 25);
            tbMintageCoin.TabIndex = 17;
            tbMintageCoin.KeyPress += tbMintageCoin_KeyPress;
            // 
            // btn_OKcoin
            // 
            btn_OKcoin.Anchor = AnchorStyles.Bottom;
            btn_OKcoin.Cursor = Cursors.Hand;
            btn_OKcoin.Location = new Point(171, 286);
            btn_OKcoin.Margin = new Padding(3, 4, 3, 4);
            btn_OKcoin.Name = "btn_OKcoin";
            btn_OKcoin.Size = new Size(97, 40);
            btn_OKcoin.TabIndex = 21;
            btn_OKcoin.Text = "OK";
            btn_OKcoin.UseVisualStyleBackColor = true;
            btn_OKcoin.Click += btn_OKcoin_Click;
            // 
            // btn_Cancelcoin
            // 
            btn_Cancelcoin.Anchor = AnchorStyles.Bottom;
            btn_Cancelcoin.Cursor = Cursors.Hand;
            btn_Cancelcoin.DialogResult = DialogResult.Cancel;
            btn_Cancelcoin.Location = new Point(24, 286);
            btn_Cancelcoin.Margin = new Padding(3, 4, 3, 4);
            btn_Cancelcoin.Name = "btn_Cancelcoin";
            btn_Cancelcoin.Size = new Size(97, 40);
            btn_Cancelcoin.TabIndex = 22;
            btn_Cancelcoin.Text = "Cancel";
            btn_Cancelcoin.UseVisualStyleBackColor = true;
            // 
            // AddCoinForm
            // 
            AcceptButton = btn_OKcoin;
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            CancelButton = btn_Cancelcoin;
            ClientSize = new Size(292, 350);
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
            Font = new Font("Consolas", 11F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
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