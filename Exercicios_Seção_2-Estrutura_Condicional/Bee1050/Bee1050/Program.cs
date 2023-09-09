using System;

namespace Bee1050
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int codigo = int.Parse(Console.ReadLine());
            string cidade;

            if (codigo == 61)
            {
                cidade = "Brasilia";
                Console.WriteLine(cidade);
            }
            else if (codigo == 71)
            {
                cidade = "Salvador";
                Console.WriteLine(cidade);
            }
            else if(codigo == 11)
            {
                cidade = "São Paulo";
                Console.WriteLine(cidade);
            }
            else if (codigo == 21)
            {
                cidade = "Rio de Janeiro";
                Console.WriteLine(cidade);
            }
            else if(codigo == 32)
            {
                cidade = "Juiz de Fora";
                Console.WriteLine(cidade);
            }
            else if (codigo == 19)
            {
                cidade = "Campinas";
                Console.WriteLine(cidade);
            }
            else if (codigo == 27)
            {
                cidade = "Vitoria";
                Console.WriteLine(cidade);
            }
            else if (codigo == 31)
            {
                cidade = "Belo Horizonte";
                Console.WriteLine(cidade);
            }            
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }            
        }
    }
}