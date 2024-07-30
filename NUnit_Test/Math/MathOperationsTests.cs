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

    public void Add_WhenCalled_ReturnsSum()
    {
        int result = _mathOperations.Add(2, 3);
        Assert.That(result, Is.EqualTo(5));
    }
}
