using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes_KPL_Program.Service;
using Tubes_KPL_Program.Model;
using Tubes_KPL_Libraries.Validation; // untuk validasi input

namespace Tubes_KPL_GUI8._0
{
    public partial class Monsters : Form
    {
        private MonsterClient _monsterClient;
        private int _selectedMonsterId = -1;

        public Monsters()
        {
            InitializeComponent();
            _monsterClient = new MonsterClient();
            LoadMonstersToDataGridView();
            dataGridViewMonsters.AutoGenerateColumns = false;
        }

        private async void Monsters_Load(object sender, EventArgs e)
        {
            await LoadMonstersToDataGridView();
        }

        // Metode untuk memuat semua monster dan menampilkannya di DataGridView
        private async Task LoadMonstersToDataGridView()
        {
            try
            {
                List<Monster> monsters = await _monsterClient.GetAllMonstersAsync();
                if (monsters != null)
                {
                    dataGridViewMonsters.DataSource = monsters;
                }
                else
                {
                    MessageBox.Show("Failed to load monsters from API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewMonsters.DataSource = null; // Kosongkan jika gagal
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

        private void dataGridViewMonsters_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMonsters.SelectedRows.Count > 0)
            {
                // Ambil data dari baris yang dipilih
                Monster selectedMonster = dataGridViewMonsters.SelectedRows[0].DataBoundItem as Monster;
                if (selectedMonster != null)
                {
                    _selectedMonsterId = selectedMonster.id;
                    // Tampilkan data ke textbox untuk diedit
                    textBoxName.Text = selectedMonster.name;
                    textBoxHealth.Text = selectedMonster.health.ToString();
                    textBoxRace.Text = selectedMonster.race;
                    textBoxDamage.Text = selectedMonster.damage.ToString();
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
            _selectedMonsterId = -1;
            textBoxName.Clear();
            textBoxHealth.Clear();
            textBoxRace.Clear();
            textBoxDamage.Clear();

            labelName.Text = "Name : ";
            labelHealth.Text = "Health : ";
            labelRace.Text = "Race : ";
            labelDamage.Text = "Damage : ";
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int health;
            string race = textBoxRace.Text;
            int damage;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(race) ||
                !int.TryParse(textBoxHealth.Text, out health) || health <= 0 ||
                !int.TryParse(textBoxDamage.Text, out damage) || damage <= 0)
            {
                MessageBox.Show("Please fill all fields correctly (Health and Damage must be positive numbers).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Monster newMonster = new Monster
            {
                name = name,
                health = health,
                race = race,
                damage = damage
            };

            try
            {
                bool success = await _monsterClient.AddMonsterAsync(newMonster);
                if (success)
                {
                    MessageBox.Show("Monster added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadMonstersToDataGridView(); // Muat ulang data setelah penambahan
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add monster.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding monster: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonUpd_Click(object sender, EventArgs e)
        {
            if (_selectedMonsterId == -1)
            {
                MessageBox.Show("Please select a monster to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBoxName.Text;
            int health;
            string race = textBoxRace.Text;
            int damage;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(race) ||
                !int.TryParse(textBoxHealth.Text, out health) || health <= 0 ||
                !int.TryParse(textBoxDamage.Text, out damage) || damage <= 0)
            {
                MessageBox.Show("Please fill all fields correctly (Health and Damage must be positive numbers).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Monster updatedMonster = new Monster
            {
                id = _selectedMonsterId, // Pastikan ID yang benar digunakan
                name = name,
                health = health,
                race = race,
                damage = damage
            };

            try
            {
                bool success = await _monsterClient.UpdateMonsterAsync(_selectedMonsterId, updatedMonster);
                if (success)
                {
                    MessageBox.Show("Monster updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadMonstersToDataGridView(); // Muat ulang data setelah pembaruan
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update monster. Monster might not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating monster: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDel_Click(object sender, EventArgs e)
        {
            if (_selectedMonsterId == -1)
            {
                MessageBox.Show("Please select a monster to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete monster with ID {_selectedMonsterId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool success = await _monsterClient.DeleteMonsterAsync(_selectedMonsterId);
                    if (success)
                    {
                        MessageBox.Show("Monster deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadMonstersToDataGridView(); // Muat ulang data setelah penghapusan
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete monster. Monster might not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting monster: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
