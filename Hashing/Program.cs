using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();
          
            HashData hashData = new HashData();
            HmacData hmacData = new HmacData();
            bool start = false;
            while (!start)
            {
                Console.Clear();
                gui.PrintUI();
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        gui.PrintHashMenu();
                       userInput = int.Parse(Console.ReadLine());
                        string userString = null;
                        switch (userInput)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("type message to be encrypted with MD5 :");
                                userString = Console.ReadLine();
                                byte[] MD5 = hashData.ComputeHashMd5(Encoding.UTF8.GetBytes(userString));
                                Console.WriteLine("message hashed with MD5 :" + Convert.ToBase64String(MD5));
                                Thread.Sleep(7000);
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("type message to be encrypted with SHA1 :");
                                userString = Console.ReadLine();
                                byte[] SHA1 = hashData.ComputeHashSha1(Encoding.UTF8.GetBytes(userString));
                                Console.WriteLine("message hashed with SHA1 :" + Convert.ToBase64String(SHA1));
                                Thread.Sleep(7000);
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("type message to be encrypted with SHA2 256 bit :");
                                userString = Console.ReadLine();
                                byte[] SHA256bit = hashData.ComputeHashSha256(Encoding.UTF8.GetBytes(userString));
                                Console.WriteLine("message hashed with SHA2 256 bit :" + Convert.ToBase64String(SHA256bit));
                                Thread.Sleep(7000);
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("type message to be encrypted with SHA2 512 bit :");
                                userString = Console.ReadLine();
                                byte[] SHA512bit = hashData.ComputeHashSha512(Encoding.UTF8.GetBytes(userString));
                                Console.WriteLine("message hashed with SHA2 512 bit :" + Convert.ToBase64String(SHA512bit));
                                Thread.Sleep(7000);
                                break;
                        }

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("what encryption would you like to use");
                        gui.PrintHMACMenu();
                        userInput = int.Parse(Console.ReadLine());
                        byte[] key = null;
                        switch (userInput)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("type message to be encrypted with MD5 :");
                                key = hmacData.GenerateKey();
                                userString = Console.ReadLine();
                                byte[] MD5 = hmacData.ComputeHmacMD5(Encoding.UTF8.GetBytes(userString), key);
                                Console.WriteLine("message hashed with MD5 :" + Convert.ToBase64String(MD5) + " key used :" + hmacData.PrintOutKeyGenerated(key));
                                Thread.Sleep(7000);
                                break;

                            case 2:
                                Console.Clear();
                                Console.Write("type message to be encrypted with RIPEMD160 :");
                                key = hmacData.GenerateKey();
                                userString = Console.ReadLine();
                                byte[] ripeMd5 = hmacData.ComputeHmacRipeMd160(Encoding.UTF8.GetBytes(userString), key);
                                Console.WriteLine("message hashed with RIPEMD160 :" + Convert.ToBase64String(ripeMd5) + " key used :" +hmacData.PrintOutKeyGenerated(key));
                                Thread.Sleep(7000);
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("type message to be encrypted with SHA1 :");
                                key = hmacData.GenerateKey();
                                userString = Console.ReadLine();
                                byte[] SHA1 = hmacData.ComputeHmacSHA1(Encoding.UTF8.GetBytes(userString), key);
                                Console.WriteLine("message hashed with SHA1 :" + Convert.ToBase64String(SHA1) + " key used :" + hmacData.PrintOutKeyGenerated(key));
                                Thread.Sleep(7000);
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("type message to be encrypted with SHA2 256 bit :");
                                key = hmacData.GenerateKey();
                                userString = Console.ReadLine();
                                byte[] SHA256bit = hmacData.ComputeHmacSHA256(Encoding.UTF8.GetBytes(userString), key);
                                Console.WriteLine("message hashed with SHA2 256 bit :" + Convert.ToBase64String(SHA256bit) + " key used :" + hmacData.PrintOutKeyGenerated(key));
                                Thread.Sleep(7000);
                                break;

                            case 5:
                                Console.Clear();
                                Console.Write("type message to be encrypted with SHA2 384 bit :");
                                key = hmacData.GenerateKey();
                                userString = Console.ReadLine();
                                byte[] SHA384bit = hmacData.ComputeHmacSHA384(Encoding.UTF8.GetBytes(userString), key);
                                Console.WriteLine("message hashed with SHA2 384 bit :" + Convert.ToBase64String(SHA384bit) + " key used :" + hmacData.PrintOutKeyGenerated(key));
                                Thread.Sleep(7000);
                                break;
                            case 6:
                                Console.Clear();
                                Console.Write("type message to be encrypted with SHA2 512 bit :");
                                key = hmacData.GenerateKey();
                                userString = Console.ReadLine();
                                byte[] SHA512bit = hmacData.ComputeHmacSHA512(Encoding.UTF8.GetBytes(userString), key);
                                Console.WriteLine("message hashed with SHA2 512 bit :" + Convert.ToBase64String(SHA512bit) + " key used :" + hmacData.PrintOutKeyGenerated(key));
                                Thread.Sleep(7000);
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Enter a valid number");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                        }

                        break;

                    default:
                        start = false;
                        break;

                }
            }
        }
    }
}