
internal class Relationships : IRelationshipBrowser
{
    private List<(Person, Relationship, Person)> relations = [];

    public void AddParentAndChild(Person parent, Person child)
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    }

    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
        return relations
            .Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent)
            .Select(x => x.Item3);
    }
}