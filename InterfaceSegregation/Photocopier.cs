internal class Photocopier : IPrinter, IScanner
{
    public void Print(Document document)
    {
        Console.WriteLine($"Printing content from the photocopier: {document.Content}");
    }

    public void Scan(Document document)
    {
        Console.WriteLine($"Scanning content from the photocopier: {document.Content}");
    }
}