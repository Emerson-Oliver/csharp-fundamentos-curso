using System;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int index = 0; index < N; index +=1)
            {
                vet[index] = double.Parse(valores[index], CultureInfo.InvariantCulture);
            }

            double maior = vet[0];
            int posicaoMaior = 0;

            for (int index = 0; index < N; index += 1)
            {
                if (vet[index] > maior)
                {
                    maior = vet[index];
                    posicaoMaior = index;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }
}