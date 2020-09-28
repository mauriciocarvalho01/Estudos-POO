using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            double a, b, c;
            string ler = Console.ReadLine();

            string[] valores = ler.Split(' ');

            a = double.Parse(valores[0]);
            b = double.Parse(valores[1]);
            c = double.Parse(valores[2]);


            double delta = Math.Pow(b, 2) - 4 * a * c;

            double raizDelta = Math.Sqrt(delta);

            if(a == 0 || b == 0 || c == 0) { Console.Write("Impossivel calcular\n");}
            else if (delta > 0) {

                double r1 = (-b + raizDelta) / (2 * a);
                double r2 = (-b - raizDelta) / (2 * a);

                Console.Write("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture) + "\n");
                Console.Write("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture) + "\n");
            }
            else {
                Console.Write("Impossivel calcular\n");
            }
      











        }
    }
}
