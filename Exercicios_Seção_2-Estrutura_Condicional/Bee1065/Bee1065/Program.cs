using System;

namespace Bee1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());
           
            int valoresPar = 0;

            if(valor1 % 2 == 0)
            {
                valoresPar = valoresPar + 1;
            }
            if (valor2 % 2 == 0)
            {
                valoresPar = valoresPar + 1;
            }
            if (valor3 % 2 == 0)
            {
                valoresPar = valoresPar + 1;
            }
            if (valor4 % 2 == 0)
            {
                valoresPar = valoresPar + 1;
            }
            if (valor5 % 2 == 0)
            {
                valoresPar = valoresPar + 1;
            }
            Console.WriteLine(+valoresPar+ " Valores pares");
        }
    }
}