using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_robinson_equality
{
    struct Pizza
    {
        public Pizza(string type)
        {
            this.Type = type;
        }
        public string Type { get; set; }
    }
}
