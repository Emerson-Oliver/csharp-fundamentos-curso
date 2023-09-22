using System;
using System.Globalization;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] valores;

            N = int.Parse(Console.ReadLine());
            valores = new double[N];

            string[] vet = Console.ReadLine().Split(' ');

            for(int index=0; index<N; index += 1)
            {
                valores[index] = double.Parse(vet[index], CultureInfo.InvariantCulture);
            }

            double media = 0.0;

            for (int index =0; index<N; index += 1)
            {
                media = media + valores[index] / N;
            }

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int index = 0; index < N; index += 1)
            {
                if (valores[index] < media)
                {
                    Console.WriteLine(valores[index].ToString("F1",CultureInfo.InvariantCulture));
                }
            }           
           
        }
    }
}


