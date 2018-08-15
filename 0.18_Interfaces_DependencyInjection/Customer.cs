using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_DependencyInjection
{
    class Customer
    {
        private readonly IService _service;

        public Customer(IService service)
        {
            _service = service;
        }

        public void SendMessage()
        {
            Console.WriteLine("SendMessage called");
            _service.Message();
        }

    }
}
