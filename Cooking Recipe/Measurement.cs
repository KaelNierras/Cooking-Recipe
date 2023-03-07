using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking_Recipe
{
    public class Measurement
    {
        // Properties
        public int Quantity { get; set; }
        public string Unit { get; set; }

        // Constructor
        public Measurement(int quantity, string unit)
        {
            this.Quantity = quantity;
            this.Unit = unit;
        }

        public override string ToString()
        {
            return "(" + this.Quantity + " " + this.Unit + ")";
        }
    }

}
