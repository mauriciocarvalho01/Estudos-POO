using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente {
    class Gerente : Conta {

        #region "ATRIBUTOS"
        private int funcionarioId;
        public Pessoa pessoa_gerente { get; set; }


        public Gerente() { }
        public Gerente(Pessoa pessoa_gerente, string banco, string agencia,double limite)
                : base(banco, agencia,limite) {
            this.pessoa_gerente = pessoa_gerente;
        }

        public int getFuncionaroId ()=> this.funcionarioId;

        public void setFuncionarioId(int funcId) {
            if(funcId < 100) this.funcionarioId = funcId;
            Console.WriteLine("Gerente não encontrado! ");
        }



        public double efetuarLimiteCredito(double renda) {
            double limite = 1000;

            if (renda < 1500) {
                Console.WriteLine("\n\tAUMENTO DO LIMITE NEGADO!\n\t");
                Console.WriteLine("Seu limite: " + limite + "\n");

            }
            if (renda >= 1500 && renda < 2000) {
                Console.WriteLine("\n\tSEU LIMITE AUMENTOU!\n\tverificar limite.");
                limite += 2000;
                Console.WriteLine("Novo limite: " + limite);

            }
            if (renda >= 2000 && renda < 5000) {
                Console.WriteLine("\n\tSEU LIMITE AUMENTOU!\n\tverificar limite.");
                limite += 5000;
                Console.WriteLine("Novo limite: " + limite);
            }
            if (renda >= 5000 && renda < 10000) {
                Console.WriteLine("\n\tSEU LIMITE AUMENTOU!\n\tverificar limite.");
                limite += 10000;
                Console.WriteLine("Novo limite: " + limite);
            }
            if(renda > 10000){
                Console.WriteLine("\n\tSEU PERFIL NÃO ENTRA NO TIPO DE PESSOA FÍSICA!\t");
                Console.WriteLine("\n\tABRA UMA CONTA PARA EMPRESAS PARA TER UM LIMITE MAIOR!\t");
            }

 

            return limite;
        }

        #endregion
    }
}
