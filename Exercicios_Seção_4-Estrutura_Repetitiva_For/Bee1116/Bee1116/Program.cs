using System;
using System.Globalization;

namespace Bee1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int numero1, numero2;
            double resultado;

            n = int.Parse(Console.ReadLine());

            for (int index = 1; index <=n; index += 1)
            {
                string[] valores = Console.ReadLine().Split(' ');
                numero1 = int.Parse(valores[0]);
                numero2 = int.Parse(valores[1]);

                if (numero2 == 0)
                {
                    Console.WriteLine("Divisão Impossivel");                    
                }
                else
                {
                    resultado = (double) numero1 / numero2;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}