using System;
using System.Globalization;
//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
//casas decimais conforme exemplos.

namespace Sequencial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor do raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("Area = " + area.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}
