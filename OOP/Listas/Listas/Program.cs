using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas {
    class Program {
        static void Main(string[] args) {

            /* List<string> list = new List<string>();

             list.Add("0lá");
             list.Add("Mundo");
             list.Insert(2, "Lindo");
             list.Add("!");
             list.Add("!0");

             int i = 0;
             foreach(string element in list) {
                if (i < 1) {
                     Console.Write($"{element} ");
            }
                 else {
                     Console.Write($"{element}");
                 }

                 i++;
             }
             Console.WriteLine(" ");


             Console.WriteLine("Tamanho da lista: " + list.Count);
             Console.WriteLine("Encontrar o mundo: " + list.Find(Mundo));

             static bool Mundo(string s) {
                 return s == "Mundo" || s[0] == 'O';
             }

             Console.WriteLine("-------------------------------------------------");
             // Ultima ocorrencia de algo --> no caso é a ultima ocorrecia de quem começa com '!"
             string excl = list.FindLast(e => e[0] == '!');

             Console.WriteLine("Exclamação: " + excl);

             Console.WriteLine("-------------------------------------------------");
             // Toda ocorrência de uma determinada condição retorna uma lista

             List<string> todo = list.FindAll(e => e.Length ==  1);

             foreach (string e in todo) { Console.WriteLine(e); }*/


            Console.WriteLine("-------------------------------------------------");



            //EXERCICIO DE FIXAÇÃO: 

            // Criar um programa para registro de funcionários com ID Name and Salary
            // procurar o funcionário pelo ID e aplicar um aumento.
            //Listar os funcionários e seus salarios

            List<Funcionario> func = new List<Funcionario>();
            Console.Write("How many emplyoees will be registered? ");
            int emplyoeesIndex = int.Parse(Console.ReadLine());

            int i = 1;
            Funcionario emplyoee = new Funcionario();

            do {
                Console.WriteLine($"Emplyoee #{i}");
                Console.Write($"Id: ");
                emplyoee.Id = int.Parse(Console.ReadLine());
                Console.Write($"Nome: ");
                emplyoee.Name = Console.ReadLine();
                Console.Write($"Salary: ");
                emplyoee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Add(emplyoee);
                i++;

            } while (i <= emplyoeesIndex);


            Console.Write("Enter emplyoees Id that will have salary increase: ");
            int emplyoeesIdSearch = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percentil = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario emplyoeeId = func.Find(e => e.Id == emplyoeesIdSearch);

            Console.WriteLine(emplyoeeId.Name, emplyoeeId.Id, emplyoeeId.Salary);

            /*Console.WriteLine("Updated list of employees:");
            foreach (Funcionario f in func) {
                Console.WriteLine($"{f.Id}, {f.Name}, {f.Salary.ToString("F2",CultureInfo.InvariantCulture)}");
            }*/











        }
    }
}
