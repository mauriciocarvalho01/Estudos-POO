using System;
using System.Globalization;

namespace cursoCSharp {
    class Program {

      
        static void Main(string[] args) {



            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double circ = Calculadora.Circunferencia(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2",CultureInfo.InvariantCulture));


            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine("Qual a cotação do dolar?: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares você vai comprar?: ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pago = Calculadora.CalculaDollar(cotacao, dolares);

            Console.WriteLine("Valor a ser pago: " + pago.ToString("F2", CultureInfo.InvariantCulture));



        }


       
    }
}
