using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02 {
    class Fornecedor : Empresa {
     
        private int codigoForn;
        private bool confirmacaoForn;
        
        public Fornecedor() { }

        public Fornecedor(string nome, long cnpj, string endereco,
            int tel, string razaoSocial, long inscricaoEstadual, 
            string email, int codigoForn, bool confirmacaoForn )
            : base (nome, cnpj, endereco, tel,  razaoSocial, inscricaoEstadual, email) {
            this.codigoForn = codigoForn;
            this.confirmacaoForn = confirmacaoForn;

        }


           public int getCod() {
            return this.codigoForn;
        }

        public void SetCod(int codigoForn) {
            this.codigoForn = codigoForn;
        }

        public bool getConf() {
            return this.confirmacaoForn;
        }

        public void SetConf(bool confirmacaoForn) {
            this.confirmacaoForn = confirmacaoForn;
        }


        public void ListaFornecedor() {
            Console.WriteLine($"Codigo do Fornecedor: {this.codigoForn}");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Cadastrado: {this.confirmacaoForn}");
            Console.WriteLine($"CNPJ: {this.cnpj}");
            Console.WriteLine($"Razão Social: {this.razaoSocial}");
            Console.WriteLine($"Inscrição Estadual: {this.inscricaoEstadual}");
            Console.WriteLine($"Endereço: {this.endereco}");
            Console.WriteLine($"Telefone: {this.tel}");
            Console.WriteLine($"Email: {this.email}");
        }

           public void CadastraFornecedor() {
            Console.WriteLine($"Codigo do Fornecedor: {this.codigoForn}");
            Console.WriteLine("Cadastro efetuado com sucesso!");
            this.confirmacaoForn = true;
            Console.WriteLine($"Status: {this.getConf()}");
        }

        public void ExcluiFornecedor() {
            Console.WriteLine($"Codigo do Fornecedor: {this.codigoForn}");
            Console.WriteLine("Excluido com sucesso!");
            this.confirmacaoForn = false;
            Console.WriteLine($"Status: {this.getConf()}");
        }

         public void AlteraFornecedor() {
            Console.WriteLine($"Codigo do Fornecedor: {this.codigoForn}");
            Console.WriteLine("Alterado com sucesso!");
            this.confirmacaoForn = true;
            Console.WriteLine($"Status: {this.getConf()}");
        }



    }
}