using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_1
{
    class Eletronico : Produto
    {
        public Eletronico(string nome, int quantidade, double valor) : base(nome, quantidade, valor)
        {
        }
        public override double calcularValorFinal(int quantidade, double valor)
        {
            return Math.Round((quantidade * valor) * 1.15, 2);

        }
        public override string ToString()
        {
            return "Produto: " + Nome 
                + ", Quantidade: "+ Quantidade 
                + ", Valor: R$" + Valor 
                + " -> Total: R$" + calcularValorFinal(Quantidade, Valor);
        }
    }
}
