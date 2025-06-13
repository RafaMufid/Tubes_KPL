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
using Tubes_KPL_API;

namespace Tubes_KPL_GUI8._0
{
    public partial class Monsters : Form
    {
        public Monsters()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonGoblin_Click(object sender, EventArgs e)
        {
            labelName.Text = "Goblin";
        }
    }
}
