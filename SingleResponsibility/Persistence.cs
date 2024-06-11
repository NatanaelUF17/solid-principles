public class Persistence
{
    public async void SaveToFile(Journal journal, string fileName, bool overwrite = false)
    {
        if (overwrite || !File.Exists(fileName))
        {
            await File.WriteAllTextAsync(fileName, journal.ToString());
        }
    }
}