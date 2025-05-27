using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DnDProjekt
{
    internal class Ucet
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        public Ucet(string username, string password) 
        {
            Username = username;
            Password = password;            
        }

        public bool pridat(Ucet ucet) 
        {
            // zkontroluje jestli existuje uživatel
            string query = "select count(*) from DnDUser where username = @jmeno";
            SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
            command.Parameters.Add(new("@jmeno", ucet.Username));
            if (Convert.ToInt32(command.ExecuteScalar()) == 1) 
            {
                return false;
            }
            else // jestli neexistuje, přidá ho
            {
                //generování kryptovani
                PasswordEncryption pe = new PasswordEncryption();
                string query2 = "insert into DnDEncrypt(kv, vv) values(@klic, @vektor)";
                SqlCommand command2 = new SqlCommand(query2, Singleton.GetInstance());
                RandomNumberGenerator rng = RandomNumberGenerator.Create();
                byte[] klic = new byte[16];
                byte[] vektor = new byte[16];
                rng.GetBytes(klic);
                rng.GetBytes(vektor);
                command2.Parameters.Add(new("@klic", klic));
                command2.Parameters.Add(new("@vektor", vektor));
                command2.ExecuteNonQuery();

                //přidání usera
                string query3 = "insert into DnDUser(username, passwd, enc_id) values(@jmeno, @heslo,(select id from DnDEncrypt where kv = @klic and vv = @vektor))";
                SqlCommand command3 = new SqlCommand(query3, Singleton.GetInstance());
                byte[] kryptovaneheslo = pe.kryptovani(ucet.Password,klic,vektor);
                command3.Parameters.Add(new("@jmeno", ucet.Username));
                command3.Parameters.Add(new("@heslo", kryptovaneheslo));
                command3.Parameters.Add(new("@klic", klic));
                command3.Parameters.Add(new("@vektor", vektor));
                command3.ExecuteNonQuery();
            return true;
            }
        }

        public string logIn(Ucet ucet) 
        {
            string query0 = "select count(*) from DnDUser where username = @username";
            SqlCommand command0 = new SqlCommand(query0, Singleton.GetInstance());
            command0.Parameters.Add(new SqlParameter("@username", ucet.Username));

            int count = Convert.ToInt32(command0.ExecuteScalar());
            if (count == 0)
            {
                return "Uživatel nebyl nalezen";
            }
            PasswordEncryption pe = new PasswordEncryption();
            string query1 = "select kv from DnDEncrypt where id = (select id from DnDUser where username = @username)";
            SqlCommand command1 = new SqlCommand(query1, Singleton.GetInstance());
            command1.Parameters.Add(new("@username", ucet.Username));
            object result1 = command1.ExecuteScalar();
            byte[] klic = result1 != DBNull.Value ? (byte[])result1 : null;

            string query2 = "select vv from DnDEncrypt where id = (select id from DnDUser where username = @username)";
            SqlCommand command2 = new SqlCommand(query2, Singleton.GetInstance());
            command2.Parameters.Add(new("@username", ucet.Username));
            object result2 = command2.ExecuteScalar();
            byte[] vektor = result2 != DBNull.Value ? (byte[])result2 : null;

            string query3 = "select passwd from DnDUser where username = @username";
            SqlCommand command3 = new SqlCommand(query3, Singleton.GetInstance());
            command3.Parameters.Add(new("@username", ucet.Username));
            object result3 = command3.ExecuteScalar();
            byte[] heslo = result3 != DBNull.Value ? (byte[])result3 : null;

            string dekryptovaneheslo = pe.dekryptovani(heslo, klic, vektor);

            string message;
            if (ucet.Password.Equals(dekryptovaneheslo))
            {
                string query4 = "select id from DnDUser where username = @username";
                SqlCommand command4 = new SqlCommand(query4, Singleton.GetInstance());
                command4.Parameters.Add(new("@username", ucet.Username));
                Seshn.LoggedUcet = ucet;
                Seshn.LoggedUcet.Id = Convert.ToInt32(command4.ExecuteScalar());
                return "Přihlášeno";
            }
            else 
            {
                return "Špatné heslo";
            }
        }
    }
}

