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
    public partial class Compendium : Form
    {
        public Compendium()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMonster_Click(object sender, EventArgs e)
        {
            using (Monsters monstersForm = new Monsters())
            {
                this.Hide(); // Sembunyikan form Compendium sementara
                monstersForm.ShowDialog();
                this.Show(); // Tampilkan kembali form Compendium setelah MonstersForm ditutup
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
