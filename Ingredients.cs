using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace RecipeApp
{
    class Ingredient
    {
        private string name;
        private double quantity;
        private string unit;

        public Ingredient(string name, double quantity, string unit)
        {
            this.name = name;
            this.quantity = quantity;
            this.unit = unit;
        }

        public void ScaleQuantity(double scaleFactor)
        {
            quantity *= scaleFactor;
        }

        public void ResetQuantity()
        {
            // Implement your logic to reset the quantity back to the original value
        }

        public override string ToString()
        {
            return name + ": " + quantity + " " + unit;
        }
    }
}
