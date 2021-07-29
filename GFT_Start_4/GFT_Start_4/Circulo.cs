using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_4
{
    class Circulo : IAreaCalculavel
    {
        private double raio;
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double calcularArea()
        {
            return Math.PI*Math.Pow(Raio,2);
        }
    }
}
