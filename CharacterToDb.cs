using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProjekt
{
    internal class CharacterToDb
    {
        public void pridat(int id,int rasa, int classa, int subclassa, int gender, string jmeno, string prijmeni, decimal vek, decimal vyska, decimal vaha, string lore, decimal hp, decimal ac, decimal str, decimal dex, decimal con, decimal i, decimal wis, decimal ch, Image obr) 
        {
            string query1 = "insert into DnDCharacter (id_user,rasa,classa,subClassa,gender_id,jmeno,prijmeni,vek,vyska,vaha,lore,max_hp,armor_class,strength,dexterity,constitution,inteligence,wisdom,charisma,obrazek) " +
                "values(@id,@rasa,@classa,@subclassa,@gender,@jmeno,@prijmeni,@vek,@vyska,@vaha,@lore,@hp,@ac,@str,@dex,@con,@int,@wis,@ch,@obr)";
            byte[] obrDoDb = obrazekDoDb(obr);
            SqlCommand command1 = new SqlCommand(query1, Singleton.GetInstance());
            command1.Parameters.Add(new("@id", id));
            command1.Parameters.Add(new("@rasa", rasa));
            command1.Parameters.Add(new("@classa", classa));
            command1.Parameters.Add(new("@subclassa", subclassa));
            command1.Parameters.Add(new("@gender", gender));
            command1.Parameters.Add(new("@jmeno", jmeno));
            command1.Parameters.Add(new("@prijmeni", prijmeni));
            command1.Parameters.Add(new("@vek", vek));
            command1.Parameters.Add(new("@vyska", vyska));
            command1.Parameters.Add(new("@vaha", vaha));
            command1.Parameters.Add(new("@lore", lore));
            command1.Parameters.Add(new("@hp", hp));
            command1.Parameters.Add(new("@ac", ac));
            command1.Parameters.Add(new("@str", str));
            command1.Parameters.Add(new("@dex", dex));
            command1.Parameters.Add(new("@con", con));
            command1.Parameters.Add(new("@int", i));
            command1.Parameters.Add(new("@wis", wis));
            command1.Parameters.Add(new("@ch", ch));
            command1.Parameters.Add("@obr", SqlDbType.VarBinary).Value = obrDoDb ?? (object)DBNull.Value;
            command1.ExecuteNonQuery();
        }
        public static byte[] obrazekDoDb(Image obrazek)
        {
            if (obrazek == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                obrazek.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public void vlozeniUpraveny(int id, int rasa, int classa, int subclassa, int gender, string jmeno, string prijmeni, decimal vek, decimal vyska, decimal vaha, string lore, decimal hp, decimal ac, decimal str, decimal dex, decimal con, decimal i, decimal wis, decimal ch, Image obr) 
        {
            string query = "update DnDCharacter set rasa = @rasa, classa = @classa, subClassa = @subclassa, gender_id = @gender, jmeno = @jmeno," +
                " prijmeni = @prijmeni, vek = @vek, vyska = @vyska, vaha = @vaha, lore = @lore, max_Hp = @hp, armor_class = @ac, strength = @str," +
                " constitution = @con, dexterity = @dex, inteligence = @int, wisdom = @wis, charisma = @ch, obrazek = @obr where id = @id";
            byte[] obrDoDb = obrazekDoDb(obr);
            SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
            command.Parameters.Add(new("@id", id));
            command.Parameters.Add(new("@rasa", rasa));
            command.Parameters.Add(new("@classa", classa));
            command.Parameters.Add(new("@subclassa", subclassa));
            command.Parameters.Add(new("@gender", gender));
            command.Parameters.Add(new("@jmeno", jmeno));
            command.Parameters.Add(new("@prijmeni", prijmeni));
            command.Parameters.Add(new("@vek", vek));
            command.Parameters.Add(new("@vyska", vyska));
            command.Parameters.Add(new("@vaha", vaha));
            command.Parameters.Add(new("@lore", lore));
            command.Parameters.Add(new("@hp", hp));
            command.Parameters.Add(new("@ac", ac));
            command.Parameters.Add(new("@str", str));
            command.Parameters.Add(new("@dex", dex));
            command.Parameters.Add(new("@con", con));
            command.Parameters.Add(new("@int", i));
            command.Parameters.Add(new("@wis", wis));
            command.Parameters.Add(new("@ch", ch));
            command.Parameters.Add("@obr", SqlDbType.VarBinary).Value = obrDoDb ?? (object)DBNull.Value;
            command.ExecuteNonQuery();
        }

        public void naplneniRas(ComboBox cb) 
        {
            string query1 = "select id, druh from DnDRace";
            SqlCommand command1 = new SqlCommand(query1, Singleton.GetInstance());
            SqlDataReader r = command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            cb.DataSource = dt;
            cb.DisplayMember = "druh";
            cb.ValueMember = "id";
        }

        public void naplneniClass(ComboBox cb)
        {
            string query1 = "select id, druh from DnDClass";
            SqlCommand command1 = new SqlCommand(query1, Singleton.GetInstance());
            SqlDataReader r = command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            cb.DataSource = dt;
            cb.DisplayMember = "druh";
            cb.ValueMember = "id";
        }
        public void naplneniPohlavi(ComboBox cb)
        {
            string query1 = "select id, druh from DnDGender";
            SqlCommand command1 = new SqlCommand(query1, Singleton.GetInstance());
            SqlDataReader r = command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(r);
            cb.DataSource = dt;
            cb.DisplayMember = "druh";
            cb.ValueMember = "id";
        }

        public bool nameCheck(string name, string surname) 
        {
            string query1 = "select jmeno, prijmeni from DnDCharacter where id = @id";
            SqlCommand command1 = new SqlCommand(query1, Singleton.GetInstance());
            command1.Parameters.Add(new("@id", Seshn.LoggedUcet.Id));
            SqlDataReader r = command1.ExecuteReader();
            string jmeno = r.GetString(0);
            string prijmeni = r.GetString(1);
            if (jmeno.Equals(name) && prijmeni.Equals(surname)) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
