namespace UsingxUnit.Test;

public class UnitTest1
{

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

}