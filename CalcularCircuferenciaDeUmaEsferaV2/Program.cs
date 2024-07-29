// Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor
// de uma circunferência e do volume de uma esferapara um raio daquele valor. Informar também
// o valor de PI com duas casas decimais.

using CalcularCircuferenciaDeUmaEsferaV2;
using System;
using System.Globalization;

namespace CalcularCircuferencia
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculadora n1 = new Calculadora();

            Console.Write("Entre com o valor: ");
            n1.r = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            double circ = n1.Circunferencia();
            double vol = n1.Volume();
            Console.WriteLine("A circuferencia de {0} é {1:F2}", n1.r, circ);
            Console.WriteLine("A Volume de {0} é {1:F2}", n1.r, vol);
            Console.WriteLine("Valor de Pi é de {0:F2}", n1.Pi);


        }

    }
}