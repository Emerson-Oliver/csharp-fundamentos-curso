using System;
using System.Collections.Concurrent;

namespace ExemploForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];

            for(int index = 0; index <N; index += 1)
            {
                nomes[index] = Console.ReadLine();
            }

            Console.WriteLine("Nomes Digitados: ");
            foreach (string elemento in nomes)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}