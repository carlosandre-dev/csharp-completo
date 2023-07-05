using HandsOn_Classes01;
using System.Globalization;

Rectangle rectangle = new Rectangle();

Console.WriteLine("Informe a largura e altura do retângulo: ");
rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA: " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO: " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL: " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

