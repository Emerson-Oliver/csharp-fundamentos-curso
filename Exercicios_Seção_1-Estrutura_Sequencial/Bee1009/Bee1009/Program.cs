using System;
using System.Globalization;

namespace Bee1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double totalVendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double salarioFinal = (totalVendas / 100.0 * 15.0) + salarioFixo ;

            Console.WriteLine("TOTAL = R$ "+salarioFinal.ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}
