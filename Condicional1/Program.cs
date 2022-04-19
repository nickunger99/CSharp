using System;


// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
namespace Condicional1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor inteiro: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não Negativo");
            }
        }
    }
}