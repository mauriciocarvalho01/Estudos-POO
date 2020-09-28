using CSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaCorrente {
   public class Cliente : Conta{
        private double renda;
        public string nomeCliente { get; set; }
        public string cpfCliente { get; set; }
        public int numContaCliente { get; set; }
        public string agenciaCliente { get; set; }
        public string bancoCliente { get; set; }

        public Cliente() { }
        public Cliente(Pessoa titular, string banco, string agencia, int numConta,double renda)
                        : base(titular, banco, agencia, numConta) {
            this.renda = renda;
            this.nomeCliente = Titular.Nome;
            this.cpfCliente = Titular.CPF;
            this.numContaCliente = numConta;
            this.bancoCliente = banco;
            this.agenciaCliente = agencia;

        }


        public double getRenda() => this.renda;

       public void setRenda (double renda) {
           
                this.renda = renda;
           
        }

        public override bool listarConta() {
            Console.WriteLine("Titular: " + nomeCliente);
            Console.WriteLine("CPF: " + cpfCliente);
            Console.WriteLine($"Número da conta: " + numContaCliente);
            Console.WriteLine($"Número da agência: " + agenciaCliente);
            Console.WriteLine("Renda Mensal: " + renda.ToString("F2", CultureInfo.InvariantCulture));

            return true;
        }

    }
}
