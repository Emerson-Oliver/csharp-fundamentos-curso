using System;
using System.Globalization;

namespace Bee1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dadosPeca = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(dadosPeca[0]);
            int qtdePeca1 = int.Parse(dadosPeca[1]);
            double valorPeca1 = double.Parse(dadosPeca[2],CultureInfo.InvariantCulture);

            dadosPeca = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(dadosPeca[0]);
            int qtdePeca2 = int.Parse(dadosPeca[1]);
            double valorPeca2 = double.Parse(dadosPeca[2],CultureInfo.InvariantCulture);

            double valorAPagar = (valorPeca1 * qtdePeca1) + (valorPeca2 * qtdePeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorAPagar.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}