internal interface ISpecification<T>
{
    bool IsSatisfied(T entity);
}