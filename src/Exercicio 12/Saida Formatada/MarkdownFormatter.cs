using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_12
{
    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("## Lista de Contatos\n");

            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado!");
            }
            else
            {
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"- **Nome:** {contato.Nome}\n- **Telefone:** {contato.Telefone}\n- **Email:** {contato.Email}\n");
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
