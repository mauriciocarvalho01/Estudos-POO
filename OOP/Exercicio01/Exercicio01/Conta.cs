using System;
using System.Collections.Generic;

namespace Exercicio01 {
    public class Conta {
        #region "ATRIBUTOS"
        private string Banco;
        private int Agencia;
        public int NumConta { get; set; }
        public Titular Titular { get; set; }
        public List<Titular> Dependentes { get; set; }
        public double Saldo { get; set; }

        #endregion

        #region "MÉTODOS CONTRUTORES"

        public Conta(string banco, int agencia, int numConta, Titular titular, string dependentes, double saldo) {
            Banco = banco;
            Agencia = agencia;
            NumConta = numConta;
            Titular = titular;
            Dependentes = dependentes;
            Saldo = saldo;
        }

        public Conta(string banco, int agencia, int numConta) {
            Banco = banco;
            Agencia = agencia;
            NumConta = numConta;
        }


        #endregion

        #region "ENCAPSULAMENT"

        public string getBanco() {
            return this.Banco;
        }
        public void setBanco(string banco) {
            this.Banco = banco;
        }

        #endregion
    }
}