using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_12
{
    public class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("| Nome | Telefone | Email");

            Console.WriteLine("---------------------------------------------------------------------");

            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado!");
            }
            else
            {
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"| {contato.Nome} | {contato.Telefone} | {contato.Email}");
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
