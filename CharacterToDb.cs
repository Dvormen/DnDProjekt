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
            command1.Parameters.Add("@obr", SqlDbType.VarBinary).Value = obrDoDb;
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
    }
}
