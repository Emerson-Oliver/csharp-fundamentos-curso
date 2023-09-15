using System;

namespace Bee1075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int index = 1; index <=1000; index += 1)
            {
                if(index % N == 2)
                {
                    Console.WriteLine(index);
                }
            }
        }
    }
}