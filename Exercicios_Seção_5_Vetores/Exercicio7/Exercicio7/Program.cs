using System;
using System.Globalization;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            float[] nota1 = new float[N];
            float[] nota2 = new float[N];



            for (int index = 0; index < N; index += 1)
            {
                string[] informacoes = Console.ReadLine().Split(" ");
                nomes[index] = (informacoes[0]);
                nota1[index] = float.Parse(informacoes[1], CultureInfo.InvariantCulture);
                nota2[index] = float.Parse(informacoes[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados:");
            for (int index = 0; index < N; index += 1)
            {
                double media = (nota1[index] + nota2[index]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[index]);
                }
            }
        }
    }
}


