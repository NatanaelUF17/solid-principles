internal class MultiFunctionMachine : IMultiFunctionDevice
{
    private readonly IPrinter printer;
    private readonly IScanner scanner;

    public MultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
        ArgumentNullException.ThrowIfNull(printer);
        ArgumentNullException.ThrowIfNull(scanner);
        this.printer = printer;
        this.scanner = scanner;
    }

    public void Print(Document document)
    {
        printer.Print(document);
    }

    public void Scan(Document document)
    {
        scanner.Scan(document);
    }
}