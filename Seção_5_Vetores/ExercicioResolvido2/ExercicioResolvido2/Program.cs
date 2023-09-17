using System;
using System.Globalization;

namespace ExercicioResolvido2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            float[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new float[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int index = 0; index < N; index += 1)
            {
                vet[index] = float.Parse(valores[index],CultureInfo.InvariantCulture);
            }

            for (int index = 0; index < N; index += 1)
            {
                Console.Write(vet[index].ToString("F1",CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            float soma = 0f;
            for (int index = 0; index < N; index += 1)
            {
                soma = soma + vet[index];
            }
            float media = soma / N;

            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}