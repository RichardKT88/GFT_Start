using System;

namespace GFT_Start_2
{
    class Program
    {
        /*2. Crie um programa que imprima todos os números divisíveis por 3 e 7 em um
        intervalo de 10 a 215*/
        static void Main(string[] args)
        {
            for (int i = 10; i <= 215; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("O número {0} é divisível por 3 e 7", i);
                }
            }
        }
    }
}
