using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CrmAppSchool.Controllers
{
    public class EncryptieController
    {

        public string[] encrypt(string plainwachtwoord, string salt = "")
        {
            string[] hashedwachtwoord = new string[2];

            if (salt == "")
            {
                // voor het inserten/updaten van een nieuw wachtwoord
                hashedwachtwoord[0] = maakSalt();
            }
            else
            {
                // voor het inloggen
                hashedwachtwoord[0] = salt;
            }

            hashedwachtwoord[1] = hashWachtwoord(hashedwachtwoord[0], plainwachtwoord);
            return hashedwachtwoord;
        }


        private string maakSalt()
        {
            // maakt 512 random bytes en returnt ze als een string van 88 karakters
            byte[]saltkey = new byte[64];
            new RNGCryptoServiceProvider().GetBytes(saltkey);
            return Convert.ToBase64String(saltkey);
        }
        
        private string hashWachtwoord(string salt, string wachtwoord)
        {
            // maakt van de salt en het wachtwoord een hashed wachtwoord
            SHA512Managed HashTool = new SHA512Managed();
            byte[] WachtwoordInByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(wachtwoord, salt));
            byte[] GehashdeBytes = HashTool.ComputeHash(WachtwoordInByte);
            HashTool.Clear();
            return Convert.ToBase64String(GehashdeBytes);
        }
    }
}
