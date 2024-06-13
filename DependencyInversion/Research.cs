internal class Research
{
    internal Research(IRelationshipBrowser relationshipBrowser, Person parent)
    {
        foreach (var x in relationshipBrowser.FindAllChildrenOf(parent.Name))
        {
            Console.WriteLine($"{parent.Name} has a child called {x.Name}");
        }
    }
}