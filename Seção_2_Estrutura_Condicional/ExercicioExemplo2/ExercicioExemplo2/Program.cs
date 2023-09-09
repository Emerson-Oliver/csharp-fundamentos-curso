using System;

namespace ExercicioExemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Quantas horas? ");
            x = int.Parse(Console.ReadLine());

            //Estrutura Condicional Composta
            if (x < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else
            {
                Console.WriteLine("Boa tarde");
            }
        }
    }
}
