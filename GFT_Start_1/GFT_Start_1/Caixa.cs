using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_1
{
    class Caixa
    {
        public string calcularTotal(List<Produto> listaProduto)
        {
            double total = 0;
            string descricaoProduto = "";

            foreach (Produto produto in listaProduto)
            {
                descricaoProduto += produto + "\n";
                total += produto.calcularValorFinal(produto.Quantidade, produto.Valor);
            }
            return descricaoProduto + "O valor total dos produtos é: R$" + total;
        }
    }
}
