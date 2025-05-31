using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProjekt
{
    /// <summary>
    /// Třída, která propojuje postavy s databází
    /// </summary>
    internal class CharacterToDb
    {
        /// <summary>
        /// Metoda která přidá postavu do databáze
        /// </summary>
        /// <param name="id"> id uživatele </param>
        /// <param name="rasa"> rasa postavy </param>
        /// <param name="classa"> classa postavy </param>
        /// <param name="subclassa"> subclassa postavy </param>
        /// <param name="gender"> pohlaví postavy </param>
        /// <param name="jmeno"> jméno postavy </param>
        /// <param name="prijmeni"> prijmení postavy </param>
        /// <param name="vek"> věk postavy </param>
        /// <param name="vyska"> výška postavy </param>
        /// <param name="vaha"> váha postavy </param>
        /// <param name="lore"> příběh postavy </param>
        /// <param name="hp"> maximální životy postavy </param>
        /// <param name="ac"> brnění postvy </param>
        /// <param name="str"> síla postavy </param>
        /// <param name="dex"> obratnost postavy </param>
        /// <param name="con"> výdrž postavy </param>
        /// <param name="i"> inteligence postavy </param>
        /// <param name="wis"> moudrost postavy </param>
        /// <param name="ch"> charisma postavy </param>
        /// <param name="obr"> obrázek postavy </param>
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

        /// <summary>
        /// Metoda která přemění obrázek na array bytu
        /// </summary>
        /// <param name="obrazek"></param>
        /// <returns> array bytů obrázku </returns>
        public static byte[] obrazekDoDb(Image obrazek)
        {
            if (obrazek == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                obrazek.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Upravení postavy v databázi
        /// </summary>
        /// <param name="id"> id uživatele </param>
        /// <param name="rasa"> rasa postavy </param>
        /// <param name="classa"> classa postavy </param>
        /// <param name="subclassa"> subclassa postavy </param>
        /// <param name="gender"> pohlaví postavy </param>
        /// <param name="jmeno"> jméno postavy </param>
        /// <param name="prijmeni"> prijmení postavy </param>
        /// <param name="vek"> věk postavy </param>
        /// <param name="vyska"> výška postavy </param>
        /// <param name="vaha"> váha postavy </param>
        /// <param name="lore"> příběh postavy </param>
        /// <param name="hp"> maximální životy postavy </param>
        /// <param name="ac"> brnění postvy </param>
        /// <param name="str"> síla postavy </param>
        /// <param name="dex"> obratnost postavy </param>
        /// <param name="con"> výdrž postavy </param>
        /// <param name="i"> inteligence postavy </param>
        /// <param name="wis"> moudrost postavy </param>
        /// <param name="ch"> charisma postavy </param>
        /// <param name="obr"> obrázek postavy </param>
        public void vlozeniUpraveny(int id, int rasa, int classa, int subclassa, int gender, string jmeno, string prijmeni, decimal vek, decimal vyska, decimal vaha, string lore, decimal hp, decimal ac, decimal str, decimal dex, decimal con, decimal i, decimal wis, decimal ch, Image obr) 
        {
            string query2 = "select strength, dexterity, constitution, inteligence, wisdom, charisma from DnDCharacter where id = @id";
            SqlCommand command2 = new SqlCommand(query2,Singleton.GetInstance());
            command2.Parameters.Add(new("@id", id));
            SqlDataReader reader = command2.ExecuteReader();
            int strength = 0, dexterity = 0, constitution = 0, inteligence = 0, wisdom = 0, charisma = 0;

            if (reader.Read())
            {
                strength = reader.GetInt32(0);
                dexterity = reader.GetInt32(1);
                constitution = reader.GetInt32(2);
                inteligence = reader.GetInt32(3);
                wisdom = reader.GetInt32(4);
                charisma = reader.GetInt32(5);
            }
            reader.Close();
            if (strength - str != 0) 
            {
                upraveniMod(str,"Strength",id);
            }
            if (dexterity - dex != 0)
            {
                upraveniMod(dex, "Dexterity", id);
            }
            if (constitution - con != 0)
            {
                upraveniMod(con, "Constitution", id);
            }
            if (inteligence - i != 0)
            {
                upraveniMod(i, "Inteligence", id);
            }
            if (wisdom - wis != 0)
            {
                upraveniMod(wis, "Wisdom", id);
            }
            if (charisma - ch != 0)
            {
                upraveniMod(ch, "Charisma", id);
            }

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

        /// <summary>
        /// Metoda která upraví modifier na kostce po změně statu postavy
        /// </summary>
        /// <param name="stat"></param>
        /// <param name="statS"></param>
        /// <param name="id"></param>
        public void upraveniMod(decimal stat,string statS, int id) 
        {
            string query2 = "select id from DnDStats where stat = @stat";
            SqlCommand command2 = new SqlCommand(query2, Singleton.GetInstance());
            command2.Parameters.Add(new("@stat", statS));

            int mod = new Kostky().GetMod(stat);
            string query = $"update DnDKostka set mod_kostka = @mod where id_charakter = @id and stat_id = @stat";
            SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
            command.Parameters.Add(new("@mod",mod));
            command.Parameters.Add(new("@id",id));
            command.Parameters.Add(new("@stat",command2.ExecuteScalar()));
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// naplní combobox rasama z databáze
        /// </summary>
        /// <param name="cb"> combobox na naplnění </param>
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

        /// <summary>
        /// naplní combobox classama z databáze
        /// </summary>
        /// <param name="cb"> combobox na naplnění </param>
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

        /// <summary>
        /// naplní combobox pohlavíma z databáze
        /// </summary>
        /// <param name="cb"> combobox na naplnění </param>
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

        /// <summary>
        /// kontroluje jestli v databázi už není postava se stejným jménem od jedoho autora
        /// </summary>
        /// <param name="name"> jméno přidávané postavy </param>
        /// <param name="surname"> příjmení přidávané postavy </param>
        /// <returns> true nebo false podle toho jestli tam je postava se stejným jménem </returns>
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
