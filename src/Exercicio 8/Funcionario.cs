using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_8
{
    public class Funcionario
    {
        protected string Nome { get; set; }
        protected string Cargo { get; set; }
        protected double Salario { get; set; }

        public Funcionario(string nome, string cargo, double salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public string ExibirDados()
        {
            return $"Nome: {Nome}\nCargo: {Cargo}\nSalário: R$ {Salario:F2}";
        }
    }
}
