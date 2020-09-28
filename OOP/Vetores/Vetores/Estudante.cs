using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores {
    class Estudante {

        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante() {

        }
        public Estudante(string email, string nome) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return $"{Nome},{Email}";
        }
    }
}
