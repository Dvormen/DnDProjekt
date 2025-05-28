using Microsoft.Data.SqlClient;
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
    public partial class ViewingForm : Form
    {
        int Id { get; set; }
        public ViewingForm(int id, bool a)
        {

            InitializeComponent();
            FormClosed += new FormClosedEventHandler(viewClosed);
            Id = id;
            loadPage(Id, a);
        }

        private void viewClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loadPage(int id, bool edit)
        {
            string query = "select DnDUser.username, DnDRace.druh, DnDClass.druh, subclass.druh, DnDGender.druh, jmeno, prijmeni, vek, vyska, vaha, lore, " +
                "max_Hp, armor_class, strength, dexterity, constitution, inteligence, wisdom, charisma, obrazek " +
                "from DnDCharacter inner join DnDUser on DnDUser.id = DnDCharacter.id_user " +
                "inner join DnDGender on DnDGender.id = DnDCharacter.gender_id " +
                "inner join DnDRace ON DnDRace.id = DnDCharacter.rasa " +
                "inner join DnDClass ON DnDClass.id = DnDCharacter.classa " +
                "inner join DnDClass as subclass ON subclass.id = DnDCharacter.subClassa " +
                "where DnDCharacter.id = @id";
            SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
            command.Parameters.Add(new("@id", id));

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                label19.Text += reader.GetString(0);
                label4.Text += " " + reader.GetString(1);
                label5.Text += " " + reader.GetString(2);
                label6.Text += " " + reader.GetString(3);
                pohlavi.Text += " " + reader.GetString(4);
                label2.Text += " " + reader.GetString(5);
                label3.Text += " " + reader.GetString(6);
                label9.Text += " " + reader.GetInt32(7) + " Cm";
                label7.Text += " " + reader.GetInt32(8) + " Kg";
                label8.Text += " " + reader.GetInt32(9) + " Let";
                LoreBox.Text += " " + reader.GetString(10);
                label10.Text += " " + reader.GetInt32(11);
                label14.Text += " " + reader.GetInt32(12);
                label11.Text += " " + reader.GetInt32(13);
                label12.Text += " " + reader.GetInt32(14);
                label13.Text += " " + reader.GetInt32(15);
                label15.Text += " " + reader.GetInt32(16);
                label16.Text += " " + reader.GetInt32(17);
                label18.Text += " " + reader.GetInt32(18);
                if (!reader.IsDBNull(19))
                {
                    byte[] obr = (byte[])reader["obrazek"];
                    MemoryStream ms = new MemoryStream(obr);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                else
                {
                    pictureBox1.Image = null;
                }
                if (edit)
                {
                    button3.Visible = true;
                    button2.Visible = true;
                }
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new HomePage().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new CharacterCreation(Id, true).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Opravdu chcete smazat postavu?",
                "potvrzení",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (r == DialogResult.Yes){
                string query = "delete from DnDCharacter where id = @id";
                SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
                command.Parameters.Add(new("@id", Id));
                command.ExecuteNonQuery();
                MessageBox.Show("Postava smazána");
                Hide();
                new MyCharacters().Show();
            }
        }
    }
}
