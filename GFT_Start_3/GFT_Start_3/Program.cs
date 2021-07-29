using System;

namespace GFT_Start_3
{
    class Program
    {   
/*        3. Escreva um programa que peça ao usuário dois números:
        a.Intervalo Inicial
        b.Intervalo Final
        Percorra o intervalo e imprima o cubo de cada número do intervalo.Tanto
        intervalo inicial como intervalo final devem fazer parte.
        O programa deverá parar se o usuário digitar um intervalo maior que 15.
        Exemplo:

        • Intervalo Inicial: 5 | Intervalo Final: 15 (intervalo = 10, válido)
        • Intervalo Inicial: 5 | Intervalo Final: 26 (intervalo = 21, inválido)*/
        static void Main(string[] args)
        {
            int numeroInicial;
            int numeroFinal;
            int intervalo;

            Console.WriteLine("Digite o Intervalo Inicial: ");
            numeroInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Intervalo final: ");
            numeroFinal = int.Parse(Console.ReadLine());

            intervalo = numeroFinal - numeroInicial;
            Console.WriteLine(intervalo);
            if (intervalo < 15)
            {
                for (int i = numeroInicial; i <= intervalo; i++)
                {
                    Console.WriteLine("O cubo de " + i + " é " + Math.Pow(i, 3));
                }
            }
            else
            {
                Console.WriteLine("O intervalo de {0} a {1} é inválido, pois é maior que 15.", numeroInicial, numeroFinal);

            }

        }
    }
}
