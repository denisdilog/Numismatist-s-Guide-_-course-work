using System.ComponentModel;

namespace CoinProgect {
    public partial class Form1 : Form {

        private DataManager dataManager;
        public Form1() {
            InitializeComponent();
            this.AcceptButton = btn_SearchCoins;
            dataManager = new DataManager();

            try {
                dataManager.LoadFromFile();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Помилка завантаження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridViewCoins.AutoGenerateColumns = false;
            dataGridViewCollectors.AutoGenerateColumns = false;
            dataGridViewCoins.DataSource = dataManager.Coins;
            dataGridViewCollectors.DataSource = dataManager.Collectors;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 0) this.AcceptButton = btn_SearchCoins;
            else this.AcceptButton = btn_SearchCollectors;
        }




        private void btn_AddCoin_Click(object sender, EventArgs e) {
            using (AddCoinForm addForm = new AddCoinForm()) {
                if (addForm.ShowDialog() == DialogResult.OK) {
                    dataManager.AddCoin(addForm.ResultCoin);
                }
            }
        }

        private void btn_DeleteCoin_Click(object sender, EventArgs e) {
            if (dataGridViewCoins.CurrentRow != null) {
                Coin selectedCoin = (Coin)dataGridViewCoins.CurrentRow.DataBoundItem;

                DialogResult result = MessageBox.Show($"Ви дійсно хочете видалити монету {selectedCoin.Denomination} ({selectedCoin.Year})?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    dataManager.DeleteCoin(selectedCoin);
                }
            } else {
                MessageBox.Show("Будь ласка, виберіть монету для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_EditCoin_Click(object sender, EventArgs e) {
            if (dataGridViewCoins.CurrentRow != null) {
                int index = dataGridViewCoins.CurrentRow.Index;

                Coin selectedCoin = (Coin)dataGridViewCoins.CurrentRow.DataBoundItem;
                using (AddCoinForm editCoin = new AddCoinForm(selectedCoin)) {
                    if (editCoin.ShowDialog() == DialogResult.OK) {
                        Coin updatedCoin = editCoin.ResultCoin;

                        selectedCoin.Country = updatedCoin.Country;
                        selectedCoin.Denomination = updatedCoin.Denomination;
                        selectedCoin.Year = updatedCoin.Year;
                        selectedCoin.Metal = updatedCoin.Metal;
                        selectedCoin.Mintage = updatedCoin.Mintage;
                        selectedCoin.Features = updatedCoin.Features;

                        dataManager.Coins.ResetItem(index);
                    }
                }
            } else {
                MessageBox.Show("Будь ласка, виберіть монету для редагування.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void btn_AddCollector_Click(object sender, EventArgs e) {
            using (AddCollectorForm addCollectorForm = new AddCollectorForm()) {
                if (addCollectorForm.ShowDialog() == DialogResult.OK) {
                    dataManager.AddCollector(addCollectorForm.ResultCollector);
                }
            }
        }

        private void btn_DeleteCollector_Click(object sender, EventArgs e) {
            if (dataGridViewCollectors.CurrentRow != null) {
                Collector selectedCollector = (Collector)dataGridViewCollectors.CurrentRow.DataBoundItem;

                DialogResult result = MessageBox.Show($"Ви дійсно хочете видалити колекціонера {selectedCollector.Name} ({selectedCollector.Country})?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    dataManager.DeleteCollector(selectedCollector);
                }
            } else {
                MessageBox.Show("Будь ласка, виберіть колекціонера для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_EditCollector_Click(object sender, EventArgs e) {
            if (dataGridViewCollectors.CurrentRow != null) {
                int index = dataGridViewCollectors.CurrentRow.Index;

                Collector selectedCollector = (Collector)dataGridViewCollectors.CurrentRow.DataBoundItem;
                using (AddCollectorForm editCollectorForm = new AddCollectorForm(selectedCollector)) {
                    if (editCollectorForm.ShowDialog() == DialogResult.OK) {
                        Collector updatedCollector = editCollectorForm.ResultCollector;

                        selectedCollector.Name = updatedCollector.Name;
                        selectedCollector.Country = updatedCollector.Country;
                        selectedCollector.ContactInfo = updatedCollector.ContactInfo;
                        selectedCollector.RareCoinsInfo = updatedCollector.RareCoinsInfo;
                        selectedCollector.HasOwnCollection = updatedCollector.HasOwnCollection;

                        dataManager.Collectors.ResetItem(index);
                    }
                }
            } else {
                MessageBox.Show("Будь ласка, виберіть колекціонера для редагування.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void btn_SearchCoins_Click(object sender, EventArgs e) {
            var filteredCoins = dataManager.Coins.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(tbCountrySearchCoin.Text)) {
                string searchCountry = tbCountrySearchCoin.Text.Trim().ToLower();
                filteredCoins = filteredCoins.Where(c => c.Country.ToLower().Contains(searchCountry));
            }
            if (!string.IsNullOrWhiteSpace(tbDenominationSearchCoin.Text)) {
                string searchDenomination = tbDenominationSearchCoin.Text.Trim().ToLower();
                filteredCoins = filteredCoins.Where(c => c.Denomination.ToLower().Contains(searchDenomination));
            }
            if (!string.IsNullOrWhiteSpace(tbYearSearchCoin.Text) && int.TryParse(tbYearSearchCoin.Text, out int searchYear)) {
                filteredCoins = filteredCoins.Where(c => c.Year == searchYear);
            }
            if (comboboxSearchCoin.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(comboboxSearchCoin.Text)) {
                string searchMetal = comboboxSearchCoin.Text.Trim().ToLower();
                filteredCoins = filteredCoins.Where(c => c.Metal.ToLower().Contains(searchMetal));
            }

            var resultList = filteredCoins.ToList();

            if (resultList.Count > 0) {
                dataGridViewCoins.DataSource = new BindingList<Coin>(resultList);
            } else {
                dataGridViewCoins.DataSource = new BindingList<Coin>();
                MessageBox.Show("За вашим запитом нічого не знайдено.", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrWhiteSpace(tbCountrySearchCoin.Text) &&
                string.IsNullOrWhiteSpace(tbDenominationSearchCoin.Text) &&
                string.IsNullOrWhiteSpace(tbYearSearchCoin.Text) &&
                string.IsNullOrWhiteSpace(comboboxSearchCoin.Text)) {
                dataGridViewCoins.DataSource = dataManager.Coins;
            }
        }





        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            dataManager.SaveToFile();
        }

        private void btn_SearchCollectors_Click(object sender, EventArgs e) {
            var filteredCollectors = dataManager.Collectors.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(tbNameSearchCollector.Text)) {
                string searchName = tbNameSearchCollector.Text.Trim().ToLower();
                filteredCollectors = filteredCollectors.Where(c => c.Name.ToLower().Contains(searchName));
            }
            if (!string.IsNullOrWhiteSpace(tbCountrySearchCollector.Text)) {
                string searchCountry = tbCountrySearchCollector.Text.Trim().ToLower();
                filteredCollectors = filteredCollectors.Where(c => c.Country.ToLower().Contains(searchCountry));
            }

            var resultList = filteredCollectors.ToList();

            if (resultList.Count > 0) {
                dataGridViewCollectors.DataSource = new BindingList<Collector>(resultList);
            } else {
                dataGridViewCollectors.DataSource = new BindingList<Collector>();
                MessageBox.Show("Колекціонерів за такими критеріями не знайдено.", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrWhiteSpace(tbNameSearchCollector.Text) &&
                string.IsNullOrWhiteSpace(tbCountrySearchCollector.Text)) {
                dataGridViewCollectors.DataSource = dataManager.Collectors;
            }
        }



        private void tbCountrySearchCoin_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-') {
                e.Handled = true;
            }
        }
        private void tbNameSearchCollector_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-') {
                e.Handled = true;
            }
        }
        private void tbCountrySearchCollector_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-') {
                e.Handled = true;
            }
        }



        private void tbYearSearchCoin_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}