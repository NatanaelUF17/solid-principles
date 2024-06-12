internal class Printer : IPrinter
{
    public void Print(Document document)
    {
        Console.WriteLine($"Printing document from multi function machine... {document.Content}");
    }
}