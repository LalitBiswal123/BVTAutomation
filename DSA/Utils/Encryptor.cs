using System;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using Dsa.Constants;

namespace Dsa.Utils
{
    public static class Encryptor
    {
        public static string EncryptString(string stringToEncrypt)
        {
            try
            {
                byte[] input = Encoding.UTF8.GetBytes(stringToEncrypt);
                AesManaged aesManaged = new AesManaged();
                aesManaged.Key = Encoding.UTF8.GetBytes(EncryptorKey.getKeyForEncryption());
                aesManaged.Padding = PaddingMode.ISO10126;
                aesManaged.Mode = CipherMode.ECB;
                ICryptoTransform transform = aesManaged.CreateEncryptor();
                byte[] resultArray = transform.TransformFinalBlock(input, 0, input.Length);
                aesManaged.Clear();
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch(Exception ex)
            {
                Logger.Write(ex.Message);
                throw;
            }
        }

        public static string DecryptString(this string stringToDecrypt)
        {
            try
            {
                byte[] input = Convert.FromBase64String(stringToDecrypt);
                AesManaged aesManaged = new AesManaged();
                aesManaged.Key = Encoding.UTF8.GetBytes(EncryptorKey.getKeyForEncryption());
                aesManaged.Padding = PaddingMode.ISO10126;
                aesManaged.Mode = CipherMode.ECB;
                ICryptoTransform transform = aesManaged.CreateDecryptor();
                byte[] resultArray = transform.TransformFinalBlock(input, 0, input.Length);
                aesManaged.Clear();
                return Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception ex)
            {
                Logger.Write(ex.Message);
                throw;
            }
        }
    }
}