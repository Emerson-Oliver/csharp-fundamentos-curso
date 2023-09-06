using System;
using System.Globalization;

namespace Bee1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');
            float N1 = float.Parse(notas[0],CultureInfo.InvariantCulture);
            float N2 = float.Parse(notas[1],CultureInfo.InvariantCulture);
            float N3 = float.Parse(notas[2],CultureInfo.InvariantCulture);
            float N4 = float.Parse(notas[3],CultureInfo.InvariantCulture);

            float media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;
            Console.WriteLine("Media: " +media.ToString("F1",CultureInfo.InvariantCulture));
            if(media >= 7f)
            {
                Console.WriteLine("Aluno aprovado"); 
            }
            else if (media < 5f)
            {
                Console.WriteLine("Aluno Reprovado");
            }
            else if (media >= 5f && media <= 6.9f)
            {
                Console.WriteLine("Aluno em exame.");
                float notaExame = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame);
                float mediaFinal = (media + notaExame) / 2f;
                if(mediaFinal >= 5f)
                {
                    Console.WriteLine("Aluno Aprovado");
                    Console.WriteLine("Media Final: " +mediaFinal);
                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                }
            }
        }
    }
}