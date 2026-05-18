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
            btn_Cancelcollector.DialogResult = DialogResult.Cancel;
            btn_Cancelcollector.Location = new Point(54, 261);
            btn_Cancelcollector.Name = "btn_Cancelcollector";
            btn_Cancelcollector.Size = new Size(85, 33);
            btn_Cancelcollector.TabIndex = 36;
            btn_Cancelcollector.Text = "Cancel";
            btn_Cancelcollector.UseVisualStyleBackColor = true;
            btn_Cancelcollector.Click += btn_Cancelcollector_Click;
            // 
            // btn_OKcollector
            // 
            btn_OKcollector.Anchor = AnchorStyles.Bottom;
            btn_OKcollector.Location = new Point(192, 261);
            btn_OKcollector.Name = "btn_OKcollector";
            btn_OKcollector.Size = new Size(85, 33);
            btn_OKcollector.TabIndex = 35;
            btn_OKcollector.Text = "OK";
            btn_OKcollector.UseVisualStyleBackColor = true;
            btn_OKcollector.Click += btn_OKcollector_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(18, 126);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 33;
            label6.Text = "Рідкісні монети:";
            // 
            // tbRareCoinsCollector
            // 
            tbRareCoinsCollector.Anchor = AnchorStyles.Top;
            tbRareCoinsCollector.Enabled = false;
            tbRareCoinsCollector.Location = new Point(123, 123);
            tbRareCoinsCollector.Name = "tbRareCoinsCollector";
            tbRareCoinsCollector.Size = new Size(185, 23);
            tbRareCoinsCollector.TabIndex = 31;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(18, 95);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 29;
            label3.Text = "Контактні дані:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(18, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 28;
            label2.Text = "Країна:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(18, 33);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 27;
            label1.Text = "Ім'я:";
            // 
            // tbContactInfoCollector
            // 
            tbContactInfoCollector.Anchor = AnchorStyles.Top;
            tbContactInfoCollector.Location = new Point(123, 92);
            tbContactInfoCollector.Name = "tbContactInfoCollector";
            tbContactInfoCollector.Size = new Size(185, 23);
            tbContactInfoCollector.TabIndex = 25;
            // 
            // tbCountryCollector
            // 
            tbCountryCollector.Anchor = AnchorStyles.Top;
            tbCountryCollector.Location = new Point(123, 61);
            tbCountryCollector.Name = "tbCountryCollector";
            tbCountryCollector.Size = new Size(185, 23);
            tbCountryCollector.TabIndex = 24;
            // 
            // tbNameCollector
            // 
            tbNameCollector.Anchor = AnchorStyles.Top;
            tbNameCollector.Location = new Point(123, 30);
            tbNameCollector.Name = "tbNameCollector";
            tbNameCollector.Size = new Size(185, 23);
            tbNameCollector.TabIndex = 23;
            // 
            // checkboxOwnCollection
            // 
            checkboxOwnCollection.Anchor = AnchorStyles.Top;
            checkboxOwnCollection.AutoSize = true;
            checkboxOwnCollection.Location = new Point(18, 166);
            checkboxOwnCollection.Name = "checkboxOwnCollection";
            checkboxOwnCollection.Size = new Size(145, 19);
            checkboxOwnCollection.TabIndex = 38;
            checkboxOwnCollection.Text = "Має власну колекцію";
            checkboxOwnCollection.UseVisualStyleBackColor = true;
            checkboxOwnCollection.CheckedChanged += checkboxOwnCollection_CheckedChanged;
            // 
            // AddCollectorForm
            // 
            AcceptButton = btn_OKcollector;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancelcollector;
            ClientSize = new Size(332, 324);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
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