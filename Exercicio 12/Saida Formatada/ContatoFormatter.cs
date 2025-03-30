using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AT_C_.Exercicio_11;

namespace AT_C_.Exercicio_12
{
    public abstract class ContatoFormatter
    {

        public virtual void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("Exibição padrão de contatos (não formatada)");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"{contato.Nome}, {contato.Telefone}, {contato.Email}");
            }
        }
    }
}

