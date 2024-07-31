using Xunit;

namespace CoffeeMachine;

public class CoffeeMachineTests
{
    private CoffeeMachine _coffeeMachine;

    public CoffeeMachineTests()
    {
        _coffeeMachine = new CoffeeMachine();
    }

    [Fact]
    public void BrewCoffee_ShouldReturnReadyMessage_WhenEnoughResources()
    {
        var result = _coffeeMachine.BrewCoffee(CoffeeType.Black, CupSize.Medium);

        Assert.Equal("Black in einer Medium Tasse ist fertig!", result);
    }
}

