using System;
using System.Globalization;

namespace Bee1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double triangulo, circulo, trapezio, quadrado, retangulo;

            string[] figuras = Console.ReadLine().Split(' ');
            double A = double.Parse(figuras[0],CultureInfo.InvariantCulture);
            double B = double.Parse(figuras[1],CultureInfo.InvariantCulture);
            double C = double.Parse(figuras[2],CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " +triangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
