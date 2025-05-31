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
    /// Tato třída se stará o funkce na formě s charaktery
    /// </summary>
    public partial class MyCharacters : Form
    {
        public MyCharacters()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(mChClosed);
            new CharacterLoading().loadProUzivatele(flowLayoutPanel1,this,new CharacterLoading().loadQuery(false));
        }

        /// <summary>
        /// Tato medota zavře aplikaci když se zavře okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mChClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Po kliknutí na button se načtou výsledky
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            new CharacterLoading().loadProUzivatele(flowLayoutPanel1, this, new Search().searchCharacters(textBox1.Text));
        }

        /// <summary>
        /// Otevře nevou formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            new HomePage().Show();
        }

        /// <summary>
        /// otevře novou formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            new MyDice().Show();
        }

        /// <summary>
        /// Otevře novou formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pridat_Click(object sender, EventArgs e)
        {
            Hide();
            new CharacterCreation(0,false).Show();
        }
    }
}
