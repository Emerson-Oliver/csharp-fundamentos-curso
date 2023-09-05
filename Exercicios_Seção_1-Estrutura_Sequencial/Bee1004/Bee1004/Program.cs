using System;

namespace Bee1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PROD;
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            PROD = valor1 * valor2;

            Console.WriteLine($"PROD = {PROD}");
        }
    }
}