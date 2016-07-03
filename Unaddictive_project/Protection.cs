using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Unaddictive_project
{
    class Protection : AbstractReferee
    {
        public bool generate = false;
        public string shuffled;
        public string encrypt;
        private char[] eChars = {'@', '!', '#', '$', '%', '&'};
        private char[] bChars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private char[] sChars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private char[] nChars = {'1','2','3','4','5','6','7','8','9','0'};
        public override void Reference()
        {
            StringBuilder sB = new StringBuilder();
            Random rand = new Random();
            if (generate)
            {
                for (int i = 0; i < 8; i++)
                {
                    if(i == 0)
                    {
                        sB.Append(eChars[rand.Next(0, eChars.Length)]);
                    }
                    else if (i == 1)
                    {
                        sB.Append(bChars[rand.Next(0, bChars.Length)]);
                    }
                    else if (i > 1 && i < 5)
                    {
                        sB.Append(sChars[rand.Next(0, sChars.Length)]);
                    }
                    else if (i > 4)
                    {
                        sB.Append(nChars[rand.Next(0, nChars.Length)]);
                    }
                }
                shuffled = new string(sB.ToString().OrderBy(r => rand.Next()).ToArray());
                Debug.WriteLine(shuffled);
                Encryptor();
                SavePassword();
            }
        }
       
        public void Encryptor()
        {
             encrypt = StringEncrypter.Encrypt(shuffled, "wef");
            Debug.WriteLine(encrypt);
            string decrypt = StringEncrypter.Decrypt(encrypt, "wef");
            Debug.WriteLine(decrypt);
        }

        public void SavePassword()
        {
            File.AppendAllText(@"c:\temp\file.txt", "oi");
        }
    }
}
