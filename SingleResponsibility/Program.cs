using System.Diagnostics;

var journal = new Journal();

journal.AddJournal("I cried today");
journal.AddJournal("I ate a bug");

Console.WriteLine(journal);

var persistence = new Persistence();

try
{
    var fileName = "~/dev/personal-training/dotnet/SolidPrinciples/SingleResponsibility";
    persistence.SaveToFile(journal, fileName, true);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}