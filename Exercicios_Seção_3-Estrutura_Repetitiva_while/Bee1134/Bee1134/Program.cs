using System;

namespace Bee1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipoCombustivel = int.Parse(Console.ReadLine());

            while (tipoCombustivel != 4)
            {
               if (tipoCombustivel == 1)
                {
                    alcool = alcool + 1;
                }
               else if (tipoCombustivel == 2)
                {
                    gasolina = gasolina + 1;
                }
               else if (tipoCombustivel == 3)
                {
                    diesel = diesel + 1;
                }             

                tipoCombustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}