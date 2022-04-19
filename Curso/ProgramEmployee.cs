using System;
using System.Globalization;

namespace Curso
{
    internal class ProgramEmployee
    {
        static void Main(string[] args)
        {

            // Ex Classe Funcionario

            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            e1.name = Console.ReadLine();
            Console.Write("Salario: ");
            e1.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            e2.name = Console.ReadLine();
            Console.Write("Salario: ");
            e2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (e1.salary + e2.salary) / 2;

            Console.WriteLine($"Salário Médio: {media.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}