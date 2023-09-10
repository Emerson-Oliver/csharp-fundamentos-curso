using System;
using System.Globalization;
namespace Bee1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            float soma = 0, contagem = 0;
            while(idade >= 0)
            {
                contagem = contagem + 1;
                soma = soma + idade;
                idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            double idadeMedia = (double) soma / contagem;
            Console.WriteLine(idadeMedia.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}