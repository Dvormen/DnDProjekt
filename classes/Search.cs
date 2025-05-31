using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDProjekt
{
    /// <summary>
    /// Tato třída je na vyhledávání specifických charakterú a kostek
    /// </summary>
    internal class Search
    {
        /// <summary>
        /// Vyhledává postavy
        /// </summary>
        /// <param name="input"> string podle kterého se vyhledává v databázi </param>
        /// <returns> command s vyhledáním </returns>
        public SqlCommand searchCharacters(string input) 
        {
            string query = "select DnDCharacter.id, jmeno, prijmeni, obrazek from DnDCharacter inner join DnDUser on DnDUser.id = DnDCharacter.id_user where jmeno like @input " +
                "or prijmeni like @input or DnDUser.username like @input";
            SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
            command.Parameters.Add(new("@input","%"+input+"%"));
            return command;
        }

        /// <summary>
        /// Vyhledává kostky
        /// </summary>
        /// <param name="input"> string podle kterého se vyhledává v databázi </param>
        /// <returns> command s vyhledáním </returns>
        public SqlCommand searchDice(string input) 
        {
            string query = "select id, nazev, kvantita, druh_kostky, mod_kostka from DnDkostka where nazev like @input";
            SqlCommand command = new SqlCommand(query, Singleton.GetInstance());
            command.Parameters.Add(new("@input", "%" + input + "%"));
            return command;
        }
    }
}
