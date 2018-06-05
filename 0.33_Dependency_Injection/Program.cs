using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._33_Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new Service());
            client.Start();

            //Client clientToo = new Client(new Bank());
            //clientToo.Start();

            Console.ReadKey();
        }
    }
}
