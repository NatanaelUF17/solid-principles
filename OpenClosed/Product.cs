internal class Product
{
    public string Name;
    public Color Color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        ArgumentNullException.ThrowIfNull(name);
        Name = name;
        Color = color;
        Size = size;
    }
}