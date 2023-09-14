using System;

namespace ExercicioResolvido1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;
            N = int.Parse(Console.ReadLine());

            soma = 0;
            for (int index = 1; index <=N; index += 1)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine(soma);
        }
    }
}