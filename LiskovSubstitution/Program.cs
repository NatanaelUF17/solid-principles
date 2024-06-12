
static int Area(Rectangle value) => value.Width * value.Height;

var rectangle = new Rectangle(2, 3);
Rectangle square = new Square();

Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

square.Width = 4;
square.Height = 4;

Console.WriteLine($"{square} has area {Area(square)}");