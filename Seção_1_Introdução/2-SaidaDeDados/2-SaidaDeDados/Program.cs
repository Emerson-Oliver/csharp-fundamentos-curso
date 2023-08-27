using System;
using System.Globalization;

namespace SaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 10.123456;
            string nome = "Emerson";            
            int idade = 38;
            char sexo = 'M';
            
            Console.WriteLine("Ola, Mundo");
            Console.Write("Bom dia_");
            Console.Write("Boa Tarde");            
            Console.WriteLine();
            Console.WriteLine(numero);
            Console.WriteLine(numero.ToString("F4"));
            Console.WriteLine(numero.ToString("F2"));
            Console.WriteLine(numero.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine($"O Funcionario {nome} tem {idade} anos e é do sexo {sexo}"); // Interpolação
            Console.WriteLine("O Funcionario " + nome + " tem " + idade + " anos e é do sexo " + sexo); // Concatenação
            Console.ReadLine();
        }
    }
}