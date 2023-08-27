using System;

namespace ProceDadosECasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;
            double numero4;

            numero1 = 5;
            numero2 = 2 * numero1;
            numero3 = 5;
            numero4 = 2 * numero3;

            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
            Console.WriteLine(numero4);

            Console.ReadLine();
        }
    }
}