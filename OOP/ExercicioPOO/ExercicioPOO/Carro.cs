using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO {
    public class Carro : Veiculo, Abastecimento {

        public int IDVeiculo { get; set; }
        public override void TrocarPneu() {
            base.TrocarPneu();
            Console.WriteLine("- do automóvel");
        }

        public override void TrocarPecas() {
            Console.WriteLine("Troca bancos");
            Console.WriteLine("Troca rádio");
            Console.WriteLine("Troca porta");
        }

        public void encherTanque() {
            Console.WriteLine("Enchendo o tanque do CARRO");
        } 
    }

}
