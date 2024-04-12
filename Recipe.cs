using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace RecipeApp
{
    class Recipe
    {
        private string name;
        private List<Ingredient> ingredients;
        private List<string> steps;

        public Recipe(string name, List<Ingredient> ingredients, List<string> steps)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.steps = steps;
        }

        public void ScaleQuantities(double scaleFactor)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.ScaleQuantity(scaleFactor);
            }
        }

        public void ResetQuantities()
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.ResetQuantity();
            }
        }
        public override string ToString()
        {
            string recipeString = "Name: " + name + "\n";
            recipeString += "Ingredients:\n";

            foreach (Ingredient ingredient in ingredients)
            {
                recipeString += "- " + ingredient.ToString() + "\n";
            }

            recipeString += "Steps:\n";

            for (int i = 0; i < steps.Count; i++)
            {
                recipeString += (i + 1) + ". " + steps[i] + "\n";
            }

            return recipeString;
        }
    }
}
