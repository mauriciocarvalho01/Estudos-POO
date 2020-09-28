using System;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 1000.00, 3 );


            p.Nome = "TV 8K";  
            p.AlterarPreco(1200.20);
            p.AlterarQuantidade(4);


            p.AlterarPreco(100.01);
            p.AumentarQuantidade(2);
            p.Nome = "Iphone";

            Console.WriteLine(p);
        }
    }
}
