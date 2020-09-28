using System;

namespace DesignPatterns {
    class Program {
        static void Main(string[] args) {



            EmailSingleton.Instancia.Corpo = "blabla";
            EmailSingleton.Instancia.Destino = "developer.mauricio1@gmail.com";
            EmailSingleton.Instancia.Origin = "carvalhomauricioads@gmail.com";
            EmailSingleton.Instancia.Titulo = "Teste01";

            EmailSingleton.Instancia.EnviarEmail();

        }
    }
}
