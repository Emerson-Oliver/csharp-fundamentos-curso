using System;
using System.Globalization;

namespace Bee1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double R = double.Parse(Console.ReadLine());

            double volume = 4.0 / 3.0 * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
