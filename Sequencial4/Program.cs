using System;
using System.Globalization;
//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
//hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
//decimais.


namespace Sequencial4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero do funcionario: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira as horas trabalhadas: ");
            double workedHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor recebido por hora trabalhada: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = value * workedHours;
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Salary: " + salary.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
