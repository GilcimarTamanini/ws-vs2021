using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4
{
    class ConversorDeMoeda
    {
        private static double Iof = 6.0;

        public static double ValorSerPago(double vlr, double cotacao)
        {
            vlr += CalcularIof(vlr);
            return vlr * cotacao;
        }

        private static double CalcularIof(double vlr)
        {
            return vlr * (Iof / 100.0);
        }
    }
}
