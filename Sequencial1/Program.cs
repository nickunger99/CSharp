using System;

//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
//mensagem explicativa, conforme exemplos.

namespace Sequencial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;
            Console.WriteLine("Soma = " + soma);
        }
    }
}
