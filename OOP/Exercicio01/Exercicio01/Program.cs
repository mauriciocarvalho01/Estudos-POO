using System;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            Corrente c1 = new Corrente("SANTANDER", 1234, 98765);
            Console.WriteLine("######## NÚMERO DA CONTA" + c1.NumConta);

            Titular t1 = new Titular();
            t1.Nome = "Raphael";
            t1.CPF = 123124441;
            Corrente c2 = new Corrente("SANTANDER", 1234, 98765, t1, "", 10.0, 1.0);

            Console.WriteLine(c2.Titular.Nome);
        }
    }
}