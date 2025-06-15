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
using Tubes_KPL_Libraries.Validation; // untuk validasi input

namespace Tubes_KPL_GUI8._0
{
    public partial class Weapons : Form
    {
        private WeaponClient _weaponClient;
        private int _selectedWeaponId = -1;

        public Weapons()
        {
            InitializeComponent();
            _weaponClient = new WeaponClient();
            LoadWeaponsToDataGridView();
            dataGridViewWeapons.AutoGenerateColumns = false;
        }
        private async void Weapons_Load(object sender, EventArgs e)
        {
            await LoadWeaponsToDataGridView();
        }

        // Metode untuk memuat semua monster dan menampilkannya di DataGridView
        private async Task LoadWeaponsToDataGridView()
        {
            try
            {
                List<Weapon> weapons = await _weaponClient.GetAllWeaponsAsync();
                if (weapons != null)
                {
                    dataGridViewWeapons.DataSource = weapons;
                }
                else
                {
                    MessageBox.Show("Failed to load monsters from API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewWeapons.DataSource = null; // Kosongkan jika gagal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading monsters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewWeapons_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewWeapons.SelectedRows.Count > 0)
            {
                // Ambil data dari baris yang dipilih
                Weapon selectedWeapon = dataGridViewWeapons.SelectedRows[0].DataBoundItem as Weapon;
                if (selectedWeapon != null)
                {
                    _selectedWeaponId = selectedWeapon.id;
                    // Tampilkan data ke textbox untuk diedit
                    textBoxName.Text = selectedWeapon.name;
                    textBoxType.Text = selectedWeapon.type;
                    textBoxPrice.Text = selectedWeapon.price.ToString();
                    textBoxDamage.Text = selectedWeapon.baseDamage.ToString();
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
            _selectedWeaponId = -1;
            textBoxName.Clear();
            textBoxType.Clear();
            textBoxPrice.Clear();
            textBoxDamage.Clear();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string type = textBoxType.Text.Trim();
            int price;
            int baseDamage;

            // Validasi Name
            string validationMessage = ValidateString.ValidateGUIString(name, "Weapon Name");
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi Type
            validationMessage = ValidateString.ValidateGUIString(type, "Weapon Type");
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi Price
            validationMessage = ValidateInt.ValidateGUIPositiveInteger(textBoxPrice.Text, "Weapon Price", out price);
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi Base Damage
            validationMessage = ValidateInt.ValidateGUIPositiveInteger(textBoxDamage.Text, "Weapon Damage", out baseDamage);
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Weapon newWeapon = new Weapon
            {
                name = name,
                type = type,
                price = price,
                baseDamage = baseDamage
            };

            try
            {
                bool success = await _weaponClient.AddWeaponAsync(newWeapon);
                if (success)
                {
                    MessageBox.Show("Weapon added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadWeaponsToDataGridView(); // Muat ulang data setelah penambahan
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add weapon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding weapon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonUpd_Click(object sender, EventArgs e)
        {
            if (_selectedWeaponId == -1)
            {
                MessageBox.Show("Please select a weapon to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBoxName.Text.Trim();
            string type = textBoxType.Text.Trim();
            int price;
            int baseDamage;

            // Validasi Name
            string validationMessage = ValidateString.ValidateGUIString(name, "Weapon Name");
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi Type
            validationMessage = ValidateString.ValidateGUIString(type, "Weapon Type");
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi Price
            validationMessage = ValidateInt.ValidateGUIPositiveInteger(textBoxPrice.Text, "Weapon Price", out price);
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi Base Damage
            validationMessage = ValidateInt.ValidateGUIPositiveInteger(textBoxDamage.Text, "Weapon Damage", out baseDamage);
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Weapon updatedWeapon = new Weapon
            {
                id = _selectedWeaponId,
                name = name,
                type = type,
                price = price,
                baseDamage = baseDamage
            };

            try
            {
                bool success = await _weaponClient.UpdateWeaponAsync(_selectedWeaponId, updatedWeapon);
                if (success)
                {
                    MessageBox.Show("Weapon updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadWeaponsToDataGridView(); // Muat ulang data setelah pembaruan
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update weapon. Weapon might not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating weapon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDel_Click(object sender, EventArgs e)
        {
            if (_selectedWeaponId == -1)
            {
                MessageBox.Show("Please select a weapon to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete weapon with ID {_selectedWeaponId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool success = await _weaponClient.DeleteWeaponAsync(_selectedWeaponId);
                    if (success)
                    {
                        MessageBox.Show("Weapon deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadWeaponsToDataGridView(); // Muat ulang data setelah penghapusan
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete weapon. Weapon might not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting weapon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
