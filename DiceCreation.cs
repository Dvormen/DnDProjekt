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
    /// tato třída řeší funkce na formě dice creation
    /// </summary>
    public partial class DiceCreation : Form
    {

        public DiceCreation()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(dClosed);
            new Kostky().naplneniMod(comboBox1);
            new Kostky().naplneniChar(comboBox2);
            comboBox2.Visible = false;

        }

        /// <summary>
        /// zavře aplikaci pokud se zavře okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// otevře nové okno a schová staré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new MyDice().Show();
        }

        /// <summary>
        /// přidá kostku do databáze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(comboBox1.SelectedValue) == 1) 
            {
                MessageBox.Show("Nevybraný Modifier");
            }
            else 
            {
                if(Convert.ToInt32(comboBox1.SelectedValue) == 2)
                {
                    new Kostky().kostkaDoDb(false,comboBox1,comboBox2,textBox1.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value),
                        Convert.ToInt32(numericUpDown3.Value));
                }
                else
                {
                    new Kostky().kostkaDoDb(true, comboBox1, comboBox2, textBox1.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value),
                        Convert.ToInt32(numericUpDown3.Value));
                }
                MessageBox.Show("kostka přidána");
                Hide();
                new MyDice().Show();
            }
        }

        /// <summary>
        /// kontroluje vybrané možnostzi v comboboxu a dynamicky ukazuje combobox 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Kostky().modVisibility(comboBox1,comboBox2);
        }
    }
}
