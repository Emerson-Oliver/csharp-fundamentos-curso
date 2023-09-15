using System;

namespace Bee1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            for (int index = 1; index <=10; index += 1)
            {
                string[] cobaias = Console.ReadLine().Split(' ');
                int quantia = int.Parse(cobaias[0]);
                char tipo = char.Parse(cobaias[1]);

                if(tipo == 'C')
                {
                    coelhos = coelhos + quantia;
                }
                else if (tipo == 'R')
                {
                    ratos = ratos + quantia;
                }
                if (tipo == 'S')
                {
                    sapos = sapos + quantia;
                }     
            }
            int totalCobaias = sapos + coelhos + ratos;
            double porcentagemCoelhos = (double)coelhos / totalCobaias * 100.0;
            double porcentagemRatos = (double)ratos / totalCobaias * 100.0;
            double porcentagemSapos = (double)sapos / totalCobaias * 100.0;

            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2") + " %");
        }
    }
}
