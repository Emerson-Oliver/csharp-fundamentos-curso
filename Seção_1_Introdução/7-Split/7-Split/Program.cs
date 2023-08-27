using System;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string cores = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' ');
            string cor1 = vet[0];
            string cor2 = vet[1];
            string cor3 = vet[2];

            Console.WriteLine(cor1);
            Console.WriteLine(cor2);
            Console.WriteLine(cor3);
        }
    }
}