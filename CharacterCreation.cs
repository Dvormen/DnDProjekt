using Microsoft.Data.SqlClient;
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
        private bool Edit {  get; set; }
        private int Id {  get; set; }
        public CharacterCreation(int id,bool edit)
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(chCClosed);
            new CharacterToDb().naplneniRas(RaceBox);
            new CharacterToDb().naplneniClass(ClassBox);
            new CharacterToDb().naplneniClass(SubclassBox);
            new CharacterToDb().naplneniPohlavi(GenderBox);
            Edit = edit;
            Id = id;
            if (Edit)
            {
                loadNaEdit(id);
                button2.Text = "Upravit";
            }
        }
        private void chCClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new MyCharacters().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!Edit){ 
                addToDb();
            }
            else 
            {
                editChar();
            }
        }

        private void addToDb() 
        {
            button2.Text = "test";
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
        public void loadNaEdit(int id)
        {
            string query = "select rasa,classa,subClassa,gender_id,jmeno,prijmeni,vek,vyska,vaha,lore,max_hp,armor_class,strength,dexterity," +
                "constitution,inteligence,wisdom,charisma,obrazek from DnDCharacter where id = @id";
            SqlCommand command1 = new SqlCommand(query, Singleton.GetInstance());
            command1.Parameters.Add(new("@id", id));
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read()) 
            {
                RaceBox.SelectedValue = reader.GetInt32(0);
                ClassBox.SelectedValue = reader.GetInt32(1);
                SubclassBox.SelectedValue = reader.GetInt32(2);
                GenderBox.SelectedValue = reader.GetInt32(3);
                NameBox.Text = reader.GetString(4);
                SurnameBox.Text = reader.GetString(5);
                vekBox.Value = reader.GetInt32(6);
                HeightBox.Value = reader.GetInt32(7);
                vahaBox.Value = reader.GetInt32(8);
                LoreBox.Text = reader.GetString(9);
                Hp.Value = reader.GetInt32(10);
                Ac.Value = reader.GetInt32(11);
                Str.Value = reader.GetInt32(12);
                dex.Value = reader.GetInt32(13);
                con.Value = reader.GetInt32(14);
                i.Value = reader.GetInt32(15);
                wis.Value = reader.GetInt32(16);
                ch.Value = reader.GetInt32(17);
                if (!reader.IsDBNull(18))
                {
                    byte[] obr = (byte[])reader["obrazek"];
                    MemoryStream ms = new MemoryStream(obr);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            label10.Visible = false;
            reader.Close();
        }

        private void editChar() 
        {
            new CharacterToDb().vlozeniUpraveny(Id, Convert.ToInt32(RaceBox.SelectedValue), Convert.ToInt32(ClassBox.SelectedValue),
                Convert.ToInt32(SubclassBox.SelectedValue), Convert.ToInt32(GenderBox.SelectedValue),NameBox.Text, SurnameBox.Text, vekBox.Value,
                HeightBox.Value, vahaBox.Value, LoreBox.Text, Hp.Value,Ac.Value,Str.Value,dex.Value,con.Value,i.Value,wis.Value, ch.Value,pictureBox1.Image);
            MessageBox.Show("Postava Upravena");
            Hide();
            new MyCharacters().Show();
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
