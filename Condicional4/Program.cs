using System;
//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
//começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

namespace Condicional4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o horário de inicio do jogo: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Insira o horário de término do jogo: ");
            int end = int.Parse(Console.ReadLine());

            int time;
            if (start < end)
            {
                time = end - start;
            }
            else
            {
                time = 24 - start + end;
            }
            Console.WriteLine("O jogo durou: " + time + "Hora(s)");
        }
    }
}
