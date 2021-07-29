using System;
using System.Collections.Generic;

namespace GFT_Start_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Eletronico ventilador = new Eletronico("Ventilador", 3, 320.00);
            Eletronico computador = new Eletronico("Computador", 2, 3999.00);
            Movel mesa = new Movel("Mesa", 2, 270.00);
            Produto caderno = new Produto("Caderno", 10, 10.50);
            Movel cadeira = new Movel("Cadeira", 10, 234.25);
            Produto caneta = new Produto("Caneta", 15, 0.70);

            List<Produto> listaProdutos = new List<Produto>();
            listaProdutos.Add(ventilador);
            listaProdutos.Add(computador);
            listaProdutos.Add(mesa);
            listaProdutos.Add(caderno);
            listaProdutos.Add(cadeira);
            listaProdutos.Add(caneta);

            Caixa caixa = new Caixa();
            string notaFiscal = caixa.calcularTotal(listaProdutos);
            Console.WriteLine(notaFiscal);
        }
    }
}
