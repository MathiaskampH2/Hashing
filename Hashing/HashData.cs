using System.Security.Cryptography;
using System.Text;

namespace Hashing
{
    class HashData
    {
        // method returns a byte array which has been hashed with MD5 encryption
        public byte[] ComputeHashMd5(byte[] toBeHashed)
        {
            using (MD5 md5 = MD5.Create())
            {
                return md5.ComputeHash(toBeHashed);
            }
        }

        // method returns a byte array which has been hashed with SHA1 encryption
        public byte[] ComputeHashSha1(byte [] toBeHashed)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(toBeHashed);
            }
        }
        // method returns a byte array which has been hashed with sha256 encryption
        public byte[] ComputeHashSha256(byte[] toBeHashed)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(toBeHashed);
            }
        }

        // method returns a byte array which has been hashed with sha 512 encryption
        public byte[] ComputeHashSha512(byte[] toBeHashed)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(toBeHashed);
            }
        }
    }
}