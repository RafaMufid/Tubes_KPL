using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes_KPL_Libraries.Attribute;
using Tubes_KPL_Program.Battle;

namespace Tubes_KPL_GUI8._0
{
    public partial class BattleForm : Form
    {
        charactersAtribute Player;
        Charmons Enemy;
        inventory inv;
        enum State { playerTurn, enemyTurn, battleOver }
        State state;

        public BattleForm()
        {
            InitializeComponent();
        }

        private async void BattleForm_Load(object sender, EventArgs e)
        {
            Player = new charactersAtribute();
            Enemy = new Charmons();
            inv = new inventory();
            state = State.playerTurn;

            await LoadInventory();
            UpdateUI();
        }

        private async Task LoadInventory()
        {
            lstInventory.Items.Clear(); // Clear the list before loading new items

            try
            {
                string weapons = await inv.GetWeaponNames(); // Ensure this returns a collection like List<string> or similar

                if (weapons == null) // Fix: Check if weapons is null or empty
                {
                    lstInventory.Items.Add ("No weapons found in inventory.");
                    return;
                }

                while (weapons != null)
                {
                    lstInventory.Items.Add(weapons);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to get data inventory: " + ex.Message);
            }
        }

        private void UpdateUI()
        {
            BattleTurn.Text = $"Turn: {state}";
            PlayerHP.Text = $"Player HP: {Player.getHealth()}";
            EnemyHP.Text = $"Enemy HP: {Enemy.getHealthmons()}";
        }

        private void EnemyTurn()
        {
            int enemyDamage = calculateAttack.enemyDMG(Player.getHealth());

            battleLog.AppendText($"Enemy Attack dealt {enemyDamage} damage.\r\n");
            Player.setHealth(calculateAttack.enemyDMG(Player.getHealth()));
            if (Player.getHealth() <= 0)
            {
                MessageBox.Show("You Lose!");
                battleLog.AppendText("Player Lose!\r\n");
                state = State.battleOver;
                this.Close();
            }
            else
            {
                state = State.playerTurn;
            }

            UpdateUI();
        }

        private async void AttackButton_Click_1(object sender, EventArgs e)
        {
            if (state != State.playerTurn)
            {
                MessageBox.Show("not Your Turn yet!");
                return;
            }

            string weaponName = txtWeaponName.Text;
            if (string.IsNullOrWhiteSpace(weaponName))
            {
                MessageBox.Show("input weapon name.");
                return;
            }

            int damage = await inv.GetWeaponDamage(weaponName);
            if (damage == -1)
            {
                MessageBox.Show("Weapon not Found!");
                return;
            }

            battleLog.AppendText($"Player attack with {weaponName} deals {damage} damage.\r\n");

            Enemy.setHealthmons(calculateAttack.getDamage(Enemy.getHealthmons(), damage));
            if (Enemy.getHealthmons() <= 0)
            {
                Enemy.setHealthmons(0);
            }
            if (Enemy.getHealthmons() <= 0)
            {
                MessageBox.Show("You Win!");
                battleLog.AppendText("Player Wins!\r\n");
                state = State.battleOver;
                this.Close();
            }
            else
            {
                state = State.enemyTurn;
                EnemyTurn();
            }

            UpdateUI();
        }

        private void RunButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You run From the Battle!");
            this.Close();
        }

    }
}
