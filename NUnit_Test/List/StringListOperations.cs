namespace NUnit_Test.List;

public class StringListOperations
{
    private List<string> _strings = new List<string>();

    public void AddString(string str) => _strings.Add(str);
    public bool RemoveString(string str) => _strings.Remove(str);
    public int GetStringCount() => _strings.Count;
}