using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_8
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, string cargo, double salario) : base(nome, cargo, salario + (salario * 0.2))
        { 
        }
    }
}
