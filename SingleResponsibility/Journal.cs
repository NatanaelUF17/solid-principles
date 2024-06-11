public class Journal
{
    private readonly List<string> _journals = [];
    private static int count = 0;

    public int AddJournal(string journal)
    {
        _journals.Add($"{++count}: {journal}");
        return count;
    }

    public void RemoveJournal(int index)
    {
        _journals.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, _journals);
    }
}