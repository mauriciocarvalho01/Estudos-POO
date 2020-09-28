using System;
using System.Globalization;

namespace Vetores {
    class Program {
        static void Main(string[] args) {


            // Aula Vetores

            // EX 01

            /* Console.WriteLine("Digite o número de pessoas");
             int n = int.Parse(Console.ReadLine());

             Console.WriteLine(n);

             double[] altura = new double[n];

             Console.WriteLine(altura.Length);

             Console.WriteLine("Digite a altura das pessoas");
             int i = 0;
             while ( i < n) {
                 altura[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                 i++;
             }

             double media = 0.0;
             foreach( double e in altura) {
                 media += e;
             }

             media /= altura.Length;

             Console.WriteLine("Media: " + media.ToString("F2", CultureInfo.InvariantCulture));

     */




            // EX 02
            /* Console.WriteLine("Entre com a quantidade de produtos");
             int qtd = int.Parse(Console.ReadLine());

             Produto[] prod = new Produto[qtd];

             Console.WriteLine("Entre com os produtos");
             int a = 0;
             while (a < prod.Length) {
                 prod[a] = new Produto();
                 Console.WriteLine("Entre com o nome do produto");
                 prod[a].Nome = Console.ReadLine();
                 Console.WriteLine("Entre com o preço do produto");
                 prod[a].Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 a++;
             }

             double media_preco = 0.0;
             foreach(Produto produtoPreco in prod) {
                 media_preco += produtoPreco.Preco;
             }

             media_preco /= prod.Length;


             Console.WriteLine(media_preco.ToString("F2", CultureInfo.InvariantCulture));*/



            // Aula Vetores com Armazenamento de objetos

            /*  Estudante[] estudante = new Estudante[10];

              Console.WriteLine("How many rooms will be rented?");
              int n = int.Parse(Console.ReadLine());

              int i = 1;
              while(i <= n) {
                  Console.WriteLine($"Rent #{i}:");
                  Console.Write("Name: ");
                  string nome = Console.ReadLine();
                  Console.Write("Email: ");
                  string email = Console.ReadLine();
                  Console.Write("Room: ");
                  int room = int.Parse(Console.ReadLine());
                  estudante[room] = new Estudante();
                  estudante[room].Nome = nome;
                  estudante[room].Email = email;
                  i++;
              }

              Console.WriteLine("Busy Rooms:");
              for (int a = 0; a < estudante.Length; a++) {
                  if(estudante[a] != null) {
                      Console.WriteLine($"{a}: {estudante[a]}");
                  }

      */


            // O params --> dentro de Calculadora.Soma() faz com que o método aceite varios valores,
            //sem precisar criar varios métodos com a quantidade de parametros diferentes
            /*  Calculadora cal = new Calculadora();

              int[] numeros = new int[5];
              numeros[0] = 1;
              numeros[1] = 2;
              numeros[2] = 3;
              numeros[3] = 4;
              numeros[4] = 5;

              int n1 =  cal.Soma(numeros);

              Console.WriteLine(n1);*/

            // O modificador 'ref' faz uma referencia para a variavel original
            // Ou seja, ela passa pelo método e é referenciada também na outra classe
            // O modificador 'out' funciona da mesma forma, porém não precisa ser inicializada
            Calculadora calc = new Calculadora();

            int a = 10;
            calc.Triple(ref a);
            Console.WriteLine(a);


            int n = 10;
            int m = 5;

            int s;

            calc.Subtrair(n, m, out s);
            Console.WriteLine(s);

        }
        }
    }

