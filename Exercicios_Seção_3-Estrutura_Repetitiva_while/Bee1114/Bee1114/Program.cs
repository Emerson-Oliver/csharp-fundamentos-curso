﻿using System;

namespace Bee1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;

            senha = int.Parse(Console.ReadLine());

            if (senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
            }        
            else
            {
                while (senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                    senha = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}