using System;

// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
namespace Condicional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira qualquer valor para descobrir se é par ou impar: ");
            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.WriteLine("O valor digitado é Par!");
            }
            else
            {
                Console.WriteLine("O valor digitado é Impar!");
            }
        }
    }
}