using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes_KPL_Program.Service;
using Tubes_KPL_Program.Model;
using Tubes_KPL_Libraries.Validation;

namespace Tubes_KPL_GUI8._0
{
    public partial class Charms : Form
    {
        private CharmClient _charmClient;
        private int _selectedCharmId = -1;

        public Charms()
        {
            InitializeComponent();
            _charmClient = new CharmClient();
            LoadCharmsToDataGridView();
            dataGridViewCharms.AutoGenerateColumns = false;
        }

        private async void Charms_Load(object sender, EventArgs e)
        {
            await LoadCharmsToDataGridView();
        }

        // Metode untuk memuat semua charm dan menampilkannya di DataGridView
        private async Task LoadCharmsToDataGridView()
        {
            try
            {
                List<Charm> charms = await _charmClient.GetAllCharmsAsync(); // Ambil data dari API
                if (charms != null)
                {
                    dataGridViewCharms.DataSource = charms;
                }
                else
                {
                    MessageBox.Show("Failed to load charms from API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewCharms.DataSource = null; // Kosongkan jika gagal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading charms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler saat seleksi di DataGridView berubah
        private void dataGridViewCharms_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCharms_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewCharms.SelectedRows.Count > 0)
            {
                Charm selectedCharm = dataGridViewCharms.SelectedRows[0].DataBoundItem as Charm;
                if (selectedCharm != null)
                {
                    _selectedCharmId = selectedCharm.id;
                    textBoxName.Text = selectedCharm.name;
                    textBoxPrice.Text = selectedCharm.price.ToString();
                    textBoxEffect.Text = selectedCharm.effect;
                }
            }
            else
            {
                ClearInputFields();
            }
        }

        // Metode untuk mengosongkan semua bidang input dan reset ID terpilih
        private void ClearInputFields()
        {
            _selectedCharmId = -1;
            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxEffect.Clear();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            int price;
            string effect = textBoxEffect.Text.Trim();

            // Validasi input
            string validationMessage = ValidateString.ValidateGUIString(name, "Charm Name");
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            validationMessage = ValidateInt.ValidateGUIPositiveInteger(textBoxPrice.Text, "Charm Price", out price);
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            validationMessage = ValidateString.ValidateGUIString(effect, "Charm Effect");
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Charm newCharm = new Charm
            {
                name = name,
                price = price,
                effect = effect
            };

            try
            {
                bool success = await _charmClient.AddCharmAsync(newCharm);
                if (success)
                {
                    MessageBox.Show("Charm added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCharmsToDataGridView(); // Muat ulang data setelah penambahan
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add charm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding charm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonUpd_Click(object sender, EventArgs e)
        {
            if (_selectedCharmId == -1)
            {
                MessageBox.Show("Please select a charm to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBoxName.Text.Trim();
            int price;
            string effect = textBoxEffect.Text.Trim();

            // Validasi input
            string validationMessage = ValidateString.ValidateGUIString(name, "Charm Name");
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            validationMessage = ValidateInt.ValidateGUIPositiveInteger(textBoxPrice.Text, "Charm Price", out price);
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            validationMessage = ValidateString.ValidateGUIString(effect, "Charm Effect");
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Charm updatedCharm = new Charm
            {
                id = _selectedCharmId,
                name = name,
                price = price,
                effect = effect
            };

            try
            {
                bool success = await _charmClient.UpdateCharmAsync(_selectedCharmId, updatedCharm);
                if (success)
                {
                    MessageBox.Show("Charm updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCharmsToDataGridView();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update charm. Charm might not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating charm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDel_Click(object sender, EventArgs e)
        {
            if (_selectedCharmId == -1)
            {
                MessageBox.Show("Please select a charm to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete charm with ID {_selectedCharmId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool success = await _charmClient.DeleteCharmAsync(_selectedCharmId);
                    if (success)
                    {
                        MessageBox.Show("Charm deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadCharmsToDataGridView(); // Muat ulang data setelah penghapusan
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete charm. Charm might not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting charm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
