namespace CoinProgect {
    partial class AddCollectorForm {
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
            btn_Cancelcollector = new Button();
            btn_OKcollector = new Button();
            label6 = new Label();
            tbRareCoinsCollector = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbContactInfoCollector = new TextBox();
            tbCountryCollector = new TextBox();
            tbNameCollector = new TextBox();
            checkboxOwnCollection = new CheckBox();
            SuspendLayout();
            // 
            // btn_Cancelcollector
            // 
            btn_Cancelcollector.Anchor = AnchorStyles.Bottom;
            btn_Cancelcollector.Cursor = Cursors.Hand;
            btn_Cancelcollector.DialogResult = DialogResult.Cancel;
            btn_Cancelcollector.Location = new Point(83, 326);
            btn_Cancelcollector.Margin = new Padding(3, 4, 3, 4);
            btn_Cancelcollector.Name = "btn_Cancelcollector";
            btn_Cancelcollector.Size = new Size(97, 40);
            btn_Cancelcollector.TabIndex = 36;
            btn_Cancelcollector.Text = "Cancel";
            btn_Cancelcollector.UseVisualStyleBackColor = true;
            btn_Cancelcollector.Click += btn_Cancelcollector_Click;
            // 
            // btn_OKcollector
            // 
            btn_OKcollector.Anchor = AnchorStyles.Bottom;
            btn_OKcollector.Cursor = Cursors.Hand;
            btn_OKcollector.Location = new Point(234, 326);
            btn_OKcollector.Margin = new Padding(3, 4, 3, 4);
            btn_OKcollector.Name = "btn_OKcollector";
            btn_OKcollector.Size = new Size(97, 40);
            btn_OKcollector.TabIndex = 35;
            btn_OKcollector.Text = "OK";
            btn_OKcollector.UseVisualStyleBackColor = true;
            btn_OKcollector.Click += btn_OKcollector_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(26, 152);
            label6.Name = "label6";
            label6.Size = new Size(136, 18);
            label6.TabIndex = 33;
            label6.Text = "Рідкісні монети:";
            // 
            // tbRareCoinsCollector
            // 
            tbRareCoinsCollector.Anchor = AnchorStyles.Top;
            tbRareCoinsCollector.Enabled = false;
            tbRareCoinsCollector.Font = new Font("Consolas", 9F);
            tbRareCoinsCollector.Location = new Point(169, 148);
            tbRareCoinsCollector.Margin = new Padding(3, 4, 3, 4);
            tbRareCoinsCollector.Name = "tbRareCoinsCollector";
            tbRareCoinsCollector.Size = new Size(211, 22);
            tbRareCoinsCollector.TabIndex = 31;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(26, 114);
            label3.Name = "label3";
            label3.Size = new Size(128, 18);
            label3.TabIndex = 29;
            label3.Text = "Контактні дані:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 28;
            label2.Text = "Країна:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 27;
            label1.Text = "Ім'я:";
            // 
            // tbContactInfoCollector
            // 
            tbContactInfoCollector.Anchor = AnchorStyles.Top;
            tbContactInfoCollector.Location = new Point(169, 111);
            tbContactInfoCollector.Margin = new Padding(3, 4, 3, 4);
            tbContactInfoCollector.Name = "tbContactInfoCollector";
            tbContactInfoCollector.Size = new Size(211, 25);
            tbContactInfoCollector.TabIndex = 25;
            // 
            // tbCountryCollector
            // 
            tbCountryCollector.Anchor = AnchorStyles.Top;
            tbCountryCollector.Location = new Point(169, 73);
            tbCountryCollector.Margin = new Padding(3, 4, 3, 4);
            tbCountryCollector.Name = "tbCountryCollector";
            tbCountryCollector.Size = new Size(211, 25);
            tbCountryCollector.TabIndex = 24;
            tbCountryCollector.KeyPress += tbCountryCollector_KeyPress;
            // 
            // tbNameCollector
            // 
            tbNameCollector.Anchor = AnchorStyles.Top;
            tbNameCollector.Location = new Point(169, 36);
            tbNameCollector.Margin = new Padding(3, 4, 3, 4);
            tbNameCollector.Name = "tbNameCollector";
            tbNameCollector.Size = new Size(211, 25);
            tbNameCollector.TabIndex = 23;
            tbNameCollector.KeyPress += tbNameCollector_KeyPress;
            // 
            // checkboxOwnCollection
            // 
            checkboxOwnCollection.Anchor = AnchorStyles.Top;
            checkboxOwnCollection.AutoSize = true;
            checkboxOwnCollection.Cursor = Cursors.Hand;
            checkboxOwnCollection.Location = new Point(26, 199);
            checkboxOwnCollection.Margin = new Padding(3, 4, 3, 4);
            checkboxOwnCollection.Name = "checkboxOwnCollection";
            checkboxOwnCollection.Size = new Size(179, 22);
            checkboxOwnCollection.TabIndex = 38;
            checkboxOwnCollection.Text = "Має власну колекцію";
            checkboxOwnCollection.UseVisualStyleBackColor = true;
            checkboxOwnCollection.CheckedChanged += checkboxOwnCollection_CheckedChanged;
            // 
            // AddCollectorForm
            // 
            AcceptButton = btn_OKcollector;
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            CancelButton = btn_Cancelcollector;
            ClientSize = new Size(415, 388);
            Controls.Add(checkboxOwnCollection);
            Controls.Add(btn_Cancelcollector);
            Controls.Add(btn_OKcollector);
            Controls.Add(label6);
            Controls.Add(tbRareCoinsCollector);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbContactInfoCollector);
            Controls.Add(tbCountryCollector);
            Controls.Add(tbNameCollector);
            Font = new Font("Consolas", 11F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCollectorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Додавання колекціонера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancelcollector;
        private Button btn_OKcollector;
        private Label label6;
        private TextBox tbRareCoinsCollector;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbContactInfoCollector;
        private TextBox tbCountryCollector;
        private TextBox tbNameCollector;
        private CheckBox checkboxOwnCollection;
    }
}