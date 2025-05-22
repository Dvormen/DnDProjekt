using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProjekt
{
    internal class Ucet
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Ucet(string username, string password) 
        {
            Username = username;
            Password = password;            
        }

        public bool pridat(Ucet ucet) 
        {
            string query = "select count(*) from DnDUser where username = @jmeno";
            SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
            command.Parameters.Add(new("@jmeno", ucet.Username));
            if (Convert.ToInt32(command.ExecuteScalar()) == 1) 
            {
                return false;
            }
            else 
            {
            string query2 = "insert into DnDUser(username, passwd) values(@jmeno, @heslo)";
            SqlCommand command2 = new SqlCommand(query2, Singleton.GetInstance());
            command2.Parameters.Add(new("@jmeno", ucet.Username));
            command2.Parameters.Add(new("@heslo", ucet.Password));
            command2.ExecuteNonQuery();
            return true;
            }
        }

        public bool logIn(Ucet ucet) 
        {
        string query = "select username from DnDUser where passwd = @heslo";
            SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
            command.Parameters.Add(new("@heslo", ucet.Password));
            if (command.ExecuteScalar().Equals(ucet.Username)) 
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
