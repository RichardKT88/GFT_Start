using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_4
{
    class Retangulo : IAreaCalculavel
    {
        private double altura;
        private double largura;

        public double Altura { get; set; }
        public double Largura { get; set; }


        public Retangulo(double altura, double largura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double calcularArea()
        {
            return Largura * Altura;
        }
    }
}
