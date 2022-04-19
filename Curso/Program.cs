using System;
using System.Globalization;

namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           string produto1 = "Computador";
           string produto2 = "Mesa de escritório";
           byte idade = 30;
           int codigo = 5290;
           char genero = 'M';
           double preco1 = 2100.0;
           double preco2 = 650.50;
           double medida = 53.234567;
           Console.WriteLine("Produtos:");
           // Concatenação
           Console.WriteLine(produto1 + "cujo o preço é $ " + preco1);
           // Interpolação
           Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
           Console.WriteLine("");
           //Placeholders
           Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
           Console.WriteLine("");
           Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
           Console.WriteLine("Arredondando (três casas decimais): " + medida.ToString("F3"));
           Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
           Console.WriteLine("----------------------------------------");
           string frase = Console.ReadLine();
           // string [] vet = Console.ReadLine().Split(' ');s
           string[] vet = frase.Split(' ');
           string f1 = vet[0];
           string f2 = vet[1];
           string f3 = vet[2];
           Console.WriteLine("Você digitou: " + frase);
           Console.WriteLine(f1);
           Console.WriteLine(f2);
           Console.WriteLine(f3);
           */

            /*
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */


            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product price:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vect = Console.ReadLine().Split(' ');
            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);
            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}