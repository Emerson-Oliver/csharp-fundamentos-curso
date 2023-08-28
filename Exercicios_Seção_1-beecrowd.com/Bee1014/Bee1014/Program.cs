using System;
using System.Globalization;
namespace Bee1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double consumoMedio;
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            consumoMedio = (double) X / Y;

            Console.WriteLine(consumoMedio.ToString("F3",CultureInfo.InvariantCulture)+" km/l");
        }
    }
}