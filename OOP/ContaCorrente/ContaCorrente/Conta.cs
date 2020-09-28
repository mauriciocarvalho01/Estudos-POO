using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using ContaCorrente;

namespace CSharp {
    public class Conta {
        #region "ATRIBUTOS"
        private string Banco;
        public string Agencia { get; set; }
        public int NumConta { get; set; }
        public Pessoa Titular { get; set; }
        public double Saldo { get; set; }
        public double Limite {get; set;}
        public double cheque { get; set; }

        #endregion

        #region "MÉTODOS CONTRUTORES"
       public  Conta() { }
       public Conta(string banco, string agencia, double limite) { Limite = limite; }
        public Conta(string banco, string agencia, int numConta, Pessoa titular, double saldo) {
            Banco = banco;
            Agencia = agencia;
            NumConta = numConta;
            Titular = titular;
            Saldo = saldo;
           

        }
        public Conta(Cliente clente) { }

        public Conta(Pessoa titular, string banco, string agencia, int numConta) { }


        public Conta(double limite) {
           Limite = limite;
        }
        public Conta(string banco, string agencia, int numConta) {
            Banco = banco;
            Agencia = agencia;
            NumConta = numConta;
 
        }


        #endregion

        #region "ENCAPSULAMENTO"

        public string getBanco() {
            return this.Banco;
        }
        public void setBanco(string banco) {
            this.Banco = banco;
        }

        public virtual void alterarConta(string banco, string agencia, int numConta, Pessoa titular, double saldo, double limite) {
            Banco = banco;
            Agencia = agencia;
            NumConta = numConta;
            Titular = titular;
            Saldo = saldo;
            Limite = limite;

        }
        public virtual bool listarConta() {
            return true;
        }

        public virtual double retornarSaldo() => Saldo;
        public virtual void imprimirSaldo() {
         
            Console.WriteLine("Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }

       public virtual void compensarCheque(double cheque) {
            if(cheque < 299.99) {
                Console.WriteLine($"Valor do Cheque: {cheque}\n" +
                    $"Para a data: {DateTime.Now}\n" +
                    $"Cheques de valor igual ou inferior a R$ 299,99 demoram 2 dias úteis para entrar na conta." +
                    "Esse prazo é contado a partir do dia útil seguinte ao do depósito.");
            }
            else{
                Console.WriteLine($"Valor do Cheque: {cheque}\n" +
                    $"Para a data: {DateTime.Now}\n" +
                    $"Cheques de valor igual ou superior a R$ 300,00 demoram 1 dia útil para entrar na conta." +
                    $"Esse prazo é contado a partir do dia útil seguinte ao do depósito.");
            }

            this.cheque += cheque;
        }

        public virtual void efetuarDeposito(double valor) {
            this.Saldo += valor;
        }

        public virtual void efetuarTransferencia(string cpf, string nome, string banco, string agencia, int numConta,double valor) {
            Console.WriteLine($"Nome do Beneficiário: {nome}\n" +
                              $"CPF: {cpf}\n" +
                              $"Banco: {banco}\n" +
                              $"Agência: {agencia}\n"+
                              $"Número da conta: {numConta}\n"+
                              $"Valor transferido: {agencia}\n");
            this.Saldo -= valor;

        }

        public virtual bool efetuarEmpréstimo(double renda, double valor) {

            return false;
        }

        #endregion
    }
}
