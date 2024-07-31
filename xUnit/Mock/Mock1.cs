using CoffeeMachineProject;
using Xunit;

namespace CoffeeMachine;

public class CoffeeMachineTests
{
    private CoffeeMachine _coffeeMachine;
    private MockCoffeeRecipeRepository _recipeRepository;

    public CoffeeMachineTests()
    {
        _recipeRepository = new MockCoffeeRecipeRepository();
        _coffeeMachine = new CoffeeMachine(_recipeRepository);
    }

    [Fact]
    public void BrewCoffee_ShouldReturnReadyMessage_WhenEnoughResources()
    {
        var result = _coffeeMachine.BrewCoffee(CoffeeType.Black, CupSize.Medium);

        Assert.Equal("Black in einer Medium Tasse ist fertig!", result);
    }
}

