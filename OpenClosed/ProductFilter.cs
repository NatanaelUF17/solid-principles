internal class ProductFilter
{
    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach (var product in products)
        {
            if (product.Size == size)
            {
                yield return product;
            }
        }
    }

    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach (var product in products)
        {
            if (product.Color == color)
            {
                yield return product;
            }
        }
    }

    public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Color color, Size size)
    {
        foreach (var product in products)
        {
            if (product.Color == color && product.Size == size)
            {
                yield return product;
            }
        }
    }
}