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

        public string encrypt(string _string)
        {
            SHA512Managed HashTool = new SHA512Managed();
            byte[] PhraseAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(_string));
            byte[] EncryptedBytes = HashTool.ComputeHash(PhraseAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }
    }
}
