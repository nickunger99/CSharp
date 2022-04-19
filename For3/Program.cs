using System;
using System.Globalization;
//Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
//de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
//conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
//peso 5.

namespace for3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a média, insira a quantidade de testes: ");
            int amounts = int.Parse(Console.ReadLine());
            for (int i = 0; i < amounts; i++)
            {
                Console.Write("Insira as notas: ");
                string[] values = Console.ReadLine().Split(' ');
                double x = double.Parse(values[0], CultureInfo.InvariantCulture);
                double y = double.Parse(values[1], CultureInfo.InvariantCulture);
                double z = double.Parse(values[2], CultureInfo.InvariantCulture);

                double media = (x * 2.0 + y * 3.0 + z * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
