using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_Pedido {
    class Program {
        static void Main(string[] args) {

            Pedido pedido = new Pedido();
            Produto prod = new Produto();
            double total = 0;

            string finalizar = "0";
            do {
                Console.WriteLine("---------------------Cadastre um novo pedido---------------------");
                pedido.data = DateTime.Now;
                Console.WriteLine(pedido.data);
                Console.WriteLine("");

                Console.WriteLine("Dados do cliente");
                Cliente cliente = new Cliente();

                Console.WriteLine("Cliente [1] Juridico [0] Físico");
                string tipoCliente = Console.ReadLine();
                bool conf = false;
                do {
                    if (tipoCliente == "1") {
                        Console.WriteLine("Digite o Cnpj da empresa");
                        cliente.cnpj = Console.ReadLine();
                        cliente.cpf = " ";
                        conf = true;
                    }
                    else if (tipoCliente == "0") {
                        Console.WriteLine("Digite o CPF do Cliente");
                        cliente.cpf = Console.ReadLine();
                        cliente.cnpj = " ";
                      conf = true;
                    }
                  
                } while (conf == false);

                Random cc = new Random();
                int gerCod_C = cc.Next(0, 50);
                cliente.cod = gerCod_C;
                Console.WriteLine("Código do cliente: " + cliente.cod);
                Console.WriteLine("Nome: ");
                cliente.nome = Console.ReadLine();
                Console.WriteLine("Telefone: ");
                cliente.telefone = Console.ReadLine();
                Console.WriteLine("Endereço: ");
                cliente.endereco = Console.ReadLine();

                Console.WriteLine("");

                cliente.Confirmar();

                Console.WriteLine(" ");

                Console.WriteLine("Dados do vendedor");
                Vendedor vendedor = new Vendedor();

                Random cv = new Random();
                int gerCod_V = cv.Next(0, 50);
                vendedor.cod = gerCod_V;
                Console.WriteLine("Código do vendedor: " + vendedor.cod);
                Console.WriteLine("Nome: ");
                vendedor.nome = Console.ReadLine();
                Console.WriteLine("Telefone: ");
                vendedor.telefone = Console.ReadLine();
                Console.WriteLine("Endereço: ");
                vendedor.endereco = Console.ReadLine();

                Console.WriteLine(" ");

                vendedor.Confirmar();

                Console.WriteLine(" ");

                Console.WriteLine("---------------------Insira o(os) produto(os)---------------------");


                string inserir = "0";
                List<Produto> produtoLista = new List<Produto>();
                do {

                    Console.WriteLine("Produto: ");
                    string produto = Console.ReadLine();
                    Console.WriteLine("Preço: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Quantidade: ");
                    double quantidade = double.Parse(Console.ReadLine());
                    produtoLista.Add(new Produto(produto, preco, quantidade));

                    Console.WriteLine("Deseja finalizar o cadastro de produtos? (SIM - 1  NÃO - 0)");

                    prod.valor = preco;
                    prod.quantidade = quantidade;

                    total += prod.CalcularTotal();

                    inserir = Console.ReadLine();
                } while (inserir != "1");

                Console.WriteLine("Deseja finalizar o pedido? (SIM - 1  NÃO - 0)");
                finalizar = Console.ReadLine();

                Form_Pagamento pag = new Form_Pagamento();

                Console.WriteLine("");
                Console.WriteLine("---------------------Pagamento---------------------");
                Console.WriteLine("");
                Console.WriteLine("Escolha a forma de pagamento:");
                Console.WriteLine("Nome do banco: ");
                pag.banco = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Dinheiro\n" +
                                  "2 - Boleto\n" +
                                  "3 - Cartão de crédito\n" +
                                  "4 - Cartão de débito\n" +
                                  "5 - Transferência\n"
                                  );


                int opc = 0;

                do {
                    Console.WriteLine("Escolha um valor entre 1 e 5");
                    opc = int.Parse(Console.ReadLine())  ;

                    switch (opc) {
                        case 1:
                            pag.nome_pag = "1 - Dinheiro";

                            break;
                        case 2:
                            pag.nome_pag = "2 - Boleto";

                            break;
                        case 3:
                            pag.nome_pag = "3 - Cartão de crédito";

                            break;
                        case 4:
                            pag.nome_pag = "4 - Cartão de débito";

                            break;
                        case 5:
                            pag.nome_pag = "5 - Transferência";
                            break;

                        default:
                            break;
                    }
                } while (!(opc >= 1 && opc <= 5));




                Console.WriteLine("Confirmar compra");
                produtoLista.ForEach(elemento => Console.WriteLine(elemento));
                Console.WriteLine("");


                Console.WriteLine("Total:\n" + total.ToString("F2", CultureInfo.InvariantCulture));


                Console.WriteLine(pag);



                Console.WriteLine("Inserir pagamento: ");
                double pague = double.Parse(Console.ReadLine());

                Console.WriteLine("Troco:");
                Console.WriteLine(prod.Troco(pague, total).ToString("F2", CultureInfo.InvariantCulture));

            } while ((finalizar == "0"));

        }
    }
}


