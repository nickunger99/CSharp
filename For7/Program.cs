using System;

//Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
//começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
//exemplo.

namespace for7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor inteiro: ");

            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i <= value; i++)
            {
                int first = i;
                int second = i * i;
                int third = i * i * i;
                Console.WriteLine("{0} {1} {2}", first, second, third);
            }
        }
    }
}
