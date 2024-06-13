internal class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first;
    private readonly ISpecification<T> _second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        _first = first;
        _second = second;
    }

    public bool IsSatisfied(T entity)
    {
        return _first.IsSatisfied(entity) && _second.IsSatisfied(entity);
    }
}