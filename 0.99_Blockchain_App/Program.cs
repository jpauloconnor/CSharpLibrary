using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_Blockchain_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Key privateKey = new Key(); // generate a random private key
            PubKey publicKey = privateKey.PubKey;

            Console.WriteLine(publicKey.GetAddress(Network.Main)); // 1PUYsjwfNmX64wS368ZR5FMouTtUmvtmTY
            Console.WriteLine(publicKey.GetAddress(Network.TestNet)); // n3zWAo2eBnxLr3ueohXnuAa8mTVBhxmPhq

        }
    }
}
