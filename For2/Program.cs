using System;


//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
//essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
namespace for2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de numeros a serem lidos: ");
            int value = int.Parse(Console.ReadLine());
            int count_in = 0;
            int count_out = 0;

            for (int i = 0; i < value; i++)
            {
                Console.Write($"Numero {i + 1}/{value}: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    count_in++;
                }
                else
                {
                    count_out++;
                }
            }
            Console.WriteLine(count_in + "in");
            Console.WriteLine(count_out + "out");


        }
    }
}
