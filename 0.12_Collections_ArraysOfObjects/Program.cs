using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_ArraysOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Country honduras = new Country("Honduras", "Tegucigalpa");
            Country bolivia = new Country("Bolivia", "Sucre");
            Country russia = new Country("Russia", "Moscow");
            Country japan = new Country("Japan", "Tokyo");

            russia.GiveBasics();


            //Check this out for using building an array of objects.

            Country[] countries = new Country[6];
            countries[0] = new Country("Guatemala", "Guatemala City");
            countries[1] = new Country("Peru", "Lima");
            countries[2] = new Country("The United States", "Washington D.C.");
            countries[3] = new Country("Spain", "Madrid");
            countries[4] = new Country("Pakistan", "Islamabad");
            countries[5] = new Country("Senegal", "Dakar");


            foreach (var country in countries)
            {
                country.GiveBasics();
            }

            Console.ReadLine();
        }
    }
}
