using System;
using System.Collections.Generic;
using System.Text;

namespace cursoCSharp {
    class Calculadora {


        // Um membro static faz o objeto ser referenciado sem precisar instanciar em outras classes...
        //Sua função principal é tornar um elemento estático, e constante. Pois independente do local, o valor se mantém.
        public static double Pi = 3.14;
        public static double Iof = 0.06;




        public static double Circunferencia(double raio) {

            return 2 * Pi * raio;
        }

        public static double Volume(double raio) {
            return (4.0 / 3.0) * Pi * Math.Pow(raio, 3);
        }

        public static double CalculaDollar(double cotacao, double dolares) {

           
            return ((cotacao * dolares) + ((cotacao * dolares) * Iof));

        }


    }
}
