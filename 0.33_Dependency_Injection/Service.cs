using System;

namespace _0._33_Dependency_Injection
{
    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Called");
        }
    }
}