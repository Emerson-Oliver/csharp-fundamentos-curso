using System;

namespace Bee1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            
            for (int index = 1; index <= x; index += 1)
            {
                if ( index % 2 != 0)
                {                    
                    Console.WriteLine(index);
                }
            }
        }
    }
}