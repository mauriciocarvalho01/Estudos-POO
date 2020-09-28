using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO {
    public abstract class Veiculo  {
      
        public int ID_Veiculo { get; set; }
        public string Modelo { get; set; }


        public virtual void TrocarPneu() {
            Console.Write("Pneu trocado com sucesso!");
        }

        public abstract void TrocarPecas();


    }
}