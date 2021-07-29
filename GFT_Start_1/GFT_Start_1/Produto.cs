using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_1
{
    class Produto
    {
        private string nome;
        private double valor;
        private int quantidade;

        public string Nome { get; set; }
        public double Valor { get; set; } 
        public int Quantidade { get; set; }

        public Produto(string nome, int quantidade, double valor)
        {
            this.Nome = nome;
            this.Quantidade = quantidade;
            this.Valor = valor;
        }

        public virtual double calcularValorFinal(int quantidade, double valor)
        {
            return Math.Round((valor * quantidade) * 1.1, 2);
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
