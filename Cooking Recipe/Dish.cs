using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking_Recipe
{
    public class Dish : Recipe
    { 
        public DishType DishType { get; set; }
        public int CookingTime { get; set; }
        public int PreparationTime { get; set; }

        public Dish(string name, string description, List<Ingredient> ingredients, List<string> steps, int servings,DishType dishtype, int cookingtime, int preparationTime) : base(name, description, ingredients, steps)
        {
            this.DishType = dishtype;
            this.CookingTime = cookingtime;
            this.PreparationTime = preparationTime;
        }
    }
}
