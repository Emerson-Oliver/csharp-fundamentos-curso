using System;
using System.Globalization;

namespace Bee1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double salario, valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = (horasTrabalhadas * valorHora);

            Console.WriteLine("NUMBER = " + codigoFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}