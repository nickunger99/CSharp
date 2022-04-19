using System;
using System.Globalization;

//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
//código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

namespace Sequencial5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o codigo da peça 1: ");
            int code1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças 1: ");
            int amounts1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitario de cada peça 1: ");
            double value1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Insira o codigo da peça 2: ");
            int code2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de peças 2: ");
            int amounts2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor unitario de cada peça 2: ");
            double value2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = amounts1 * value1 + amounts2 * value2;
            Console.WriteLine(result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}