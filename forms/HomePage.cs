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
    /// Třída která řeší fuknce na stánce home page
    /// </summary>
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(hPClosed);
            new CharacterLoading().loadProVsechny(flowLayoutPanel1, this, new CharacterLoading().loadQuery(true));
        }

        /// <summary>
        /// Zavře aplikaci pokud se zavře okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hPClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// otevře novou formu, schodá nynější
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            new MyCharacters().Show();
        }

        /// <summary>
        /// otevře novou formu, schodá nynější
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            new MyDice().Show();
        }

        /// <summary>
        /// načte nové hodnoty do flow panelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            new CharacterLoading().loadProVsechny(flowLayoutPanel1, this, new Search().searchCharacters(textBox1.Text));
        }
    }
}
