using System;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {

            Empresa empresa = new Empresa(); // Super classe
            Fornecedor fornecedor = new Fornecedor();// Filho

            empresa.nome = "Amazon";
            empresa.cnpj = 44556666666;
            empresa.razaoSocial = "Amazon LLC";
            empresa.inscricaoEstadual = 665656;
            empresa.endereco = "Vale do Silicio";
            empresa.tel = 4522223;
            empresa.email = "www.amazon.com";

            fornecedor.SetCod(8888);
            fornecedor.SetConf(true);
            fornecedor.nome = "Google";
            fornecedor.cnpj = 44556666666;
            fornecedor.razaoSocial = "Google LLC";
            fornecedor.inscricaoEstadual = 665656;
            fornecedor.endereco = "Vale do Silicio";
            fornecedor.tel = 4522223;
            fornecedor.email = "www.google.com";

            //Cadastrar
            empresa.CadastraEmpresa();

            //Excluir
            empresa.ExcluiEmpresa();

            //Alterar
            empresa.AlteraEmpresa();

            //Listar 
            empresa.ListaEmpresa();


            //Cadastrar
            fornecedor.CadastraFornecedor();

            //Excluir
            fornecedor.ExcluiFornecedor();

            //Alterar
            fornecedor.AlteraFornecedor();

            //Listar 
            fornecedor.ListaFornecedor();


        }
    }
}
