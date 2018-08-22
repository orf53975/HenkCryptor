using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace encryption
{
    public static class Encryption
    {
        public static byte[] CreateKey(SymmetricAlgorithm Algorithm, string Password, int KeySize = 0, string Salt = "YourSalt")
        {
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(Password, Encoding.UTF8.GetBytes(Salt));
            if (KeySize <= 0) { return key.GetBytes(Algorithm.Key.Length); }
            else { return key.GetBytes(KeySize); }
        }

        public static string Encrypt(SymmetricAlgorithm Algorithm, string Text, string Password) { return Encrypt(Algorithm, Text, CreateKey(Algorithm, Password)); }
        public static string Encrypt(SymmetricAlgorithm Algorithm, string Text, byte[] Key) { return Convert.ToBase64String(Encrypt(Algorithm, Encoding.UTF8.GetBytes(Text), Key)); }
        public static byte[] Encrypt(SymmetricAlgorithm Algorithm, byte[] Data, string Password) { return Encrypt(Algorithm, Data, CreateKey(Algorithm, Password)); }
        public static byte[] Encrypt(SymmetricAlgorithm Algorithm, byte[] Data, byte[] Key)
        {
            Algorithm.Key = Key;
            Algorithm.GenerateIV();

            using (var ms = new MemoryStream())
            {
                ms.Write(Algorithm.IV, 0, Algorithm.IV.Length);
                using (var cs = new CryptoStream(ms, Algorithm.CreateEncryptor(Algorithm.Key, Algorithm.IV), CryptoStreamMode.Write))
                {
                    cs.Write(Data, 0, Data.Length);
                    cs.FlushFinalBlock();
                }
                return ms.ToArray();
            }
        }

        public static string Decrypt(SymmetricAlgorithm Algorithm, string Text, string Password) { return Decrypt(Algorithm, Text, CreateKey(Algorithm, Password)); }
        public static string Decrypt(SymmetricAlgorithm Algorithm, string Text, byte[] Key) { return Encoding.UTF8.GetString(Decrypt(Algorithm, Convert.FromBase64String(Text), Key)); }
        public static byte[] Decrypt(SymmetricAlgorithm Algorithm, byte[] Data, string Password) { return Decrypt(Algorithm, Data, CreateKey(Algorithm, Password)); }
        public static byte[] Decrypt(SymmetricAlgorithm Algorithm, byte[] Data, byte[] Key)
        {
            Algorithm.Key = Key;
            using (var ms = new MemoryStream(Data))
            {
                byte[] iv = new byte[Algorithm.IV.Length];
                ms.Read(iv, 0, iv.Length);
                Algorithm.IV = iv;

                using (var cs = new CryptoStream(ms, Algorithm.CreateDecryptor(Algorithm.Key, Algorithm.IV), CryptoStreamMode.Read))
                {
                    byte[] decrypted = new byte[Data.Length];
                    var byteCount = cs.Read(decrypted, 0, Data.Length);
                    return new MemoryStream(decrypted, 0, byteCount).ToArray();
                }
            }
        }
    }
}
/*
using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace encryption
{
    class aes_256_iv
    {
        /*
        public static byte[] CreateKey(SymmetricAlgorithm algorithm,string password, string salt = "HenkChat")
        {
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt));
            return key.GetBytes(algorithm.Key.Length);
        }

        public static string Encrypt(string text, string key)
        {
           return Encrypt(text, CreateKey(key));
        }
        public static string Encrypt(string text, byte[] key, SymmetricAlgorithm algorithm)
        {
            byte[] BytesToEncrypt = Encoding.UTF8.GetBytes(text);

            using (var provider = Aes.Create())
            {
                provider.Key = key;
                provider.GenerateIV();

                using (var encryptor = provider.CreateEncryptor(provider.Key, provider.IV))
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(provider.IV, 0, 16);
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(BytesToEncrypt, 0, BytesToEncrypt.Length);
                            cs.FlushFinalBlock();
                        }
                        return Convert.ToBase64String(ms.ToArray()).Replace("\\","}").Replace("/","{");
                    }
                }
            }
        }

        public static string Decrypt(string text, string key)
        {
            return Decrypt(text, CreateKey(key));
        }
        public static string Decrypt(string text, byte[] key)
        {
            text = text.Replace("}", "\\").Replace("{", "/");
            byte[] EncryptedBytes = Convert.FromBase64String(text);

            using (var provider = Aes.Create())
            {
                provider.Key = key;
                using (var ms = new MemoryStream(EncryptedBytes))
                {
                    byte[] iv = new byte[16];
                    ms.Read(iv, 0, 16);
                    provider.IV = iv;

                    using (var decryptor = provider.CreateDecryptor(provider.Key, provider.IV))
                    {
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            byte[] decrypted = new byte[EncryptedBytes.Length];
                            var byteCount = cs.Read(decrypted, 0, EncryptedBytes.Length);
                            return Encoding.UTF8.GetString(decrypted, 0, byteCount);
                        }
                    }
                }
            }
        }

    }
}
*/