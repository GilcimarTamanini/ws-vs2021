using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(
                Math.Pow(Altura, 2)
                + 
                Math.Pow(Largura, 2)
                );
        }
    }
}
