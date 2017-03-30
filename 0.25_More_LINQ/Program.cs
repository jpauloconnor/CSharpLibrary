using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._25_More_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() { VIN = "A1", Make = "Hyundai", Model = "Elantra", Price = 5000, Year = 2009 },
                new UsedCar() { VIN = "B2", Make = "Hyundai", Model = "Accent", Price = 3000, Year = 2010 },
                new UsedCar() { VIN = "C3", Make = "Ford", Model = "Tarus", Price = 7000, Year = 2010 },
                new UsedCar() { VIN = "D4", Make = "Ford", Model = "Escape", Price = 15000, Year = 2014 },
                new UsedCar() { VIN = "E5", Make = "BMW", Model = "55i", Price = 17000, Year = 2015 },
                new UsedCar() { VIN = "Z5", Make = "BMW", Model = "55i", Price = 7700, Year = 2007 },
                new UsedCar() { VIN = "Y6", Make = "Acura", Model = "TL", Price = 17000, Year = 2011 },
                new UsedCar() { VIN = "B9", Make = "Acura", Model = "MDX", Price = 9000, Year = 2002 },
                new UsedCar() { VIN = "U10", Make = "Toyota", Model = "4Runner", Price = 6000, Year = 2002 },
                new UsedCar() { VIN = "T2", Make = "Toyota", Model = "Camry", Price = 17000, Year = 2016 },
            };

            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            Console.WriteLine("LINQ without lambda: ");
            foreach (var bmw in bmws)
            {
                Console.WriteLine("The {0} {1} is a nice used car that costs: {2:C}", bmw.Year, bmw.Model, bmw.Price);
            }
            Console.WriteLine("");
            Console.WriteLine("This is the LINQ for cars less than $10000");

            var cheapCars = from car in usedCars
                            where car.Price < 10000
                            select car;
            foreach (var cheapCar in cheapCars)
            {
                Console.WriteLine("The {0} {1} is a nice cheap car that costs: {2:C}", cheapCar.Year, cheapCar.Model, cheapCar.Price);
            }

            Console.WriteLine("This is a LINQ looking for Hyundais under $15,000");

            var cheapHyundais = from car in usedCars
                                where car.Price < 15000 &&
                                car.Make == "Hyundai"
                                select car;
            foreach (var cheapHyundai in cheapHyundais)
            {
                Console.WriteLine("The {0} {1} is a nice cheap Hyundai that costs: {2:C}", cheapHyundai.Year, cheapHyundai.Model, cheapHyundai.Price);
            }

            Console.WriteLine("");
            Console.WriteLine("LINQ with Lambda");

            var bmwCars = usedCars.Where(car => car.Make == "BMW");
            foreach (var bmw in bmwCars)
            {
                Console.WriteLine("The {0} {1} is a nice used car that costs: {2:C}", bmw.Year, bmw.Model, bmw.Price);
            }

            Console.WriteLine("");
            Console.WriteLine("LINQ with Lambda");
            var toyotas = usedCars.Where(car => car.Make == "Toyota");
            foreach (var toyota in toyotas)
            {
                Console.WriteLine("The {0} {1} is a nice used car that costs: {2:C}", toyota.Year, toyota.Model, toyota.Price);

            }


            Console.ReadLine();
        }
    }

    class UsedCar
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
}
