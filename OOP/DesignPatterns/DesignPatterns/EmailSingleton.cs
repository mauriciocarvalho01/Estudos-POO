using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns {
   public  class EmailSingleton {

        private static EmailSingleton instancia;
        public  string Destino;
        public  string Corpo;
        public  string Origin;
        public  string Titulo;

        private EmailSingleton() { }


        public  void EnviarEmail() {
            Console.WriteLine($"Enviando email para: {Destino}\n" +
                              $"Com o titulo de: {Titulo}\n" +
                              $"Corpo: {Origin}");
        }

        public static EmailSingleton Instancia {
            get {
                if (instancia == null) {
                    instancia = new EmailSingleton();
                }

                return instancia;

            }

            
        }
    }
}
