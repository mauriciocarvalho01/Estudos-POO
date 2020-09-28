using System;

namespace ExercicioPOO {
    class Program {
        static void Main(string[] args) {

            //  Veiculo veiculo = new Veiculo();

            // Abastecimento abastecer = new Abastecimento();

            Carro carro = new Carro();
            Aviao aviao = new Aviao();
            PickUp pickup = new PickUp();
            Bicicleta bike = new Bicicleta();


            carro.TrocarPecas();
            carro.TrocarPneu();
            carro.encherTanque();
            aviao.TrocarPecas();
            aviao.TrocarPneu();
            aviao.encherTanque();
            pickup.TrocarPneu();
            bike.TrocarPecas();
            bike.TrocarPneu();



        }
    }
}
