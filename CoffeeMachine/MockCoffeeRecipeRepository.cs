using CoffeeMachine;

namespace CoffeeMachineProject;

public class MockCoffeeRecipeRepository : ICoffeeRecipeRepository
{
        private readonly Dictionary<CoffeeType, CoffeeRecipe> _recipes = new Dictionary<CoffeeType, CoffeeRecipe>
    {
        {
            CoffeeType.Black, new CoffeeRecipe
            {
                CoffeeType = CoffeeType.Black,
                BeansRequired = 10,
                WaterRequired = 20,
                RequiresMilk = false,
                MilkRequired = 0,
            }
        },
        {
            CoffeeType.Latte, new CoffeeRecipe
            {
                CoffeeType = CoffeeType.Latte,
                BeansRequired = 10,
                WaterRequired = 20,
                RequiresMilk = true,
                MilkRequired = 10,
            }
        }
    };

    public CoffeeRecipe GetRecipe(CoffeeType coffeeType)
    {
        return _recipes[coffeeType];
    }
}
