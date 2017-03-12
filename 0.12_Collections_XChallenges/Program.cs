using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_XChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneList = new List<string>();
            phoneList.Add("317.555.0001");
            phoneList.Add("317.555.0002");
            phoneList.Add("317.555.0003");
            phoneList.Add("317.555.0004");
            phoneList.Add("317.555.0005");
            phoneList.Add("317.555.0006");
            phoneList.Add("317.555.0007");
            phoneList.Add("317.555.0008");
            phoneList.Add("317.555.0009");
            phoneList.Add("317.555.0010");

            for (var i = 0; i < phoneList.Count; i++)
            {
                Console.WriteLine(phoneList[i]);
            }

            for (var i = 0; i < phoneList.Count; i++)
            {
                Console.WriteLine("Paul's phone number is {0}", phoneList.ElementAt(4));
            }
            /*
            for (var i = 0; i < phoneList.Count; i++)
            {
                Console.WriteLine(phoneList.OrderByDescending(true));
                Console.WriteLine(phoneList.RemoveAt(2));

            }
            */
        }
    }
}
