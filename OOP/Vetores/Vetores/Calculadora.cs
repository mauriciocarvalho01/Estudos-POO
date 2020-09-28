using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores {
    class Calculadora {

        public int Soma(params int [] numeros) {
            int sum = 0;
            for(int i = 0; i < numeros.Length; i++) {
                sum += numeros[i];
            }

            return sum;
        }


        public int Triple(ref int x) {
            x *= x;

            return x;
        }

        public int Subtrair(int x,int z, out int y) {
            y = x - z;

            return y;
        }
    }
}
