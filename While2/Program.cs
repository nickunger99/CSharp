using System;


//Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
//cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
//menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma)

namespace While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os valores das coordenadas X e Y para descobrir o quadrante: ");
            string[] values = Console.ReadLine().Split(' ');
            int X = int.Parse(values[0]);
            int Y = int.Parse(values[1]);

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("Quadrante 1");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Quadrante 2");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("Quadrante 3");
                }
                else
                {
                    Console.WriteLine("Quadrante 4");

                }
                Console.WriteLine("Insira os valores das coordenadas X e Y para descobrir o quadrante: ");
                values = Console.ReadLine().Split(' ');
                X = int.Parse(values[0]);
                Y = int.Parse(values[1]);
            }
        }
    }
}
