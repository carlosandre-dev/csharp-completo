// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Entre com seu nome completo:");
string name = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int room = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço do produto:");
double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
string[] data = Console.ReadLine().Split(' ');

string last_name = data[0];
int age = int.Parse(data[1]);
double height = double.Parse(data[2],CultureInfo.InvariantCulture);

Console.WriteLine(name);
Console.WriteLine(room);
Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(last_name);
Console.WriteLine(age);
Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
