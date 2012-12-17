using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Xdgk.Common
{
    public class FileEncryptor
    {
        /// <summary>
        /// 
        /// </summary>
        private FileEncryptor()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool DecryptFile(string filename, string password)
        {
            try
            {
                int num;
                string path = filename + ".enc";
                password = normalizePassword(password);
                byte[] bytes = new UnicodeEncoding().GetBytes(password);
                FileStream stream = new FileStream(filename, FileMode.Open);
                RijndaelManaged managed = new RijndaelManaged();
                CryptoStream stream2 = new CryptoStream(stream, managed.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
                FileStream stream3 = new FileStream(path, FileMode.Create);
                while ((num = stream2.ReadByte()) != -1)
                {
                    stream3.WriteByte((byte)num);
                }
                stream3.Close();
                stream2.Close();
                stream.Close();
                return RenameEncryptedToOriginal(filename, path);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool EncryptFile(string filename, string password)
        {
            try
            {
                int num;
                string encryptedFileName = filename + ".enc";
                password = normalizePassword(password);
                byte[] bytes = new UnicodeEncoding().GetBytes(password);
                string path = encryptedFileName;
                FileStream stream = new FileStream(path, FileMode.Create);
                RijndaelManaged managed = new RijndaelManaged();
                CryptoStream stream2 = new CryptoStream(stream, managed.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
                FileStream stream3 = new FileStream(filename, FileMode.Open);
                while ((num = stream3.ReadByte()) != -1)
                {
                    stream2.WriteByte((byte)num);
                }
                stream3.Close();
                stream2.Close();
                stream.Close();
                return RenameEncryptedToOriginal(filename, encryptedFileName);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unNormalizedPassword"></param>
        /// <returns></returns>
        private static string normalizePassword(string unNormalizedPassword)
        {
            string str = unNormalizedPassword;
            if (str.Length > 8)
            {
                return str.Substring(0, 8);
            }
            if (str.Length < 8)
            {
                int num = 8 - str.Length;
                for (int i = 0; i < num; i++)
                {
                    str = str + i;
                }
            }
            return str;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="originalFileName"></param>
        /// <param name="encryptedFileName"></param>
        /// <returns></returns>
        private static bool RenameEncryptedToOriginal(string originalFileName, string encryptedFileName)
        {
            try
            {
                File.Delete(originalFileName);
                File.Move(encryptedFileName, originalFileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
