using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Aes = System.Security.Cryptography.Aes;


namespace DnDProjekt
{
    internal class PasswordEncryption
    {
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

