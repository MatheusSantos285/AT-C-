using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_12
{
    public class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Contatos cadastrados:");


            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado!");
            }
            else
            {
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
