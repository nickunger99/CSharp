using System;
using System.Globalization;

//Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
//segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

namespace for4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de divisões a serem realizadas: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                Console.Write("Insira os 2 valores a serem calculados: ");
                string[] numbers = Console.ReadLine().Split(' ');
                int x = int.Parse(numbers[0]);
                int y = int.Parse(numbers[1]);

                if (y == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine($"Resultado: {div.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
