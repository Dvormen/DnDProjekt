using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProjekt
{
    internal class Kostky
    {
        public void naplneniMod(ComboBox cb) 
        {
            string query1 = "select id, stat from DnDStats";
            SqlCommand command1 = new SqlCommand(query1, Singleton.GetInstance());
            SqlDataReader r = command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            cb.DataSource = dt;
            cb.DisplayMember = "stat";
            cb.ValueMember = "id";
        }

        public void naplneniChar(ComboBox cb)
        {
            string query1 = "select id, jmeno, prijmeni from DnDCharacter where id_user = @id";
            SqlCommand command1 = new SqlCommand(query1, Singleton.GetInstance());
            command1.Parameters.Add(new("@id", Seshn.LoggedUcet.Id));
            SqlDataReader r = command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            dt.Columns.Add("jmenoaprijmeni", typeof(string), "jmeno + ' ' + prijmeni");
            cb.DataSource = dt;
            cb.DisplayMember = "jmenoaprijmeni";
            cb.ValueMember = "id";
        }

        public void modVisibility(ComboBox cb1, ComboBox cb2) 
        {
            if (cb1.SelectedValue != null)
            {
                if (int.TryParse(cb1.SelectedValue.ToString(), out int selectedValue))
                {
                    cb2.Visible = selectedValue > 2;
                }
                else
                {
                    cb2.Visible = false;
                }
            }
        }

        public void kostkaDoDb(bool nonMod,ComboBox cb,ComboBox cb2,string nazev, int kva, int druh, int mod) 
        {
            if (nonMod) {
                string[] temp = cb2.Text.Split(" ");
                string query2 = "select id from DnDCharacter where id_user = @id and jmeno = @jmeno and prijmeni = @prijmeni";
                SqlCommand command2 = new SqlCommand(query2, Singleton.GetInstance());
                command2.Parameters.Add(new("@id",Seshn.LoggedUcet.Id));
                command2.Parameters.Add(new("@jmeno", temp[0]));
                command2.Parameters.Add(new("@prijmeni", temp[1]));

                string query = "insert into DnDKostka (id_user, id_charakter, stat_id, nazev, kvantita, druh_kostky, mod_kostka) values(@idU, @idCh, @stat, " +
                    "@nazev, @kvantita, @druh, @mod)";
                SqlCommand command1 = new SqlCommand(query, Singleton.GetInstance());
                command1.Parameters.Add(new("@idU", Seshn.LoggedUcet.Id));
                command1.Parameters.Add(new("@idCh", command2.ExecuteScalar()));
                command1.Parameters.Add(new("@stat", Convert.ToInt32(cb2.SelectedValue)));
                command1.Parameters.Add(new("@nazev", nazev));
                command1.Parameters.Add(new("@kvantita", kva));
                command1.Parameters.Add(new("@druh", druh));
                command1.Parameters.Add(new("@mod", calculateMod(temp[0], temp[1], cb)));
                command1.ExecuteNonQuery();
            }
            else 
            {
                string query = "insert into DnDKostka (id_user, stat_id, nazev, kvantita, druh_kostky, mod_kostka) values(@idU, @stat, " +
                        "@nazev, @kvantita, @druh, @mod)";
                
                SqlCommand command1 = new SqlCommand(query, Singleton.GetInstance());
                command1.Parameters.Add(new("@idU", Seshn.LoggedUcet.Id));
                command1.Parameters.Add(new("@stat", Convert.ToInt32(cb2.SelectedValue)));
                command1.Parameters.Add(new("@nazev", nazev));
                command1.Parameters.Add(new("@kvantita", kva));
                command1.Parameters.Add(new("@druh", druh));
                command1.Parameters.Add(new("@mod", mod));
                command1.ExecuteNonQuery();
            }
        }

        public int calculateMod(string jmeno, string prijmeni, ComboBox cb) 
        {
            int stat = cb.SelectedIndex - 2;
            string query3 = "select strength, dexterity, constitution, inteligence, wisdom, charisma from DnDCharacter where id_user = @id and " +
                    "jmeno = @jmeno and prijmeni = @prijmeni";
            SqlCommand command3 = new SqlCommand(query3, Singleton.GetInstance());
            command3.Parameters.Add(new("@id", Seshn.LoggedUcet.Id));
            command3.Parameters.Add(new("@jmeno", jmeno));
            command3.Parameters.Add(new("@prijmeni", prijmeni));
            SqlDataReader reader3 = command3.ExecuteReader();
            reader3.Read();
            int value = reader3.GetInt32(stat);
            reader3.Close();


            int count = 0;
            int modifier = -5;
            for (int i = 0; i < 9999; i++)
            {
                value = value - 2;
                count++;
                if (value <= 0)
                {
                    break;
                }
            }
            if (value == -1)
            {
                count--;
            }
            modifier = modifier + count;
            if (modifier > 10) 
            {
                modifier = 10;
            }
            return modifier;
        }
    }
}
