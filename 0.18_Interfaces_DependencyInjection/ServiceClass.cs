using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_DependencyInjection
{
    //TODO DI 4: Create this class that implements IService
    class ServiceClass : IService
    {
        public void Message()
        {
            //TODO DI 5: Provide this implementation.
            Console.WriteLine("Service message called");
        }
    }
}
