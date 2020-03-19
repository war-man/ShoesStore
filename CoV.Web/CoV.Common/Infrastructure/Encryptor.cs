﻿using System;
using System.Security.Cryptography;
using System.Text;
//add keyderviation
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace CoV.Common.Infrastructure
{
    /// <summary>
    /// Encrypt data using .NET Cryptography Framework.
    /// </summary>
    public class Encryptor
    {
        readonly UTF8Encoding _enc;
        readonly RijndaelManaged _rcipher;
        readonly byte[] _key, _iv;
        byte[] _pwd, _ivBytes;

        /***
		 * Encryption mode enumeration
		 */
        private enum EncryptMode { Encrypt, Decrypt };

        static readonly char[] CharacterMatrixForRandomIvStringGeneration = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '_'
        };

        public Encryptor()
        {
            _enc = new UTF8Encoding();
            _rcipher = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 256,
                BlockSize = 128
            };
            _key = new byte[32];
            _iv = new byte[_rcipher.BlockSize / 8]; //128 bit / 8 = 16 bytes
            _ivBytes = new byte[16];
        }

        #region Hashing a string using Microsoft.AspNetCore.Cryptography.KeyDerivation allows us to use PBKDF2 which is far harder to brute force.
        /// <summary>
        /// Calculate hash
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CalculateHash(string input)
        {
            var salt = GenerateSalt(16);
            var bytes = KeyDerivation.Pbkdf2(input, salt, KeyDerivationPrf.HMACSHA512, 10000, 16);
            return $"{ Convert.ToBase64String(salt) }:{ Convert.ToBase64String(bytes) }";
        }

        /// <summary>
        /// Generate salt
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private static byte[] GenerateSalt(int length)
        {
            var salt = new byte[length];

            
            using (var random = RandomNumberGenerator.Create())
            {
                random.GetBytes(salt);
            }

            return salt;
        }

        /// <summary>
        /// Descrypt hash and check match
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool CheckMatch(string hash, string input)
        {
            try
            {
                var parts = hash.Split(':');
                var salt = Convert.FromBase64String(parts[0]);
                var bytes = KeyDerivation.Pbkdf2(input, salt, KeyDerivationPrf.HMACSHA512, 10000, 16);
                return parts[1].Equals(Convert.ToBase64String(bytes));
            }
            catch
            {
                return false;
            }
        }

        public static string Encrypt(string plainText, string encryptKey)
        {
            string iv = GetHashSha256(encryptKey, 16); //16 bytes = 128 bits
            string key = GetHashSha256(encryptKey, 32); //32 bytes = 256 bits
            return new Encryptor().Encrypt(plainText, key, iv);
        }

        public static string Decrypt(string plainText, string encryptKey)
        {
            string iv = GetHashSha256(encryptKey, 16); //16 bytes = 128 bits
            string key = GetHashSha256(encryptKey, 32); //32 bytes = 256 bits
            return new Encryptor().Decrypt(plainText, key, iv);
        }

        /**
		 * This function generates random string of the given input length.
		 * 
		 * @param _plainText
		 *            Plain text to be encrypted
		 * @param _key
		 *            Encryption Key. You'll have to use the same key for decryption
		 * @return returns encrypted (cipher) text
		 */
        public static string GenerateRandomIv(int length)
        {
            char[] iv = new char[length];
            byte[] randomBytes = new byte[length];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomBytes); //Fills an array of bytes with a cryptographically strong sequence of random values. 
            }

            for (int i = 0; i < iv.Length; i++)
            {
                int ptr = randomBytes[i] % CharacterMatrixForRandomIvStringGeneration.Length;
                iv[i] = CharacterMatrixForRandomIvStringGeneration[ptr];
            }

            return new string(iv);
        }

        /**
		 * 
		 * @param _inputText
		 *            Text to be encrypted or decrypted
		 * @param _encryptionKey
		 *            Encryption key to used for encryption / decryption
		 * @param _mode
		 *            specify the mode encryption / decryption
		 * @param _initVector
		 * 			  initialization vector
		 * @return encrypted or decrypted string based on the mode
	 	*/
        private String EncryptDecrypt(string inputText, string encryptionKey, EncryptMode mode, string initVector)
        {

            string _out = "";// output string
                             //_encryptionKey = MD5Hash (_encryptionKey);
            _pwd = Encoding.UTF8.GetBytes(encryptionKey);
            _ivBytes = Encoding.UTF8.GetBytes(initVector);

            int len = _pwd.Length;
            if (len > _key.Length)
            {
                len = _key.Length;
            }
            int ivLenth = _ivBytes.Length;
            if (ivLenth > _iv.Length)
            {
                ivLenth = _iv.Length;
            }

            Array.Copy(_pwd, _key, len);
            Array.Copy(_ivBytes, _iv, ivLenth);
            _rcipher.Key = _key;
            _rcipher.IV = _iv;

            if (mode.Equals(EncryptMode.Encrypt))
            {
                //encrypt
                byte[] plainText = _rcipher.CreateEncryptor().TransformFinalBlock(_enc.GetBytes(inputText), 0, inputText.Length);
                _out = Convert.ToBase64String(plainText);
            }
            if (mode.Equals(EncryptMode.Decrypt))
            {
                //decrypt
                byte[] plainText = _rcipher.CreateDecryptor().TransformFinalBlock(Convert.FromBase64String(inputText), 0, Convert.FromBase64String(inputText).Length);
                _out = _enc.GetString(plainText);
            }
            _rcipher.Dispose();
            return _out;// return encrypted/decrypted string
        }

        /**
		 * This function encrypts the plain text to cipher text using the key
		 * provided. You'll have to use the same key for decryption
		 * 
		 * @param _plainText
		 *            Plain text to be encrypted
		 * @param _key
		 *            Encryption Key. You'll have to use the same key for decryption
		 * @return returns encrypted (cipher) text
		 */
        public string Encrypt(string plainText, string key, string initVector)
        {
            return EncryptDecrypt(plainText, key, EncryptMode.Encrypt, initVector);
        }

        /***
		 * This funtion decrypts the encrypted text to plain text using the key
		 * provided. You'll have to use the same key which you used during
		 * encryprtion
		 * 
		 * @param _encryptedText
		 *            Encrypted/Cipher text to be decrypted
		 * @param _key
		 *            Encryption key which you used during encryption
		 * @return encrypted value
		 */

        public string Decrypt(string encryptedText, string key, string initVector)
        {
            return EncryptDecrypt(encryptedText, key, EncryptMode.Decrypt, initVector);
        }

        /***
		 * This function decrypts the encrypted text to plain text using the key
		 * provided. You'll have to use the same key which you used during
		 * encryption
		 * 
		 * @param _encryptedText
		 *            Encrypted/Cipher text to be decrypted
		 * @param _key
		 *            Encryption key which you used during encryption
		 */
        public static string GetHashSha256(string text, int length)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x); //covert to hex string
            }
            if (length > hashString.Length)
                return hashString;
            else
                return hashString.Substring(0, length);
        }

        public static byte[] Encrypt128(byte[] cryptBytes, byte[] iv, byte[] key)
        {
            // AesCryptoServiceProvider
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 128;
                aes.IV = iv;
                aes.Key = key;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                // encryption
                using (ICryptoTransform encrypt = aes.CreateEncryptor(key, iv))
                {
                    return encrypt.TransformFinalBlock(cryptBytes, 0, cryptBytes.Length);
                }
            }
        }

        /// <summary>
        /// AES decryption
        /// </summary>
        public static byte[] Decrypt128(byte[] cryptBytes, byte[] iv, byte[] key)
        {
            // AesCryptoServiceProvider
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 128;
                aes.IV = iv;
                aes.Key = key;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                // decryption
                using (ICryptoTransform decrypt = aes.CreateDecryptor(key, iv))
                {
                    return decrypt.TransformFinalBlock(cryptBytes, 0, cryptBytes.Length);
                }
            }
        }
    }
    #endregion
}
