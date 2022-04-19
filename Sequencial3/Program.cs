using System;

//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)


namespace Sequencial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor C: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor D: ");
            int D = int.Parse(Console.ReadLine());

            int result = A * B - C * D;

            Console.WriteLine($"Diferença = {result}");
        }
    }
}
