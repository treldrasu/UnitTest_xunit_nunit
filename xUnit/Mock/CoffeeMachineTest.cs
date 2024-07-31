namespace UsingxUnit;
using Xunit;
using FakeItEasy;
using CoffeeMachine;

public class CoffeeMachineTests
{
    private CoffeeMachine _coffeeMachine;
    private ICoffeeRecipeRepository _recipeRepository;

    public CoffeeMachineTests()
    {
        _recipeRepository = A.Fake<ICoffeeRecipeRepository>();
        _coffeeMachine = new CoffeeMachine(_recipeRepository);
    }

    [Fact]
    public void BrewCoffee_ShouldReturnReadyMessage_WhenEnoughResources()
    {
        var recipe = new CoffeeRecipe
        {
            CoffeeType = CoffeeType.Black,
            BeansRequired = 10,
            WaterRequired = 20,
            RequiresMilk = false,
            MilkRequired = 0,
        };

        A.CallTo(() => _recipeRepository.GetRecipe(CoffeeType.Black)).Returns(recipe);
        var result = _coffeeMachine.BrewCoffee(CoffeeType.Black, CupSize.Medium);

        Assert.Equal("Black in einer Medium Tasse ist fertig!", result);
    }

    [Fact]
    public void BrewCoffee_ShouldReturnInsufficientFundsMessage_WhenBalanceIsLow()
    {
        var recipe = new CoffeeRecipe
        {
            CoffeeType = CoffeeType.Black,
            BeansRequired = 10,
            WaterRequired = 20,
            RequiresMilk = false,
            MilkRequired = 0,
        };

        A.CallTo(() => _recipeRepository.GetRecipe(CoffeeType.Black)).Returns(recipe);

        var result = _coffeeMachine.BrewCoffee(CoffeeType.Black, CupSize.Medium);

        Assert.Equal("Nicht genug Guthaben auf der Karte.", result);
    }

    [Fact]
    public void BrewCoffee_ShouldCallHeatMilk_WhenLatteIsSelected()
    {
        var recipe = new CoffeeRecipe
        {
            CoffeeType = CoffeeType.Latte,
            BeansRequired = 10,
            WaterRequired = 20,
            RequiresMilk = true,
            MilkRequired = 10,
        };

        A.CallTo(() => _recipeRepository.GetRecipe(CoffeeType.Latte)).Returns(recipe);

        var result = _coffeeMachine.BrewCoffee(CoffeeType.Latte, CupSize.Medium);

        Assert.Equal("Latte in einer Medium Tasse ist fertig!", result);
    }
}
