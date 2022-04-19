using System;


//Ler um número inteiro N e calcular todos os seus divisores.

namespace for6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor para descobrir os seus divisores:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Divisores: ");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
