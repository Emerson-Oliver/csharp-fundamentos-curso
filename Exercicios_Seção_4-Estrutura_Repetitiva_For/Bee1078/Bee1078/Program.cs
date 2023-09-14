using System;
using System.Runtime.Serialization;

namespace Bee1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int index = 1; index <=10; index += 1)
            {
                int resultado = index * N;
                Console.WriteLine(index + " x " + N + " = " + resultado);
            }
            
        }
    }
}

