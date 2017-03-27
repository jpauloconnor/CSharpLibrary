using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Demo for protected, private, etc.
namespace _0._10_AccessModifiers
{
    public class Car
    {
        //Protected allows our properties only accessible to our child classes.
        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }

        public string CarDetails()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}";
        }

    }

    public class Acura : Car
    {
        //The private protects our variable from being changed without creating an object
        private int price;
        public Acura(string model, int year, int price = 20000)
        {
            this.Make = "Acura";
            this.Model = model;
            this.Year = year;
            this.price = price;
        }

        public void AcuraDetails()
        {
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nPrice: {price}");
        }
    }
}


/******Keyword***************Applicable To***************Meaning******************************************		
        public 				  Class, Member				No restrictions
        protected			  Member					Access limited to the class and derived classes
        private				  Member					Access limited to the class.

        internal              Class, Member				Access limited to the current assembly		
    protected internal 		  Member					Access limited to current assembly and derived types

**********************************************************************************************************/

