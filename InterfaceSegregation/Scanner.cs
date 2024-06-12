internal class Scanner : IScanner
{
    public void Scan(Document document)
    {
        Console.WriteLine($"Scanning document from the multi function machine... {document.Content}");
    }
}