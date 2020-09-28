using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Pedido {
    class Produto {
        public string nome_prod { get; set; }
        public double valor { get; set; }
        public double quantidade { get; set; }


        public Produto() { }

        public Produto(double valor, double quantidade) {
            this.valor = valor;
            this.quantidade = quantidade;
        }
        public Produto( string nome_prod, double valor, double quantidade) {
            this.nome_prod = nome_prod;
            this.valor = valor;
            this.quantidade = quantidade;
        }

       public override string ToString() {
            return $"Nome do produto: {this.nome_prod}\n" +
                   $"Preço: {this.valor}\n" + 
                   $"Quantidade: {this.quantidade}";
        }


        public double Troco(double pague, double total) => pague - total;
        public double CalcularTotal() => this.valor * this.quantidade;



    }
}
