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

namespace Tubes_KPL_GUI8._0
{
    public partial class Monsters : Form
    {
        private MonsterClient _monsterClient;

        public Monsters()
        {
            InitializeComponent();
            _monsterClient = new MonsterClient();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private async void buttonGoblin_Click(object sender, EventArgs e)
        {
            try
            {
                // ID Goblin dari data/monster.json adalah 1
                int goblinId = 1;
                Monster goblin = await _monsterClient.GetMonsterByIdAsync(goblinId);

                if (goblin != null)
                {
                    labelName.Text = $"Name : {goblin.name}";
                    labelHealth.Text = $"Health : {goblin.health}";
                    labelRace.Text = $"Race : {goblin.race}";
                    labelDamage.Text = $"Damage : {goblin.damage}";
                }
                else
                {
                    MessageBox.Show("Goblin data not found in the API.");
                    labelName.Text = "Name : N/A";
                    labelHealth.Text = "Health : N/A";
                    labelRace.Text = "Race : N/A";
                    labelDamage.Text = "Damage : N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching Goblin data: {ex.Message}");
            }
        }

        private async void buttonDragon_Click(object sender, EventArgs e)
        {
            try
            {
                int dragonId = 2; // ID Dragon dari data/monster.json
                Monster dragon = await _monsterClient.GetMonsterByIdAsync(dragonId);

                if (dragon != null)
                {
                    labelName.Text = $"Name : {dragon.name}";
                    labelHealth.Text = $"Health : {dragon.health}";
                    labelRace.Text = $"Race : {dragon.race}";
                    labelDamage.Text = $"Damage : {dragon.damage}";
                }
                else
                {
                    MessageBox.Show("Dragon data not found in the API.");
                    labelName.Text = "Name : N/A";
                    labelHealth.Text = "Health : N/A";
                    labelRace.Text = "Race : N/A";
                    labelDamage.Text = "Damage : N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching Dragon data: {ex.Message}");
            }
        }

        private async void buttonFiend_Click(object sender, EventArgs e)
        {
            try
            {
                int fiendId = 3; // ID Fiend dari data/monster.json
                Monster fiend = await _monsterClient.GetMonsterByIdAsync(fiendId);

                if (fiend != null)
                {
                    labelName.Text = $"Name : {fiend.name}";
                    labelHealth.Text = $"Health : {fiend.health}";
                    labelRace.Text = $"Race : {fiend.race}";
                    labelDamage.Text = $"Damage : {fiend.damage}";
                }
                else
                {
                    MessageBox.Show("Fiend data not found in the API.");
                    labelName.Text = "Name : N/A";
                    labelHealth.Text = "Health : N/A";
                    labelRace.Text = "Race : N/A";
                    labelDamage.Text = "Damage : N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching Fiend data: {ex.Message}");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
