using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Encapsulamento {
    class Produto {

       private string _nome;
       public double Preco { get; private set; }
       public int Quantidade { get; private set; }

        public Produto() {

            Quantidade = 0;
        }


        public Produto(string nome,double preco) : this() {
            Nome = nome;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }

      
        public string Nome {
            get {
                return _nome;
            }

            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
                else {
                    Console.WriteLine("Não pode se vazio, ou e tem que ter 1 ou mais caractere");
                }
            }

        }
 

         
        public void AlterarQuantidade(int quantidade) {
            Quantidade = quantidade;
        }

        public void AumentarQuantidade(int quantidade) {
            Quantidade += quantidade;
        }
        public void SubtrairQuantidade(int quantidade) {
            Quantidade -= quantidade;
        }

        public void AlterarPreco(double preco) {

            if (preco >= 0) {
                Preco = preco;
            }
            else {
                Console.WriteLine("Preço Inválido");
            }

        }

        public double CalcularTotal() {
            return Preco * Quantidade;
        }

        public override string ToString() {
            return $"Produto: {Nome}\n" +
                   $"Quantidade: {Quantidade}\n" +
                   $"Total: {CalcularTotal()}";
        }



    }
}
