using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_4
{
    class Quadrado : IAreaCalculavel
    {
        private double lado;

        public double Lado {
            get
            {
                return lado;
            }
            set
            {
                lado = value;
            }
        }
        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public double calcularArea()
        {
            return lado*lado;
        }        
    }
}
