using System;
using System.Security.Cryptography;
using System.Text;

namespace Hashing
{
    class HmacData
    {
        private const int KeySizes = 32;

        // method returns a random number that is 32 bytes
        public byte[] GenerateKey()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[KeySizes];

                rng.GetBytes(randomNumber);

                return randomNumber;
            }
        }

        // method used to print out the generated key
        public string PrintOutKeyGenerated(byte[] key)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte keyByte in key)
            {
                sb.Append(keyByte.ToString());
            }

            return sb.ToString();
        }

        // method returns the message encrypted with MD5 and a key
        public byte[] ComputeHmacMD5(byte [] toBeHashed, byte[] key)
        {
            using (HMACMD5 hmac = new HMACMD5(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        // method returns the message encrypted with SHA1 and a key
        public byte[] ComputeHmacSHA1(byte[] toBeHashed, byte[] key)
        {
            using (HMACSHA1 hmac = new HMACSHA1(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        // method returns the message encrypted with SHA256 and a key
        public byte[] ComputeHmacSHA256(byte[] toBeHashed, byte[] key)
        {
            using (HMACSHA256 hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        // method returns the message encrypted with SHA 384 and a key
        public byte[] ComputeHmacSHA384(byte[] toBeHashed, byte[] key)
        {
            using (HMACSHA384 hmac = new HMACSHA384(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        // method returns the message encrypted with SHA 512 and a key
        public byte[] ComputeHmacSHA512(byte[] toBeHashed, byte[] key)
        {
            using (HMACSHA512 hmac = new HMACSHA512(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }

        // method returns the message encrypted with RipeMD160 and a key
        public byte[] ComputeHmacRipeMd160(byte[] toBeHashed, byte[] key)
        {
            using (HMACRIPEMD160 hmac = new HMACRIPEMD160(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }
    }
}