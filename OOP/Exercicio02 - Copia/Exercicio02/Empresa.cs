using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercicio02 {
    class Empresa {
        public string nome { get; set; }
        public string endereco { get; set; }
        public int tel { get; set; }
        public long cnpj { get; set; }
        public string razaoSocial { get; set; }
        public long inscricaoEstadual { get; set; }
        public string email { get; set; }

        public Empresa() { }
        public Empresa(string nome, long cnpj, string endereco,
            int tel, string razaoSocial, long inscricaoEstadual,
            string email) {

            this.nome = nome;
            this.cnpj = cnpj;
            this.endereco = endereco;
            this.tel = tel;
            this.razaoSocial = razaoSocial;
            this.inscricaoEstadual = inscricaoEstadual;
            this.email = email;
        }


        public void ListaEmpresa() {
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"CNPJ: {this.cnpj}");
            Console.WriteLine($"Endereço: {this.endereco}");
            Console.WriteLine($"Razão Social: {this.razaoSocial}");
            Console.WriteLine($"Inscrição Estadual: {this.inscricaoEstadual}");
            Console.WriteLine($"Telefone: {this.tel}");
            Console.WriteLine($"Email: {this.email}");
        }

        public void CadastraEmpresa() {
            Console.WriteLine($"Nome da Empresa: {this.nome}");
            Console.WriteLine("Cadastro efetuado com sucesso!");
        }

        public void ExcluiEmpresa() {
            Console.WriteLine($"Nome da Empresa: {this.nome}");
            Console.WriteLine("Excluido com sucesso!");
        }

        public void AlteraEmpresa() {
            Console.WriteLine($"Nome da Empresa: {this.nome}");
            Console.WriteLine("Alterado com sucesso!");
        }



    }
}
