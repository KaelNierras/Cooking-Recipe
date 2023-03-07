using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking_Recipe
{
    public class Dessert : Recipe
    {
        public DessertType DessertType { get; set; }
        public int Calories { get; set; }
        public int SweetnessLevel { get; set; }

        public Dessert(string name, string description, List<Ingredient> ingredients, List<string> steps, int Servings, DessertType desserttype, int calories, int sweetnessLevel) : base(name, description, ingredients, steps, Servings)
        {
            DessertType = desserttype;
            this.Calories = calories;
            this.SweetnessLevel = sweetnessLevel;
        }
    }
}
