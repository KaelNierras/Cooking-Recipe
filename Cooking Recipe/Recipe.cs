public abstract class Recipe
{
    // Properties
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public List<string> Steps { get; set; }
    public int Servings { get; set; }

    // Constructor
    public Recipe(string name, string description, List<Ingredient> ingredients, List<string> steps, int servings)
    {
        this.Name = name;
        this.Description = description;
        this.Ingredients = ingredients;
        this.Steps = steps;
        this.Servings = servings;

    }

}

