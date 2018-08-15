using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_DependencyInjection
{
    class GoodCustomer : IService
    {
        public void Message()
        {
            Console.WriteLine("You are a fantastic customer. Please come back");
        }
    }
}
