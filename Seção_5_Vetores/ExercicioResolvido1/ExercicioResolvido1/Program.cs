using System;
using System.Globalization;

namespace ExercicioResolvido1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] valores;
            N = int.Parse(Console.ReadLine());
            valores = new double[N];

            for (int index = 0; index < N; index += 1)
            {
                valores[index] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int index = 0; index < N; index += 1)
            {
                Console.WriteLine(valores[index].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}