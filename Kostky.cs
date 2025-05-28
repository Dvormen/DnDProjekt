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
                    cb2.Visible = selectedValue != 1;
                }
                else
                {
                    cb2.Visible = true;
                }
            }
        }

        /*public void kostkaDoDb() 
        {
            string query = "insert into DnDKostka (id_user, id_character, stat_id, nazev, kvantita, druh_kostky, mod_kostka) values(@idU, @idCh, @stat, " +
                "@nazev, @kvantita, @druh, @mod)";
            SqlCommand command1 = new SqlCommand(query, Singleton.GetInstance());
            command1.Parameters.Add(new("@idU", Seshn.LoggedUcet.Id));
            command1.Parameters.Add(new("@idCh", ));
            command1.Parameters.Add(new("@stat", ));
            command1.Parameters.Add(new("@nazev", ));
            command1.Parameters.Add(new("@kvantita",));
            command1.Parameters.Add(new("@druh", ));
            command1.Parameters.Add(new("@mod", ));
        }*/
    }
}
