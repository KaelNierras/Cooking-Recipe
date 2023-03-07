using Cooking_Recipe;

public class Ingredient
{
    // Properties
    public string Name { get; set; }
    public Measurement Measurement { get; set; }

    // Constructor
    public Ingredient(string name, Measurement measurement)
    {
        this.Name = name;
        this.Measurement = measurement;
    }

    public override string ToString()
    {
        return this.Name + " " + this.Measurement;
    }
}
