﻿using System;
using System.Globalization;

namespace Bee1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;
            double A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (A*3.5 + B*7.5) / 11.0;

            Console.WriteLine("MEDIA = " +media.ToString("F5",CultureInfo.InvariantCulture));
        }
    }
}