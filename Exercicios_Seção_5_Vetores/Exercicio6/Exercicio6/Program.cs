using System;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            for (int index = 0; index < N; index += 1)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[index] = valores[0];
                idades[index] = int.Parse(valores[1]);
            }

            int maiorIdade = idades[0];
            int posicaoMaiorIdade = 0;

            for (int index = 0; index < N; index += 1)
            {
                if (idades[index] > maiorIdade)
                {
                    maiorIdade = idades[index];
                    posicaoMaiorIdade = index;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);
        }
    }
}


