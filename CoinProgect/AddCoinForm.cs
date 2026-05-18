using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Діалогова форма, призначена для введення, валідації та редагування 
/// параметрів об'єкта типу <see cref="Coin"/>.
/// </summary>
namespace CoinProgect {
    public partial class AddCoinForm : Form {

        public Coin ResultCoin { get; private set; }
        public AddCoinForm() {
            InitializeComponent();
        }

        public AddCoinForm(Coin coinToEdit) : this() {
            this.Text = "Редагування монети";

            tbCountryCoin.Text = coinToEdit.Country;
            tbDenominationCoin.Text = coinToEdit.Denomination;
            tbYearCoin.Text = coinToEdit.Year.ToString();
            comboboxMetalCoin.Text = coinToEdit.Metal;
            tbMintageCoin.Text = coinToEdit.Mintage.ToString();

            if (coinToEdit.Features == "-") tbFeaturesCoin.Text = "";
            else tbFeaturesCoin.Text = coinToEdit.Features;
        }

        private bool IsDataValid(out string message) {
            message = "";

            if (string.IsNullOrWhiteSpace(tbCountryCoin.Text)) {
                message = "Поле 'Країна' не може бути порожнім.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbDenominationCoin.Text)) {
                message = "Поле 'Номінал' не може бути порожнім.";
                return false;
            }

            if (!int.TryParse(tbYearCoin.Text, out int year) || year < 1000 || year > DateTime.Now.Year) {
                message = $"Рік має бути числом у діапазоні від 1000 до {DateTime.Now.Year}.";
                return false;
            }

            if (comboboxMetalCoin.SelectedIndex == -1) {
                message = "Будь ласка, виберіть матеріал монети зі списку.";
                return false;
            }

            if (!long.TryParse(tbMintageCoin.Text, out long mintage) || mintage < 0) {
                message = "Тираж має бути додатнім числом.";
                return false;
            }

            return true;
        }

        private void btn_OKcoin_Click(object sender, EventArgs e) {
            if (!IsDataValid(out string errorMessage)) {
                MessageBox.Show(errorMessage, "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string finalFeatures;
            if (string.IsNullOrWhiteSpace(tbFeaturesCoin.Text)) finalFeatures = "-";
            else finalFeatures = tbFeaturesCoin.Text.Trim();
            ResultCoin = new Coin {
                Country = tbCountryCoin.Text.Trim(),
                Denomination = tbDenominationCoin.Text.Trim(),
                Year = int.Parse(tbYearCoin.Text),
                Metal = comboboxMetalCoin.Text,
                Mintage = long.Parse(tbMintageCoin.Text),
                Features = finalFeatures
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }





        private void tbCountryCoin_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-') {
                e.Handled = true;
            }
        }



        private void tbYearCoin_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void tbMintageCoin_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}