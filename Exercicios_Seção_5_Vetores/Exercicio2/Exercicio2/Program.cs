using System;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int index = 0; index < N; index+= 1)
            {
                vet[index] = int.Parse(valores[index]);
            }

            // 1: mostrando os numeros pares
            for (int index = 0; index < N; index+= 1)
            {
                if (vet[index] % 2 == 0)
                {
                    Console.Write(vet[index] + " ");
                }
            }
            Console.WriteLine();

            // 2: mostrando a quantidade de pares
            int quantidadeDePares = 0;
            for (int index = 0; index < N; index+= 1)
            {
                if (vet[index] % 2 == 0)
                {
                    quantidadeDePares++;
                }
            }
            Console.WriteLine(quantidadeDePares);
        }
    }
}