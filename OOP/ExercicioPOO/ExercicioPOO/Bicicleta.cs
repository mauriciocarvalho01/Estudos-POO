using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO {
    class Bicicleta: Veiculo {
        public override void TrocarPneu() {
            base.TrocarPneu();
            Console.WriteLine("- da bicibleta");
        }

        public override void TrocarPecas() {
            Console.WriteLine("Troca Manopla");
            Console.WriteLine("Troca parafuso");
            Console.WriteLine("Trocar aro!");
        }
    }
}