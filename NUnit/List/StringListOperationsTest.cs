namespace NUnit_Test.List;

[TestFixture]
public class StringListOperationsTests
{
    private StringListOperations _stringListOperations;

    [SetUp]
    public void Setup()
    {
        _stringListOperations = new StringListOperations();
    }

    [Test]
    public void AddString_WhenCalled_AddsStringToList()
    {
        _stringListOperations.AddString("Hello");
        Assert.That(_stringListOperations.GetStringCount(), Is.EqualTo(1));
    }

    [Test]
    public void RemoveString_WhenCalled_RemovesStringFromList()
    {
        _stringListOperations.AddString("Hello");
        _stringListOperations.RemoveString("Hello");
        Assert.That(_stringListOperations.GetStringCount(), Is.EqualTo(0));
    }

    [Test]
    public void GetStringCount_WhenCalled_ReturnsCorrectCount()
    {
        _stringListOperations.AddString("Hello");
        _stringListOperations.AddString("World");
        Assert.That(_stringListOperations.GetStringCount(), Is.EqualTo(2));
    }

    [Test]
    public void RemoveString_WhenStringNotInList_ReturnsFalse()
    {
        bool result = _stringListOperations.RemoveString("NotInList");
        Assert.IsFalse(result);
    }
}
