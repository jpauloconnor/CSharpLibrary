using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example based on the MSDN docs: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override

            // Create some new employees.
            SalesPerson employee1 = new SalesPerson("Alice", 1000, 500);
            Employee employee2 = new Employee("Bob", 1200);
            Executive employee3 = new Executive("John the President", 10000, 400.52);

            Console.WriteLine("Employee4 " + employee1.name + " earned: " + employee1.CalculatePay());
            Console.WriteLine("Employee4 " + employee2.name + " earned: " + employee2.CalculatePay());
            Console.ReadLine();

        }
    }
}

