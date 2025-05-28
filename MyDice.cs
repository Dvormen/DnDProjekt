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
    public partial class MyDice : Form
    {
        public MyDice()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(mDClosed);
        }

        private void mDClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            new HomePage().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            new MyCharacters().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
