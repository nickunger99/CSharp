using System;
using System.Globalization;

namespace Curso
{
    internal class ProgramPessoa
    {
        static void Main(string[] args)
        {
            // Ex Classe Pessoa
            Person p1 = new Person();
            Person p2 = new Person();
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.age = int.Parse(Console.ReadLine());

            if (p1.age > p2.age)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.name}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.name}");
            }

        }
    }
}