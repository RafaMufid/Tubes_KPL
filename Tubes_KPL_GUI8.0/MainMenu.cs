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
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void labelSubTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            using (Menu2 menu2 = new Menu2())
            {
                menu2.ShowDialog();
            }
        }

        private void buttonCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muhammad Thoriq Marcello - 103022300031\nAhmad Dillan Ramadhan - 103022300037\n" +
                "Muhammad Zaky Amarullah - 103022300049\nRafa Mufid 'Aqila - 103022300061\n" +
                "Muhammad Reza Ferdinal - 103022300135", "ANGGOTA KELOMPOK");
        }
    }
}
