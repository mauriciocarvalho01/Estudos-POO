using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01 {
    class Triangulo {
        public double A;
        public double B;
        public double C;


       /* public Triangulo(double A, double B, double C) {
            this.A = A;
            this.B = B;
            this.C = C;
        }*/

            public Triangulo() {

             }


        public double CalculaArea(){

           double p = (this.A + this.B + this.C) / 2;

            double area = Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));


            return area;
        }

        public void CalculaMaior(double A1, double A2) {
            if(A1 > A2) {
                Console.WriteLine("Maior Area: X: " + A1 );
            }
            else {
                Console.WriteLine("Maior Area: Y: " + A2);
            }
        }
    }
}
