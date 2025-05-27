using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DnDProjekt
{
    public partial class CharacterCreation : Form
    {
        public CharacterCreation()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(chCClosed);
            new CharacterToDb().naplneniRas(RaceBox);
            new CharacterToDb().naplneniClass(ClassBox);
            new CharacterToDb().naplneniClass(SubclassBox);
            new CharacterToDb().naplneniPohlavi(GenderBox);
        }
        private void chCClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MyCharacters mch = new MyCharacters();
            mch.Location = Location;
            mch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoreBox.Text.Length > 8000)
            {
                MessageBox.Show("Moc dlouhej lore Zro");
            }
            else
            {
                new CharacterToDb().pridat(Seshn.LoggedUcet.Id, Convert.ToInt32(RaceBox.SelectedValue), Convert.ToInt32(ClassBox.SelectedValue),
                    Convert.ToInt32(SubclassBox.SelectedValue), Convert.ToInt32(GenderBox.SelectedValue), NameBox.Text, SurnameBox.Text, vekBox.Value,
                    HeightBox.Value, vahaBox.Value, LoreBox.Text, Hp.Value, Ac.Value, Str.Value, dex.Value, con.Value, i.Value, wis.Value, ch.Value,
                    pictureBox1.Image);
                MessageBox.Show("Postava přidána");
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] obr = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (obr.Length > 0)
            {
                string cesta = obr[0];
                using (Image puvObr = Image.FromFile(cesta))
                {
                    Bitmap zmenenyObr = new Bitmap(200, 200);
                    using (Graphics g = Graphics.FromImage(zmenenyObr))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(puvObr, 0, 0, 200, 200);
                    }
                    pictureBox1.Image = zmenenyObr;
                }
                label10.Visible = false;
            }
        }
    }
}
