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
    public partial class MyCharacters : Form
    {
        public MyCharacters()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(mChClosed);
            new CharacterLoading().loadProUzivatele(flowLayoutPanel1,this,new CharacterLoading().loadQuery(false));
        }

        private void mChClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CharacterLoading().loadProUzivatele(flowLayoutPanel1, this, new Search().searchCharacters(textBox1.Text));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            new HomePage().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            new MyDice().Show();
        }

        private void pridat_Click(object sender, EventArgs e)
        {
            Hide();
            new CharacterCreation(0,false).Show();
        }
    }
}
