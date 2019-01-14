using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_DependencyInjection
{
    //TODO 1 DI: Create a Customer class.
    class Customer
    {
        //TODO 11 DI: Create this field for usage in the method below.
        private readonly IService _service;

        //TODO 10 DI: Create this constructor. Notice that it takes in something is of type IService.
        //What does this mean about interfaces? Interfaces can be a type.
        public Customer(IService service)
        {
            _service = service;
        }

        //TODO 12 DI: Create this method.
        public void SendMessage()
        {
            //TODO 13 DI: A console just to show it's been fired off.
            Console.WriteLine("SendMessage called");

            //TODO 14 DI: Depending on the Customer type that is passed to the constructor,
            // the message will change.
            _service.Message();
        }

    }
}
