using System;
using System.Globalization;

namespace OOP01 {
    class Program {
        static void Main(string[] args) {

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();
            Triangulo maior = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.CalculaArea();
            double areaY = y.CalculaArea();

            maior.CalculaMaior(areaX, areaY);


            Console.WriteLine("Area do X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

          


        }
    }
}
