internal class ColorSpecification : ISpecification<Product>
{
    private readonly Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }

    public bool IsSatisfied(Product entity)
    {
        return entity.Color == _color;
    }
}