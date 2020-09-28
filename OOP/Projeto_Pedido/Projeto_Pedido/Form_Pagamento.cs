using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Pedido {
    class Form_Pagamento {

       public  string nome_pag { get; set; }
       public  string banco { get; set;  }
      

        public Form_Pagamento() { }
        public Form_Pagamento(string nome_pag, string banco) {
            this.nome_pag = nome_pag;
            this.banco = banco;
          
        }

        public override string ToString() {
            return $"Banco: {banco}\n" +
                   $"Forma de pagamento: {nome_pag} ";
        }

    }

  
}
