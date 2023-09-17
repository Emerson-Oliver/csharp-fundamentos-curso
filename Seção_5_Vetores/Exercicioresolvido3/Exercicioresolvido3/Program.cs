using System;
using System.Globalization;

namespace ExercicioResolvido3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double alturaMedia = 0.0;

            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];           

            for(int index = 0; index < N; index += 1)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[index] = valores[0];
                idades[index] = int.Parse(valores[1]);
                alturas[index] = double.Parse(valores[2],CultureInfo.InvariantCulture);               
            }

            for (int index = 0; index <N; index += 1)
            {
                alturaMedia = alturaMedia + alturas[index] / N;
            }

            int cont = 0;
            for(int index = 0; index <N; index += 1)
            {
                if (idades[index] < 16)
                {
                    cont += 1;
                }               
            }

            double pessoasMenos16 = (double) cont / N * 100.0;
            
            Console.WriteLine("Altura Media é: " + alturaMedia.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: " +pessoasMenos16.ToString("F1",CultureInfo.InvariantCulture) + " % ");
        }
    }
}