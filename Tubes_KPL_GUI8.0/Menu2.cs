using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL_GUI8._0
{
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBattle_Click(object sender, EventArgs e)
        {
            this.Close();
            BattleForm battle = new BattleForm();
            battle.ShowDialog();
        }

        private void buttonCompendium_Click(object sender, EventArgs e)
        {
            using (Compendium comp = new Compendium())
            {
                this.Hide(); // Sembunyikan form Menu2 sementara
                comp.ShowDialog();
                this.Show(); // Tampilkan kembali form Menu2 setelah Compendium ditutup
            }
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            using (Shop shop = new Shop())
            {
                this.Hide(); // Sembunyikan form Compendium sementara
                shop.ShowDialog();
                this.Show(); // Tampilkan kembali form Compendium setelah Shop ditutup
            }
        }
    }
}
