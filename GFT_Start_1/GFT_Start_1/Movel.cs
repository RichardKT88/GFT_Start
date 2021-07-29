using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_1
{
    class Movel : Produto
    {
        public Movel(string nome, int quantidade, double valor) : base(nome, quantidade, valor)
        {
        }
        public override double calcularValorFinal(int quantidade, double valor)
        {
            return quantidade >= 10 ? Math.Round((quantidade * valor) * 1.05, 2) : Math.Round((quantidade * valor) * 1.11, 2);
        }

        public override string ToString()
        {
            return "Produto: " + Nome
            + ", Quantidade: " + Quantidade
            + ", Valor: R$" + Valor
            + " -> Total: R$" + calcularValorFinal(Quantidade, Valor);
        }
    }
}
