var apple = new Product("Apple", Color.Red, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Huge);

Product[] products = [apple, house, tree];

var productFilter = new ProductFilter();

Console.WriteLine("Green products (old): ");
foreach (var product in productFilter.FilterByColor(products, Color.Green))
{
    Console.WriteLine($" - {product.Name} is green");
}

Console.WriteLine();

var betterFilter = new BetterFilter();
Console.WriteLine("Green products (new): ");
foreach (var product in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
{
    Console.WriteLine($" - {product.Name} is green");
}

Console.WriteLine();

Console.WriteLine("Huge blue products: ");
foreach (var product in betterFilter
    .Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Huge))))
{
    Console.WriteLine($" - {product.Name} is blue and huge");
}