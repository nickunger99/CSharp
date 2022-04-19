using System;
using System.Globalization;
//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
//seguir, calcule e mostre o valor da conta a pagar


namespace Condicional5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o codigo e a quantidade do item: ");
            string[] values = Console.ReadLine().Split(' ');
            int code = int.Parse(values[0]);
            int amounts = int.Parse(values[1]);

            double total = 0;
            if (code == 1)
            {
                total = amounts * 4.0;
            }
            else if (code == 2)
            {
                total = amounts * 4.5;
            }
            else if (code == 3)
            {
                total = amounts * 5.0;
            }
            else if (code == 4)
            {
                total = amounts * 2.0;
            }
            else if (code == 5)
            {
                total = amounts * 1.5;
            }
            else
            {
                Console.WriteLine("Codigo invalido");
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
