// See https://aka.ms/new-console-template for more information

using System.Globalization;

string product_one = "Computador";
string product_two = "Mesa de escritório";

byte age = 42;
int code = 5290;
char gender = 'M';

double price_one = 2100.0;
double price_two = 650.50;
double measure = 53.234567;



Console.WriteLine("Produtos:");

Console.WriteLine($"{product_one}, cujo preço é $ {price_one.ToString("F2")}");
Console.WriteLine($"{product_two}, cujo preço é $ {price_two.ToString("F2")}");

Console.WriteLine();

Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {gender}");

Console.WriteLine();

Console.WriteLine("Medida com oito casas decimais: " + measure.ToString("F8"));
Console.WriteLine("Arredondando (três casas decimais): " + measure.ToString("F3"));
Console.WriteLine("Separador decimal invariant culture: " + measure.ToString("F3", CultureInfo.InvariantCulture));