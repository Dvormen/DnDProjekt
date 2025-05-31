using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDProjekt
{
    /// <summary>
    /// Tato třída se stará o funkce na formě my dice
    /// </summary>
    public partial class MyDice : Form
    {
        public MyDice()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(mDClosed);
            new Kostky().loadKostek(flowLayoutPanel1, new Kostky().basicCommand());
        }

        /// <summary>
        /// Zavře aplikaci pokud je forma zavřená
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mDClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Otevře novou formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            new HomePage().Show();
        }

        /// <summary>
        /// Otevře novou formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            new MyCharacters().Show();
        }

        /// <summary>
        /// načte jiný obsah na stránu podle vyhledávání
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            new Kostky().loadKostek(flowLayoutPanel1, new Search().searchDice(textBox1.Text));
        }

        /// <summary>
        /// otevře novou formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pridat_Click(object sender, EventArgs e)
        {
            Hide();
            new DiceCreation().Show();
        }
    }
}
