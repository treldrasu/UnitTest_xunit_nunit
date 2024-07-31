using UsingxUnit;

namespace xUnit_Test;

public class UnitTest1
{

    public readonly MathOperations _mathOperations;
    public UnitTest1(){
        //SUT
        _mathOperations = new MathOperations();
    }

    [Fact] // This attribute marks this method as a test.
    public void ShouldAddTwoNumbers()
    {
        // Arrange
        int a = 3;
        int b = 5;

        // Act
        int result = a + b;

        // Assert
        Assert.Equal(8, result); // Check if the result is as expected.
    }

    [Fact]
    public void MathOperations_Add_ReturnInt(){
        MathOperations mo = new MathOperations();
        int result = mo.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(1, 2, 3)]
    [InlineData(1, 5, 6)]
    public void MathOperations_Add_ReturnInt_2(int a, int b, int expected){
        MathOperations mo = new MathOperations();
        Assert.Equal(expected, mo.Add(a, b));
    }
}