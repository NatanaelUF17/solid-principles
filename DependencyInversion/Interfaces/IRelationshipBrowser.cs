internal interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}