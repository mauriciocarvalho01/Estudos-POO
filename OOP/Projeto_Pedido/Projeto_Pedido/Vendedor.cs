using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Pedido {
    class Vendedor : Pedido {


        public Vendedor() { }
        public Vendedor(int cod, string nome, string telefone,
            string endereco, List<Produto> produto, 
            List<Form_Pagamento> pagamento, DateTime data, string cnpj, string cpf)
            : base (cod, nome, endereco, telefone, produto, pagamento, data, cnpj, cpf) {
            
        }



        public override void Confirmar() {
            Console.WriteLine("Confirmar Vendedor");
            Console.WriteLine(
                 $"Codigo: {this.cod}\n" +
                 $"Nome: {this.nome}\n" +
                 $"Endereço: {this.endereco}\n" +
                 $"Telefone: {this.telefone}\n"
                 );
        }

    }
}
