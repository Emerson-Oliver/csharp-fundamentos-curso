using System;
using System.Globalization;

namespace Bee1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float percentual = 0;
            double aumento = 0;
            double novoSalario = 0;
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                novoSalario = salario / 100 * 115.0;
                aumento = novoSalario - salario;
                percentual = 15f;
            }
            else if (salario >= 400.00 && salario <= 800.00)
            {
                novoSalario = salario / 100 * 112.0;
                aumento = novoSalario - salario;
                percentual = 12f;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                novoSalario = salario / 100 * 110.0;
                aumento = novoSalario - salario;
                percentual = 10f;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                novoSalario = salario / 100 * 107.0;
                aumento = novoSalario - salario;
                percentual = 7f;
            }
            else
            {
                novoSalario = salario / 100 * 104.0;
                aumento = novoSalario - salario;
                percentual = 4f;
            }
            Console.WriteLine("Salario: " + novoSalario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + aumento.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}