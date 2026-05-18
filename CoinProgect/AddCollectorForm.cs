using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinProgect {
    public partial class AddCollectorForm : Form {

        public Collector ResultCollector { get; private set; }
        public AddCollectorForm() {
            InitializeComponent();
        }

        public AddCollectorForm(Collector collectorToEdit) : this() {
            this.Text = "Редагування колекціонера";

            tbNameCollector.Text = collectorToEdit.Name;
            tbCountryCollector.Text = collectorToEdit.Country;
            tbContactInfoCollector.Text = collectorToEdit.ContactInfo;
            checkboxOwnCollection.Checked = collectorToEdit.HasOwnCollection;

            if (collectorToEdit.RareCoinsInfo == "-") tbRareCoinsCollector.Text = "";
            else tbRareCoinsCollector.Text = collectorToEdit.RareCoinsInfo;
        }

        private bool IsDataValid(out string message) {
            message = "";

            if (string.IsNullOrWhiteSpace(tbNameCollector.Text)) {
                message = "Поле 'Ім'я' не може бути порожнім.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbCountryCollector.Text)) {
                message = "Поле 'Країна' не може бути порожнім.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbContactInfoCollector.Text)) {
                message = "Поле 'Контактні дані' не може бути порожнім.";
                return false;
            }

            return true;
        }

        private void btn_OKcollector_Click(object sender, EventArgs e) {
            if (!IsDataValid(out string errorMessage)) {
                MessageBox.Show(errorMessage, "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string finalRareCoins;
            if (string.IsNullOrWhiteSpace(tbRareCoinsCollector.Text)) finalRareCoins = "-";
            else finalRareCoins = tbRareCoinsCollector.Text.Trim();
            ResultCollector = new Collector {
                Name = tbNameCollector.Text.Trim(),
                Country = tbCountryCollector.Text.Trim(),
                ContactInfo = tbContactInfoCollector.Text.Trim(),
                RareCoinsInfo = finalRareCoins,
                HasOwnCollection = checkboxOwnCollection.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancelcollector_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkboxOwnCollection_CheckedChanged(object sender, EventArgs e) {
            tbRareCoinsCollector.Enabled = checkboxOwnCollection.Checked;
        }
    }
}