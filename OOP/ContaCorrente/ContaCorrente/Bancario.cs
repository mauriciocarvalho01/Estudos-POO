using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente {
    class Bancario : Conta{

        public Pessoa pessoa_bancario { get; set; }

        private int funcionarioId;

        public Bancario() { }
        public Bancario(Pessoa pessoa_bancario, string banco, string agencia,
                       int numConta, Pessoa titular,
                        double saldo)
                       : base(banco, agencia, numConta, titular, saldo) {
            this.pessoa_bancario = pessoa_bancario;
        }

        public int getFuncionaroId() => this.funcionarioId;

        public void setFuncionarioId(int funcId) {
            if (funcId < 100) this.funcionarioId = funcId;
            Console.WriteLine("Id fora do range! ");
        }


        public override bool efetuarEmpréstimo(double renda, double valor) {
            base.efetuarEmpréstimo(renda, valor);

            if (renda > 1500 && valor < 5000) {
                Console.WriteLine("\n\tEMPRÉSTIMO CONCLUÍDO!\nverificar saldo.");
                return true;
                
            }
            else if (renda > 3000 && valor < 10000) {
                Console.WriteLine("\n\tEMPRÉSTIMO CONCLUÍDO!\nverificar saldo.");
                return true; 
            }
            else {
                Console.WriteLine("\n\tSUA RENDA NÃO COBRE ESSE EMPRÉSTIMO!\tfale com seu gerente.");
            }

            Console.WriteLine("\n\tEMPRÉSTIMO CONCLUÍDO!\nverificar saldo.");

            return false;
        }


    }
}
