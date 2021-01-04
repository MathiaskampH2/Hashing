using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Hashing
{
    class Gui
    {
        public void PrintUI()
        {
            Console.WriteLine("1. Hash");
            Console.WriteLine("2. HMAC");
        }

        public void PrintHashMenu()
        {
            Console.WriteLine("1. MD5");
            Console.WriteLine("2. SHA1");
            Console.WriteLine("3. SHA2 256 bit");
            Console.WriteLine("4. SHA2 512 bit");
           
        }

        public void PrintHMACMenu()
        {
            Console.WriteLine("1. MD5");
            Console.WriteLine("2. RIPEMD160");
            Console.WriteLine("3. SHA1");
            Console.WriteLine("4. SHA2 256 bit");
            Console.WriteLine("5. SHA2 384 bit");
            Console.WriteLine("6. SHA2 512 bit");
        }
    }
}