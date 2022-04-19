using System;

//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
//Multiplos ", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
//ordem crescente ou decrescente


namespace Condicional3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira os valores A e B: ");

            string[] value = Console.ReadLine().Split(' ');
            int A = int.Parse(value[0]);
            int B = int.Parse(value[1]);

            if (A < B)
            {
                A = A + B;
                B = A - B;
                A = A - B;
            }
            if (A % B == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }
        }
    }
}