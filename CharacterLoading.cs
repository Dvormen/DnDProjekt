using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDProjekt
{
    /// <summary>
    /// Třída která načtítá postavy 
    /// </summary>
    internal class CharacterLoading
    {
        /// <summary>
        /// Načte postavy podle toho, které postavy jsou uživatele
        /// </summary>
        /// <param name="flp"> flowpanel na naplnšní </param>
        /// <param name="f"> forma která se má zavřít při otevírání nové formy </param>
        /// <param name="command"> command podle kterého se vypíší postavy </param>
        public void loadProUzivatele(FlowLayoutPanel flp, Form f, SqlCommand command)
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int charId = reader.GetInt32(0);
                    string jmeno = reader.GetString(1);
                    string prijmeni = reader.GetString(2);
                    byte[] imageBytes = reader["obrazek"] as byte[];
                    Panel itemPanel = new Panel
                    {
                        Width = 210,
                        Height = 240,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        Tag = charId
                    };
                    PictureBox picture = new PictureBox
                    {
                        Width = 200,
                        Height = 200,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Cursor = Cursors.Hand,
                        Left = 5,
                        Top = 5
                    };
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            picture.Image = Image.FromStream(ms);
                        }
                    }
                    Label label = new Label
                    {
                        Text = $"{jmeno} {prijmeni}",
                        Width = 200,
                        Height = 30,
                        Top = picture.Bottom + 5,
                        Left = 5,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand
                    };
                    picture.Click += (s, e) =>
                    {
                        f.Hide();
                        new ViewingForm(charId, true).Show();
                    };
                    label.Click += (s, e) =>
                    {
                        f.Hide();
                        new ViewingForm(charId, true).Show();
                    };
                    itemPanel.Controls.Add(picture);
                    itemPanel.Controls.Add(label);
                    flp.Controls.Add(itemPanel);
                    
                }
            }
        }

        /// <summary>
        /// nastaví command na pošle ho
        /// </summary>
        /// <param name="all"> boolean jestli je výpis pro všechny nebo ne </param>
        /// <returns> command s výpisem postav </returns>
        public SqlCommand loadQuery(bool all) 
        {
            string query;
            if(all)
            {
                query = "select id, jmeno, prijmeni, obrazek from DnDCharacter";
            }
            else {
                query = "select id, jmeno, prijmeni, obrazek from DnDCharacter where id_user = @id";
            }
            SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
            command.Parameters.Add(new("@id", Seshn.LoggedUcet.Id));
            return command;
        }

        /// <summary>
        /// Načte všechny postavy 
        /// </summary>
        /// <param name="flp"> flow panel na naplnění </param>
        /// <param name="f"> forma která se má zavřít při otevření nové formy </param>
        /// <param name="command"> command na naplnění flowpanelu </param>
        public void loadProVsechny(FlowLayoutPanel flp, Form f, SqlCommand command)
        {
            

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int charId = reader.GetInt32(0);
                    string jmeno = reader.GetString(1);
                    string prijmeni = reader.GetString(2);
                    byte[] imageBytes = reader["obrazek"] as byte[];
                    Panel itemPanel = new Panel
                    {
                        Width = 210,
                        Height = 240,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        Tag = charId
                    };
                    PictureBox picture = new PictureBox
                    {
                        Width = 200,
                        Height = 200,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Cursor = Cursors.Hand,
                        Left = 5,
                        Top = 5
                    };
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            picture.Image = Image.FromStream(ms);
                        }
                    }
                    Label label = new Label
                    {
                        Text = $"{jmeno} {prijmeni}",
                        Width = 200,
                        Height = 30,
                        Top = picture.Bottom + 5,
                        Left = 5,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand
                    };
                    picture.Click += (s, e) =>
                    {
                        f.Hide();
                        new ViewingForm(charId,false).Show();
                    };
                    label.Click += (s, e) =>
                    {
                        f.Hide();
                        new ViewingForm(charId,false).Show();
                    };
                    itemPanel.Controls.Add(picture);
                    itemPanel.Controls.Add(label);
                    flp.Controls.Add(itemPanel);

                }
            }
        }
    }
}



