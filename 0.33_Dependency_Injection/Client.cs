using System;

namespace _0._33_Dependency_Injection
{
    public class Client
    {
        private IService _service;

        public Client(IService service)
        {
            this._service = service;
        }

        public void Start()
        {
            Console.WriteLine("Service in Client");
            this._service.Serve();
        }
    }
}