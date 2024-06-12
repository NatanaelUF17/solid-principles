var photoCopier = new Photocopier();

var document = new Document
{
    Content = "I hate going to the office..."
};

photoCopier.Print(document);
photoCopier.Scan(document);

IPrinter printer = new Printer();
IScanner scanner = new Scanner();

var multiFunctionMachine = new MultiFunctionMachine(printer, scanner);

multiFunctionMachine.Print(document);
multiFunctionMachine.Scan(document);
