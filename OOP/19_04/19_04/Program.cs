using System;
using System.Globalization;

namespace _19_04 {
    class Program {
        static void Main(string[] args) {

            Produto produto = new Produto();


            Console.WriteLine("Entre com os dados dos produtos: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            produto.setNome(nome);

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            produto.setPreco(preco);


            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.setQtd(qtd);

                
    
                Console.WriteLine($"Dados do produto:" + produto);

            Console.Write("Digite o numero de produtos a ser adicionados ao estoque: ");
            int push = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.adicionarProdutos(push);

            Console.WriteLine($"Dados Atualizados:" + produto);

            Console.Write("Digite o numero de produtos a ser removidos do estoque: ");
            int pop = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.removerProdutos(pop);

            Console.WriteLine($"Dados Atualizados:" + produto);



        }
    }
}
