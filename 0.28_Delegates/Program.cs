using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._28_Delegates
{

    public delegate void DelegateExample(string message);

    // Declare a delegate.
    delegate void Printer(string s);

    class Program
    {
        static void Main(string[] args)
        {

            DelegateExample delVariable = DelegateExampleMethod;
            delVariable("Hey everyone");

            MethodWithCallback(3, 0, delVariable);


            MethodClass obj = new MethodClass();
            DelegateExample d1 = obj.Method1;
            DelegateExample d2 = obj.Method2;
            DelegateExample d3 = DelegateExampleMethod;

            //Both types of assignment are valid.
            DelegateExample allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;

            d1("D1");
            d1("D1");
            d2("D2");

            int invocationCount = d1.GetInvocationList().GetLength(0);
            int invocationCountTwo = d2.GetInvocationList().GetLength(0);
            int invocationCountThree = allMethodsDelegate.GetInvocationList().GetLength(0);


            Console.WriteLine(invocationCount);
            Console.WriteLine(invocationCountTwo);
            Console.WriteLine(invocationCountThree);




            // Instantiate the delegate type using an anonymous method.
            Printer p = delegate (string j)
            {
                System.Console.WriteLine(j);
            };

            // Results from the anonymous delegate call.
            p("The delegate using the anonymous method is called.");

            // The delegate instantiation using a named method "DoWork".
            p = new Printer(Program.DoWork);

            // Results from the old style delegate call.
            p("The delegate using the named method is called.");




            Console.ReadLine();


        }

        // Create a method for a delegate.
        public static void DelegateExampleMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void MethodWithCallback(int param1, int param2, DelegateExample callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        public class MethodClass
        {
            public void Method1(string message) { Console.WriteLine(message); }
            public void Method2(string message) { Console.WriteLine("Method 2: ", message); }
        }

        // The method associated with the named delegate.
        static void DoWork(string k)
        {
            Console.WriteLine("Some stuff: ", k);
        }
    }
}
