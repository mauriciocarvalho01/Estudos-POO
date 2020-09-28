using ContaCorrente;
using System;
using System.Globalization;

namespace CSharp {
    public class Corrente : Conta
    {
        #region "ATRIBUTOS"
        public double Taxa {get;set;}
        public Cliente cliente { get; set; }
        #endregion

        #region "MÉTODO CONTRUTOR"
        //EM TODOS OS MÉTODOS CONSTRUTORES DAS SUB CLASSES (QUE POSSUEM HERANÇA)
        //É NECESSÁRIO CHAMAR O CONSTRUTOR DA SUPER CLASSE

        public Corrente() { }
        public Corrente(Cliente cliente) {
            this.cliente = cliente;
        }
        public Corrente(double limite) : base(limite) {

        }
        public Corrente(string banco, string agencia, int numConta)
                     : base(banco, agencia, numConta) {
            
        }

        public Corrente(string banco, string agencia, 
                int numConta, Pessoa titular,
                 double saldo, double taxa)
                : base(banco, agencia, numConta, titular, saldo)

        {
            
        }



        #endregion

        #region "MÉTODOS"
        public double getTaxa() => Taxa = 0.15;
        public override void alterarConta(string banco, string agencia, int numConta, Pessoa titular, double saldo,double limite) {
            base.alterarConta( banco, agencia,numConta,titular,saldo,limite);
        }
        public override bool listarConta() {
            base.listarConta();
                Console.WriteLine("Titular: " );
                Console.WriteLine($"Saldo Atual: {Saldo}");
                Console.WriteLine("Taxa: " + getTaxa().ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine($"Limite: {getLimite()}");
            return true;
     
        }

        public override void imprimirSaldo() {

            Saldo -= Taxa * 100;

            Console.WriteLine("Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture));


        }

        public override void efetuarTransferencia(string cpf, string nome, string banco, string agencia, int numConta, double valor) {
            base.efetuarTransferencia(cpf, nome, banco,agencia, numConta, valor);
        }

        public override void efetuarDeposito(double valor) {
            Console.WriteLine("Data: " + DateTime.Now);
            base.efetuarDeposito(valor);
        }
        public override double retornarSaldo() {
            return base.retornarSaldo();
        }
        public override void compensarCheque(double cheque) {
            base.compensarCheque(cheque);

            Console.WriteLine($"Lançamentos futuros:{cheque}\n" +
                              $"Data do lançamento: {DateTime.Now}");
        }

        public double getLimite() => Limite = 10000;
        #endregion

    }
}
