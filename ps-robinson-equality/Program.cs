using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ps_robinson_equality
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Quiz 2
             */

            //#1 
            Food candy = new Food("Candy Apples");
            Food fruit = new Food("Candy Apples");
            Console.WriteLine(candy.Equals(fruit));

            //#2
            string myChili = "Chili";
            string momsChili = "Chili";
            Console.WriteLine("#2: {0}", myChili.Equals(momsChili));

            //#3 
            Pizza pepperoni = new Pizza("Pepperonis");
            Pizza pepperoniTwo = new Pizza("Pepperoni");
            Console.WriteLine("#3: Pizza {0}", pepperoni.Equals(pepperoniTwo));

            //#4
            Food peppermint = new Food(null);
            Console.WriteLine("Peppermint {0}", peppermint.Equals(null));

            //#5
            Food prunes = new Food("Prunes");
            Food apricots = new Food("Apricots");

            Food moreApricots = apricots;

            Console.WriteLine("Ref Equals #1:{0}", ReferenceEquals(prunes, apricots));
            Console.WriteLine("Ref Equals #2:{0}", ReferenceEquals(prunes, prunes));
            Console.WriteLine("Ref Equals #3:{0}", ReferenceEquals(moreApricots, apricots));
            /*
            Quiz 1
            */

            //Equality check - Quiz 1
            string someFood = "chili";
            string otherFood = "Chili";

            Console.WriteLine(someFood.Equals(otherFood, StringComparison.OrdinalIgnoreCase));


            //Question 8
            int ouncesOfTomatoes = 6;
            int ouncesOfSquash = 6;
            bool ounceCmp = (ouncesOfSquash == ouncesOfTomatoes);
            //1
            Console.WriteLine(string.Format("compare ounces:       {0}", ounceCmp));

            bool objCmp = ((object)ouncesOfTomatoes == (object)ouncesOfSquash);
            //2
            Console.WriteLine(string.Format("compare objects     {0}", objCmp));

            bool itfCmp =
                ((IComparable<int>)ouncesOfTomatoes == (IComparable<int>)ouncesOfSquash);
            //3
            Console.WriteLine(string.Format("compare interfaces: {0}", itfCmp));


            Food apple = new Food("Apple");
            apple.Name = "Apple";

            Food anotherApple = new Food("Apple");
            anotherApple.Name = "Apple";

            Console.WriteLine(apple == anotherApple);

            apple.Weight = 6.000000023f;
            anotherApple.Weight = 6.000000091f;

            Console.WriteLine("Apple Weights:");
            Console.WriteLine(apple.Weight == anotherApple.Weight);
            
            
            //Equals Method
            //Food banana = new Food("banana");
            //Food chocolate = new Food("chocolate");
            
            ////Equals is a method that calls ==
            ////Equals evaluates reference equality

            //Console.WriteLine(banana.Equals(chocolate));
            Console.ReadLine();
        }
        //Equals is overrideable
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}

//Reference types
    // x == y - reference equality - same address
    // x == y - value equality - different address

//C# is reference equality
/*
Reference Equality is quick - same address?

Value is slow - check every field or property

    For strings == checks value equality

    1. Reference Types

    compare value types = true
    compare ref types two obj = false


     Casting valuetypes to interfaces boxes them.
     Then == does reference equality
     
     Cast to an interface....

    You have to know what == does for each type.....

    2. Multiple ways to compare values
    s == S  - Equal? C# says they are not

    Ignore Case?
    Password....

    Equality is not an absolute
        Equality is context-sensitive
    
    Database Records

    Floating Point
        Rule: You shouldn't use floating point for equality.
    



    Natural vs. Plugged-in Equality
*/