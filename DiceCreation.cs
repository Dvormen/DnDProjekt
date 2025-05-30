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

        private void dClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new MyDice().Show();
        }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Kostky().modVisibility(comboBox1,comboBox2);
        }
    }
}
