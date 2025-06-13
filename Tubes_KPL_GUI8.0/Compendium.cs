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
            Monsters monster = new Monsters();
            monster.ShowDialog();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //Menu2 menu2 = new Menu2();
            //menu2.ShowDialog();
        }
    }
}
