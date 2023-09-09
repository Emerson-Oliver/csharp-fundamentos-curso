using System;

namespace Bee1052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            string mes;

            if (numero == 1)
            {
                mes = "Janeiro";
            }
            else if(numero == 2)
            {
                mes = "Fevereiro";
            }
            else if (numero == 3)
            {
                mes = "MArço";
            }
            else if (numero == 4)
            {
                mes = "Abril";
            }
            else if (numero == 5)
            {
                mes = "Maio";
            }
            else if (numero == 6)
            {
                mes = "Junho";
            }
            else if (numero == 7)
            {
                mes = "Julho";
            }
            else if (numero == 8)
            {
                mes = "Agosto";
            }
            else if (numero == 9)
            {
                mes = "Setembro";
            }
            else if (numero == 10)
            {
                mes = "Outubro";
            }
            else if (numero == 11)
            {
                mes = "Novembro";
            }
            else
            {
                mes = "Dezembro";
            }
            Console.WriteLine(mes);
        }
    }
}