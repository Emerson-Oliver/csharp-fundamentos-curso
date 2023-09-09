using System;
using System.Globalization;

namespace ExercicioExemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, soma;
            int contagem = 0;

            idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            soma = 0.0;
            while (idade > 0)
            {
                soma = soma + idade;
                contagem = contagem + 1;
                idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            if (contagem == 0  )
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                double idadeMedia = soma / contagem;
                Console.WriteLine("Media de Idade: " + idadeMedia.ToString("F2", CultureInfo.InvariantCulture));
            }            
        }
    }
}