using System;
using System.Globalization;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {

            int leia = int.Parse(Console.ReadLine());

            int senha = 2002;

            do {
                Console.WriteLine("Senha Invalida");
                leia = int.Parse(Console.ReadLine());
            } while (leia != senha);

            if(leia == senha) {
                Console.WriteLine("Acesso Permitido");
            }


           
        }
    }
}
