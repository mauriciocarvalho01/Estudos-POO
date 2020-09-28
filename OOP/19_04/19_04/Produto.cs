using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _19_04 {
    class Produto {
        private string nome;
        private double preco;
        private int quantidade;

        public Produto() { }

        public Produto(string nome, double preco, int quantidade) {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }


        public string getNome() {
            return this.nome;
        }

        public void setNome(string nome) {
           this.nome = nome;
        }


        public double getPreco() {
            return this.preco;
        }

        public void setPreco(double preco) {
            this.preco = preco;
        }

        public int getQtd() {
            return this.quantidade;
        }

        public void setQtd(int quantidade) {
            this.quantidade = quantidade;
        }


        public double valorTotalEmEstoque() {
            return this.preco * this.quantidade * 1.0;
        }


        public void adicionarProdutos(int qtd) {
            this.quantidade += qtd;
        }

        public void removerProdutos(int qtd) {
            this.quantidade -= qtd;
        }

        public override string ToString() {
            return $"{nome}, $ {preco.ToString("F2", CultureInfo.InvariantCulture)}, {quantidade} " +
                $"unidades, Total {valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }





    }
}
