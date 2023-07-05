using System;

namespace Classes
{
    internal class Program
    {
        static void Main(String[] args)
        {
            People p1, p2;
            p1 = new People();
            p2 = new People();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.name = Console.ReadLine();
            Console.WriteLine("Informe a idade da primeira pessoa: ");
            Console.Write("Idade: ");
            p1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            Console.Write("Nome: ");
            p1.name = Console.ReadLine();
            Console.WriteLine("Informe a idade da segunda pessoa: ");
            Console.Write("Idade: ");
            p1.age = int.Parse(Console.ReadLine());

            if(p1.age > p2.age)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.name}");
            } else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.name}");
            }


        }
    }
}

