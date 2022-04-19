using System;


//Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
//X, se for o caso
namespace for1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor de X: ");
            int x = int.Parse(Console.ReadLine());
            if (x <= 1000)
            {
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Somente valor menor ou igual a 1000");
            }
        }
    }
}
