﻿using System;
using System.Globalization;

namespace Bee1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2;

            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("Nota Invalida");
                nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("Nota Invalida");
                nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            double media = (nota1 + nota2) / 2.0;
            Console.WriteLine("Media: " + media);
        }
    }
}