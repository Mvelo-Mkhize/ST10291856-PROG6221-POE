using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    class RecipeManager
    {
        private List<Recipe> recipes;

        public RecipeManager()
        {
            recipes = new List<Recipe>();
        }

        public void EnterAndSaveRecipe()
        {
            if (recipes.Count >= 9999)
            {
                Console.WriteLine("Maximum number of recipes reached. Cannot save more recipes.");
                return;
            }

            Console.WriteLine("Enter the name of the recipe: ");
            string name = Console.ReadLine();

            Console.WriteLine("Input the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            List<Ingredient> ingredients = new List<Ingredient>();

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine("Enter the name of ingredient {0}: ", i + 1);
                string ingredientName = Console.ReadLine();

                Console.WriteLine("Input the quantity of ingredient: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.WriteLine("Input the unit of measurement: ");
                string unit = Console.ReadLine();

                Ingredient ingredient = new Ingredient(ingredientName, quantity, unit);
                ingredients.Add(ingredient);
            }

            Console.WriteLine("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            List<string> steps = new List<string>();

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine("Enter step {0}: ", i + 1);
                string step = Console.ReadLine();
                steps.Add(step);
            }

            Recipe recipe = new Recipe(name, ingredients, steps);
            recipes.Add(recipe);

            Console.WriteLine("Recipe has been saved successfully.");
        }

        public void DisplaySavedRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipe found. Please enter and save recipe first.");
            }
            else
            {
                Console.WriteLine("Saved Recipes:");
                foreach (Recipe recipe in recipes)
                {
                    Console.WriteLine(recipe.ToString());
                }
            }
        }

        public void ScaleRecipe()
        {
            Console.WriteLine("Enter scale factor (0.5, 2, or 3): ");
            double scaleFactor = double.Parse(Console.ReadLine());

            foreach (Recipe recipe in recipes)
            {
                recipe.ScaleQuantities(scaleFactor);
            }

            Console.WriteLine("Recipe scaled successfully.");
        }

        public void ResetQuantities()
        {
            foreach (Recipe recipe in recipes)
            {
                recipe.ResetQuantities();
            }

            Console.WriteLine("Quantities reset successfully.");
        }

        public void ClearAllRecipeData()
        {
            recipes.Clear();
            Console.WriteLine("All recipe data cleared successfully.");
        }
    }
}
