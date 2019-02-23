using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liphsoft.Crypto.Argon2;
using System.Security.Cryptography;
using System.IO;
using static project123.filekeeper;
using System.Windows.Forms;

namespace project123
{
    class crypto

    {

        public string HashIt(string given_pass, string mysalt)
        {
            var hasher = new PasswordHasher();
            string passtohash = given_pass + mysalt;
            string hashedPass = hasher.Hash(passtohash);
            return hashedPass;

        }
        public bool verify(string hash, string pass)
        {
            var hasher = new PasswordHasher();
            int y = 2;
            if (hasher.Verify(hash, pass) == true)
            {
                y = 1;
            }
            if
                (y != 1)
                return false;
            else
                return true;
        }

        public string GetSalt(int length)
        {
            //Create and populate random byte array
            byte[] randomArray = new byte[length];
            string randomString;

            //Create random salt and convert to string
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomArray);
            randomString = Convert.ToBase64String(randomArray);
            return randomString;
        }


        

            public  byte[] Encrypt(byte[] plain, string password, byte[] salt)
            {

                MemoryStream memoryStream;
                CryptoStream cryptoStream;
                Rijndael rijndael = Rijndael.Create();
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(password, salt);
                rijndael.Key = pdb.GetBytes(32);
                rijndael.IV = pdb.GetBytes(16);
                rijndael.Padding = PaddingMode.PKCS7;
                memoryStream = new MemoryStream();
                cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
                cryptoStream.Write(plain, 0, plain.Length);
                cryptoStream.Close();
                return memoryStream.ToArray();
            }

            public  byte[] Decrypt(byte[] cipher, string password, byte[] salt)
            {
                MemoryStream memoryStream;
                CryptoStream cryptoStream;
                Rijndael rijndael = Rijndael.Create();
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(password, salt);
                rijndael.Key = pdb.GetBytes(32);
                rijndael.IV = pdb.GetBytes(16);
                rijndael.Padding = PaddingMode.PKCS7;


                memoryStream = new MemoryStream();
                cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);

                cryptoStream.Write(cipher, 0, cipher.Length);
                cryptoStream.Close();
                return memoryStream.ToArray();



            }
        }
    }
public static class Encryptions
{

     private const int AES256KeySize = 256;

    public static byte[] RandomByteArray(int length)
    {

        byte[] result = new byte[length];

        using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
        {

            provider.GetBytes(result);

            return result;

        }

    }

    public static bool AESEncryptFile(string filePath, byte[] password)
    {

        byte[] salt = RandomByteArray(16);

        using (FileStream fs = new FileStream(filePath + ".enc", FileMode.Create))
        {

            var key = GenerateKey(password, salt);

            Array.Clear(password, 0, password.Length);   
            Array.Resize(ref password, 1);
            password = null;
            

            using (Aes aes = new AesManaged())
            {

                aes.KeySize = AES256KeySize;
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);
                aes.Padding = PaddingMode.ISO10126;
                aes.Mode = CipherMode.CBC;

                fs.Write(salt, 0, salt.Length);

                Array.Clear(salt, 0, salt.Length);
                Array.Resize(ref salt, 1);
                salt = null;

                using (CryptoStream cs = new CryptoStream(fs, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {

                    using (FileStream fsIn = new FileStream(filePath, FileMode.Open))
                    {

                        byte[] buffer = new byte[1];
                        int read;

                        key.Dispose();

                        try
                        {

                            while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cs.Write(buffer, 0, read);
                            }

                            cs.Close();
                            fs.Close();
                            fsIn.Close();

                            return true;

                        }
                        catch (Exception e)
                        {
                           return false;

                        }

                    }

                }

            }

        }

    }

    public static bool AESDecryptFile(string filePath, byte[] password)
    {

        byte[] salt = new byte[16];

        using (FileStream fsIn = new FileStream(filePath, FileMode.Open))
        {

            fsIn.Read(salt, 0, salt.Length);

            var key = GenerateKey(password, salt);

            Array.Clear(password, 0, password.Length);               
            Array.Resize(ref password, 1); 
            password = null;
            Array.Clear(salt, 0, salt.Length);
            Array.Resize(ref salt, 1);
            salt = null;


            using (Aes aes = new AesManaged())
            {

                aes.KeySize = AES256KeySize;
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);
                aes.Padding = PaddingMode.ISO10126;
                aes.Mode = CipherMode.CBC;

                using (CryptoStream cs = new CryptoStream(fsIn, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {

                    using (FileStream fsOut = new FileStream(filePath.Remove(filePath.Length - 4)+"decrypted", FileMode.Create))
                    {

                        byte[] buffer = new byte[1];
                        int read;

                        key.Dispose();

                        try
                        {

                            while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                            {

                                fsOut.Write(buffer, 0, buffer.Length);

                            }

                            cs.FlushFinalBlock();

                            fsOut.Close();
                            fsIn.Close();
                            cs.Close();

                            return true;

                        }
                        catch (Exception e)
                        {

                            return false;

                        }

                    }

                }

            }

        }

    }

    public static byte[] AESEncryptBytes(byte[] clear, byte[] password,byte[] salt)
    {
        
        byte[] encrypted = null;

        var key = GenerateKey(password, salt);
        Array.Clear(password, 0, password.Length);
        Array.Resize(ref password, 1);
        password = null;
        
        using (Aes aes = new AesManaged())
        {

            aes.KeySize = AES256KeySize;
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;

            using (MemoryStream ms = new MemoryStream())
            {

                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {

                    cs.Write(clear, 0, clear.Length);
                    cs.Close();

                }

                encrypted = ms.ToArray();

            }

            key.Dispose();

        }

        return encrypted;

    }

    public static byte[] AESDecryptBytes(byte[] encrypted, byte[] password, byte[] salt)
    {

        byte[] decrypted = null;

        var key = GenerateKey(password, salt);
        Array.Clear(password, 0, password.Length);
        Array.Resize(ref password, 1);
        password = null;
      

        using (Aes aes = new AesManaged())
        {

            aes.KeySize = AES256KeySize;
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;

            using (MemoryStream ms = new MemoryStream())
            {

                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {

                    cs.Write(encrypted, 0, encrypted.Length);
                    cs.Close();

                }

                decrypted = ms.ToArray();

            }

            key.Dispose();

        }

        return decrypted;

    }

    public static bool CheckPassword(byte[] password, byte[] salt, byte[] key)
    {

        using (Rfc2898DeriveBytes r = GenerateKey(password, salt))
        {

            byte[] newKey = r.GetBytes(AES256KeySize / 8);
            return newKey.SequenceEqual(key);

        }

    }

    public static Rfc2898DeriveBytes GenerateKey(byte[] password, byte[] salt)
    {

        return new Rfc2898DeriveBytes(password, salt, 52768);

    }

}


