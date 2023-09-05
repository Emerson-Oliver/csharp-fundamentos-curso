using System;
using System.Globalization;

namespace Bee1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoLanche, qtdeLanche;
            double totalPagar;

            string[] vet = Console.ReadLine().Split(' ');
            codigoLanche = int.Parse(vet[0]);
            qtdeLanche = int.Parse(vet[1]);

            if (codigoLanche == 1)
            {
                totalPagar = qtdeLanche * 4.00;
            }
            else if (codigoLanche == 2)
            {
                totalPagar = qtdeLanche * 4.50;
            }
            else if (codigoLanche == 3)
            {
                totalPagar = qtdeLanche * 5.00;
            }
            else if (codigoLanche == 4)
            {
                totalPagar = qtdeLanche * 2.00;
            }
            else
            {
                totalPagar = qtdeLanche * 1.50;
            }
            Console.WriteLine("Total: R$ " + totalPagar.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}