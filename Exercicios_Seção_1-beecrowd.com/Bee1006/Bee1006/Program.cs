using System;
using System.Globalization;
namespace Bee1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media;
            float A = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            float B = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            float C = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (A*2 + B*3 + C*5) / 10f;

            Console.WriteLine("MEDIA = "+media.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}