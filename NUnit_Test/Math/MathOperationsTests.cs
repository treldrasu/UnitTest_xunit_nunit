namespace NUnit_Test.Math;

[TestFixture]
public class MathOperationsTests
{
    private MathOperations _mathOperations;

    [SetUp]
    public void Setup()
    {
        _mathOperations = new MathOperations();
    }

    [Test]
    public void Add_WhenCalled_ReturnsSum()
    {
        int result = _mathOperations.Add(2, 3);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtract_WhenCalled_ReturnsDifference()
    {
        int result = _mathOperations.Subtract(5, 3);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Multiply_WhenCalled_ReturnsProduct()
    {
        int result = _mathOperations.Multiply(4, 3);
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void Divide_WhenCalledWithNonZeroDivider_ReturnsQuotient()
    {
        double result = _mathOperations.Divide(10, 2);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Divide_WhenCalledWithZeroDivider_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _mathOperations.Divide(10, 0));
    }
}
