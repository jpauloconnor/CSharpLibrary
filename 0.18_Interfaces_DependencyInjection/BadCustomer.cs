using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_DependencyInjection
{
    //TODO 17 DI: Create a BadCustomer class that implements IService.
    class BadCustomer : IService
    {
        public void Message()
        {
            //TODO 18 DI: Create the implementation for the method.
            Console.WriteLine("You are a terrible customer");
        }
    }
}
