using ContaCorrente;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CRIAR CONTA [1]\tENTRAR [2]");
            string cadastro = Console.ReadLine();
            switch (cadastro) {
                case "1":
                    Console.WriteLine("CORRENTE [1]\tPOUPANÇA [2]");
                    string tipoConta = Console.ReadLine();
                    switch (tipoConta) {
                        case "1":
                            Corrente c1 = new Corrente();
                            

                            Console.WriteLine("Digite o nome: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite o CPF: ");
                            string cpf = Console.ReadLine();
                            Console.WriteLine("Digite o banco: ");
                            string banco = Console.ReadLine();
                            c1.setBanco(banco);
                           
                            Random cc = new Random();

                            int gerCod_C = cc.Next(100000, 999999);
                            char[] conta = gerCod_C.ToString().ToCharArray();
                            Console.WriteLine("Número da conta: " + int.Parse(conta));

                            int gerCod_A = cc.Next(1000, 9999);
                            string ag = gerCod_A.ToString();
                    
                            string agencia = (ag + "-" + conta[0].ToString());
                            Console.WriteLine("Número da agência: " + agencia);

                            Console.WriteLine("Digite sua renda mensal: ");
                            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.WriteLine("Digite o valor do depósito inicial: ");
                            double deposito = double.Parse(Console.ReadLine());

                            c1.cliente = new Cliente();
                           
                            c1.cliente.nomeCliente = nome;
                            c1.cliente.cpfCliente = cpf;
                            c1.cliente.setBanco(banco);
                            c1.cliente.agenciaCliente = agencia;
                            c1.cliente.numContaCliente = int.Parse(conta);
                            c1.cliente.setRenda(renda);

                            c1.cliente.listarConta();

                            Console.WriteLine(c1.listarConta());
                           


                            Console.WriteLine("Cadastre uma senha numérica de 4 digitos\n");
                            string key =  Console.ReadLine();

                            char[] toChar = key.ToCharArray();
               
                             while (toChar.Length > 4) {
                                    Console.WriteLine("Senha maior que 4 digitos\n");
                                Console.WriteLine("Cadastre uma senha alfa-numérica de 4 digitos\n");
                                key = Console.ReadLine();
                                toChar = key.ToCharArray();
                            };
    
                            c1.efetuarDeposito(deposito);
                            
                            // fim criar conta

                            Console.WriteLine("\n\tCONTA CORRENTE CRIADA COM SUCESSO!\n\t");
                            Console.WriteLine("################## Opções ##################");
                            Console.WriteLine(" ");

                            bool finalizar = false;

                            while (finalizar == false) {
                                Console.WriteLine("Escolha uma opção!");
                                Console.WriteLine(" ");
                                Console.WriteLine("Saldo [1]\t Transferência[2]\t Depósitos [3]\n" +
                                                  "Cheques [4]\tEmpréstimos [5]\tLimite de Crédito [6]\nSair [0]");
                                string opcao = Console.ReadLine();

                                // Funções da Opções de Conta
                                switch (opcao) {
                                    case "0":
                                        finalizar = true;
                                        break;
                                    case "1":
                                        Console.WriteLine(" ");
                                        c1.imprimirSaldo();
                                        Console.WriteLine(" ");
                                        break;
                                    case "2":
                                        Console.WriteLine("Digite o nome do beneficiário:");
                                        string nom = Console.ReadLine();
                                        Console.WriteLine("Digite o CPF:");
                                        string cp = Console.ReadLine();
                                        Console.WriteLine("Digite o banco:");
                                        string bc = Console.ReadLine();
                                        Console.WriteLine("Digite o número da agência:");
                                        string age = Console.ReadLine();
                                        Console.WriteLine("Digite o número da conta:");
                                        int ct = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite o valor: ");
                                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                        c1.Taxa = 0.1;

                                        int i = 0;
                                        int j = 3;
                       

                                        do {
                                            Console.WriteLine("Digite a senha:");
                                            string senha = Console.ReadLine();

                                            if (senha == key) {
                                                Console.WriteLine("\n\t TRANFERÊNCIA REALIZADA COM SUCESSO!\n");
                                                c1.efetuarTransferencia(cp, nom, bc, age, ct, valor);
                                                break;
                                            }
                                            else {
                                                if (j == 0) {
                                                    Console.WriteLine("\n\tTRANSFERÊNCIA NÃO REALIZADA\t\n");
                                                    break;
                                                }
                                                Console.WriteLine("Senha inválida!:");
                                                Console.WriteLine($"Você tem mais {--j}");

                                            }

                                            i++;
                                        } while (i < 3);
                                        break;
                                    case "3":
                                        string okay = "1";
                                        do {
                                            Console.WriteLine("\t\nCONFIRMAR DADOS DA CONTA\t\n");
                                            Console.WriteLine(c1.listarConta());
                                            Console.WriteLine("Confirmar [1] Dados Incorretos[0]\n");
                                            okay = Console.ReadLine();

                                            switch (okay) {
                                                case "1":
                                                    c1.Taxa = 0.0;
                                                    Console.WriteLine("Digite o valor: ");
                                                    double depo = double.Parse(Console.ReadLine());
                                                    c1.efetuarDeposito(depo);
                                                    Console.WriteLine("Deposito Realizado com suceso!\n");
                                                    break;
                                                case "0":
                                                    Console.WriteLine("Depósito cancelado!");
                                                    break;
                                                default:
                                                    Console.WriteLine("Opção Incorreta!");
                                                    break;

                                            }
                                        } while (okay != "1");

                                        break;
                                    case "4":

                                        Console.WriteLine("Qual o valor do cheque?");
                                        double cheque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                        c1.compensarCheque(cheque);
                                        break;
                                    case "5":
                                        Bancario funcionario = new Bancario();
                                        Console.WriteLine("Digite o valor do empréstimo: ");
                                        double emprestimo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                        funcionario.efetuarEmpréstimo(renda, emprestimo);
                                        if (funcionario.efetuarEmpréstimo(renda,emprestimo)) {
                                            c1.efetuarDeposito(emprestimo);
                                        }
                                        else {
                                            break;
                                        }
                                        
                                        break;

                                    case "6":
                                        Gerente gerente = new Gerente();
  
                                        gerente.efetuarLimiteCredito(renda);
                            
                                        break;

                                    default:
                                        Console.WriteLine("Opção Inválida!");
                                        break;

                                }   // Fim Funções da Opções de Conta

                            }// Fim Opções de Conta

                            break;
                        case "2":
                            Console.WriteLine("POUPANÇA");
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Digite o banco: ");
                    string Banco = Console.ReadLine();
                    Console.WriteLine("Digite o número da agência: ");
                    string Agencia = Console.ReadLine();
                    Console.WriteLine("Digite o número da conta: ");
                    string Conta = Console.ReadLine();
                    Console.WriteLine("\n\tCLIENTE NÃO ENCONTRADO!\t\n");
                    Console.WriteLine("\n\tCRIE UMA CONTA E TENHA DESCONTO NOS CINEMAS!\t\n");
                    break;
                default:
                    Console.WriteLine("\n\tEnte ou faça uma conta agora mesmo!!\t\n");
                    break;

            }

            }
    }
}
