using System;

namespace ExercicioExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Quantas horas? ");
            x = int.Parse(Console.ReadLine());

            //Estrutura Condicional Simples
            if (x < 12)
            {
                Console.WriteLine("Bom dia");
            }
        }
    }
}
