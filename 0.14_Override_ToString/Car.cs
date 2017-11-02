using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override_ToString
{
    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {

            return "Year: " + Year + "\n" +
                "Make: " + Make + "\n" +
                "Model: " + Model;
;
        }
    }
}
