﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Aes = System.Security.Cryptography.Aes;


namespace DnDProjekt
{
    /// <summary>
    /// Třída, která krypruje hesla
    /// </summary>
    internal class PasswordEncryption
    {
        /// <summary>
        /// Kryptuje hesla
        /// </summary>
        /// <param name="passwd"> heslo </param>
        /// <param name="klic"> klíč </param>
        /// <param name="vektor"> vektor </param>
        /// <returns> zakryptované heslo </returns>
        public byte[] kryptovani(string passwd, byte[] klic, byte[] vektor)
        {
            byte[] kryptovanyText;
            using (Aes aes = Aes.Create())
            {
                ICryptoTransform ce = aes.CreateEncryptor(klic, vektor);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, ce, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(passwd);
                        }
                         
                        kryptovanyText = ms.ToArray();
                    }
                }
            }
            return kryptovanyText;
        }

        /// <summary>
        /// Odkryptuje heslo
        /// </summary>
        /// <param name="kryptovanyText"> kryprované heslo </param>
        /// <param name="klic"> klíč </param>
        /// <param name="vektor"> vektor </param>
        /// <returns>odkryptované heslo </returns>
        public string dekryptovani(byte[] kryptovanyText, byte[] klic, byte[] vektor)
        {
            string passwd = String.Empty;
            using (Aes aes = Aes.Create())
            {
                ICryptoTransform cd = aes.CreateDecryptor(klic, vektor);
                using (MemoryStream ms = new MemoryStream(kryptovanyText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, cd, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            passwd = sr.ReadToEnd();
                        }
                    }
                }
            }
            return passwd;
        }
    }
}

