using System;

namespace Bee1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int index = 2; index <= N; index += 1)
            {
                if(index % 2 == 0)
                {
                    int quadrado = index * index;
                    Console.WriteLine(index + "^2 = " + quadrado);
                }
            }
        }
    }
}