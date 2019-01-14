using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_DependencyInjection
{
    //TODO 6 DI: Create this class that implements IService.
    class GoodCustomer : IService
    {
        public void Message()
        {
            //TODO 7 DI: Provide the implementation for this method. 
            Console.WriteLine("You are a fantastic customer. Please come back");
        }
    }
}
