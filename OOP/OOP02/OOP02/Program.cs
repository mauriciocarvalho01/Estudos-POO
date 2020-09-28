using System;

namespace OOP02 {
    class Program {
        static void Main(string[] args) {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Nome: " + p1.idade);


            Console.WriteLine("Dados da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("idade: " + p2.idade);

            if(p1.idade > p2.idade) {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
        }
    }
}
