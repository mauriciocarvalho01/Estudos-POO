using System;

namespace CSharp
{
    public class Poupanca : Conta
    {
        #region "ATRIBUTOS"
        private double rendimento;
        #endregion

        public Poupanca() { }
        public Poupanca(string banco, string agencia,
                int numConta, Pessoa titular,
                 double saldo, double rendimento)
                : base(banco, agencia, numConta, titular, saldo) {

            this.rendimento = saldo * 0.15;
        }

        #region "M�TODOS"
  
        public override void alterarConta(string banco, string agencia, int numConta, Pessoa titular, double saldo, double limite) {
            base.alterarConta(banco,agencia, numConta,titular, saldo,limite);
            Console.WriteLine("Conta Poupan�a alterada com sucesso!");
        }
        public override bool listarConta() {
            base.listarConta();
            return true;
        }

      

        #endregion
    }
}
