using System;
using System.Globalization;
//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
//mostre:
//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.

namespace Sequencial6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculos de Geometria");
            Console.WriteLine("Insira o valor A: ");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor B: ");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor C: ");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = A * C / 2.0;
            double circulo = Math.PI * Math.Pow(C, 2);
            double trapezio = (A + B) / 2.0 * C;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine("Triangulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
