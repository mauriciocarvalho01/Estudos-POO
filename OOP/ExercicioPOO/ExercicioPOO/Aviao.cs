using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO {
    class Aviao : Veiculo, Abastecimento {
        public int IDVeiculo { get; set; }

        public void encherTanque() {

            Console.WriteLine("Enchendo o tanque do AVIÃO");
        }
      

        public override void TrocarPneu() {
            base.TrocarPneu();
            Console.WriteLine("- do Avião");
        }
        public override void TrocarPecas() {
            Console.WriteLine("Troca bancos");
            Console.WriteLine("Troca rádio");
            Console.WriteLine("Troca porta");
        }
    }
}
