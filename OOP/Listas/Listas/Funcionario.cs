using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Listas {
    class Funcionario {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario() { }

        public void ReajustaSalario(double percentil) {
            Salary += Salary * (percentil / 100);
        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary.ToString("F2",CultureInfo.InvariantCulture)}";
        }


    }
}
