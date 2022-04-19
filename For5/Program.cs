using System;


//Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
//6Lembrando que, por definição, fatorial de 0 é 1.
namespace for5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor para descobrir o seu fatorial!");
            int number = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= number; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);

        }
    }
}
