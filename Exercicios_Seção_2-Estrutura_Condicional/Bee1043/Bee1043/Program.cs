using System;
using System.Globalization;

namespace Bee1043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, perimetro, area;

            string[] valores = Console.ReadLine().Split(' ');
            A = float.Parse(valores[0],CultureInfo.InvariantCulture);
            B = float.Parse(valores[1],CultureInfo.InvariantCulture);
            C = float.Parse(valores[2],CultureInfo.InvariantCulture);

            if (A + B > C && A + C > B && B + C > A)
            {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}