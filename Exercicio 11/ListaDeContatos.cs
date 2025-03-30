using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_11
{
    public class ListaDeContatos
    {
        private FileSystemOperation fileSystemOperation = new FileSystemOperation();
        public void AdicionarContato()
        {
            Contato contato = new Contato();

            if (contato == null)
            {
                Console.WriteLine("O contato não pode ser nulo.");
                return;
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Nome: ");
            contato.Nome = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            contato.Telefone = Console.ReadLine();

            Console.WriteLine("Email: ");
            contato.Email = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------------");

            string conteudo = $"{contato.Nome},{contato.Telefone},{contato.Email}";
            fileSystemOperation.EscreverArquivo(conteudo);

            Console.WriteLine("Contato cadastrado com sucesso!");
            Console.WriteLine("---------------------------------------------------------------------");
        }

        public void ListarContatos()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            //fileSystemOperation.LerArquivo();
            Console.WriteLine("Contatos cadastrados:");

            var contatos = fileSystemOperation.LerArquivo();

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

