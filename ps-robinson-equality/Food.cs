using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_robinson_equality
{
    public class Food
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        
        public Food(string name)
        {
            this.Name = name;
        }
    }
}
