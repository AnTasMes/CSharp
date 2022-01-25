using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace fotoStudio
{
    class accountInfo
    {
        private static string username;
        private static string password;
        private static string code = "program";
        private static string email;
        private static bool isAdmin;
        private static string[] imageIndex = new string[100];
        private static string changedUsername = "";
        private static string changedPwd = "";

        public static int[] index = new int[100];
        public static int counter = 0;

        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        public static string Code { get => code; set => code = value; }
        public static string Email { get => email; set => email = value; }
        public static bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public static string[] ImageIndex { get => imageIndex; set => imageIndex = value; }
        public static string ChangedPwd { get => changedPwd; set => changedPwd = value; }
        public static string ChangedUsername { get => changedUsername; set => changedUsername = value; }

        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "ProjektniCentar";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "ProjektniCentar";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
