using System.Globalization;

namespace Exercicio3
{
    class Aluno
    {
        public string Nome;
        public float N1;
        public float N2;
        public float N3;

        private float Media()
        {
            return (N1 + N2 + N3) / 3;
        }

        private float PontosNecessarios()
        {
            return (float)(60.00 - Media());
        }

        public string Resultado()
        {
            string msg = "NOTA FINAL = "
                + Media().ToString("F2", CultureInfo.InvariantCulture);

            if (Media() >= 60.00)
            {
                msg += "\r\nAPROVADO";
            }
            else
            {
                msg += "\r\nREPROVADO" 
                    + "\r\nFALTARAM "
                    + PontosNecessarios().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS";
            }

            return msg;
        }
    }
}
