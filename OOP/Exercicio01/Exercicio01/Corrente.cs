using System;

namespace Exercicio01 {
    public class Corrente : Conta {
        #region "ATRIBUTOS"
        public double Taxa { get; set; }
        #endregion

        #region "MÉTODO CONTRUTOR"
        //EM TODOS OS MÉTODOS CONSTRUTORES DAS SUB CLASSES (QUE POSSUEM HERANÇA)
        //É NECESSÁRIO CHAMAR O CONSTRUTOR DA SUPER CLASSE
        public Corrente(string banco, int agencia, int numConta)
                     : base(banco, agencia, numConta) {
            this.Taxa = 0.0;
        }

        public Corrente(string banco, int agencia,
                int numConta, Titular titular,
                string dependentes, double saldo, double taxa)
                : base(banco, agencia, numConta, titular, dependentes, saldo) {
            Taxa = taxa;
        }

        #endregion

    }
}