﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Projeto_Pedido {
   class Pedido {
        public int cod { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }

        public string cnpj { get; set; }
        public DateTime data { get; set; }

        double prod { get; set; }
        
        List<Form_Pagamento> pagamento { get; set; }
        List<Produto> produto { get; set; }


        public Pedido() { }

        
        public Pedido( int cod, string nome, string telefone, 
            string endereco, List<Produto> produto, List<Form_Pagamento>
            pagamento, DateTime data, string cnpj, string cpf) {
            this.cod = cod;
            this.cnpj = cnpj;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
            this.nome = nome;
            this.produto = produto;
            this.pagamento = pagamento;
            this.data = data;

        }


        private void TipoCliente() {
            string cliente = "";
            if (this.cpf != " ") {
                cliente = "Cliente Físico\n";
                Console.WriteLine(cliente);
                Console.WriteLine("CPF: " + this.cpf);
            }
            else if (this.cnpj != " ") {
                cliente = "Cliente Juridico\n";
                Console.WriteLine(cliente);
                Console.WriteLine("Cnpj: " + this.cnpj);
            }else {
                this.cnpj = "Cnpj não cadastrado\n";
                this.cpf = "Cpf não cadastrado";

                Console.WriteLine(cnpj,cpf);
            }
        }
        public virtual void Confirmar() {
            TipoCliente();
            Console.WriteLine(
                $"Codigo: {this.cod}\n" +
                $"Nome: {this.nome}\n" +
                $"Endereço: {this.endereco}\n" + 
                $"Telefone: {this.telefone}\n" 
                );
        }

    }
}
