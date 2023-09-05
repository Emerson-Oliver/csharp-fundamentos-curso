using System;
using System.Globalization;

namespace Bee1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, n = 3.14159;
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            A = n * (Math.Pow(raio, 2));
          
            Console.WriteLine($"A={A.ToString("F4",CultureInfo.InvariantCulture)}");  
        }
    }
}