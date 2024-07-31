namespace CoffeeMachine;
public interface ICoffeeRecipeRepository
{
    CoffeeRecipe GetRecipe(CoffeeType coffeeType);
}

public class CoffeeRecipe
{
    public CoffeeType CoffeeType { get; set; }
    public int BeansRequired { get; set; }
    public int WaterRequired { get; set; }
    public bool RequiresMilk { get; set; }
    public int MilkRequired { get; set; }
}

