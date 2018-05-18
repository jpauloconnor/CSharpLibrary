using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._31_Equality_Struct_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kenn Pascascio", StudentGroup.Sophomore);
            Student student2 = new Student("Johnn Pascascio", StudentGroup.Senior);

            Console.WriteLine(student.Name == student2.Name);
            Console.WriteLine(student.Equals(student2)); //<----Works, but poor performance
            Console.WriteLine(student == student2);



        }
    }
}
