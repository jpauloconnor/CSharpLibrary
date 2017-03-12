using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_ArraysOfObjects
{
    public class Country
    {
        public Country(string name, string capital)  //Looks like a function. Has parameters. Same name as class.
        {
            this.Name = name;          //"Name" corresponds to getter/setter below & "name" attaches to the parameter
            this.Capital = capital;
        }

        public string Name { get; set; }
        public string Capital { get; set; }

        public void GiveBasics()
        {
            Console.WriteLine("The capital of {0} is {1}.", this.Name, this.Capital);  //That method that Scott did yesterday?
        }
    }
}
