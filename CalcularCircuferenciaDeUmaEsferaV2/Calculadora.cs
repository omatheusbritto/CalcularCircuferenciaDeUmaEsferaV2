using System;

namespace CalcularCircuferenciaDeUmaEsferaV2
{
    class Calculadora
    {
        public double Pi = 3.1415;
        public double r;
        public double Circunferencia()
        {
            return 2.0 * Pi * r;
        }
        public double Volume()
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
