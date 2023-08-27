using System;
using System.Globalization;

namespace PrimeiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto;
            int qtdeQuartos;
            double precoproduto;            

            Console.WriteLine("Entre com seu nome completo:");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            qtdeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            precoproduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] dadosPessoa = Console.ReadLine().Split(' ');
            string ultimoNome = dadosPessoa[0];
            int idade = int.Parse(dadosPessoa[1]);
            double altura = double.Parse(dadosPessoa[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdeQuartos);
            Console.WriteLine(precoproduto.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}