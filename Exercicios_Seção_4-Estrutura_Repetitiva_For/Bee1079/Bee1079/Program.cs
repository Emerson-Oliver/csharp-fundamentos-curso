using System;
using System.Globalization;

namespace Bee1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int index = 0; index < N; index += 1)
            {
                string[] notas = Console.ReadLine().Split(' ');
                float nota1 = float.Parse(notas[0],CultureInfo.InvariantCulture);
                float nota2 = float.Parse(notas[1],CultureInfo.InvariantCulture);
                float nota3 = float.Parse(notas[2],CultureInfo.InvariantCulture);

                float media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10f;

                Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
            }
            
        }
    }
}