using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_12
{
    public class AppContatos2
    {
        private static ListaDeContatos2 listaDeContatos = new ListaDeContatos2();
        private static FileSystemOperation fileSystemOperation = new FileSystemOperation();
        public static void App()
        {
            int opcao;

            do
            {
                ExibirMenu();
                opcao = LerOpcao();
                ProcessarOpcao(opcao);
            } while (opcao != 5);

        }

        private static void ExibirMenu()
        {
            Console.WriteLine("### Gerenciador de Contatos ####");
            Console.WriteLine("---- Escolha a opção desejada ----");
            Console.WriteLine("1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar contatos cadastrados no formato Markdown");
            Console.WriteLine("3 - Listar contatos cadastrados no formato Tabela");
            Console.WriteLine("4 - Listar contatos cadastrados no formato Texto Puro");
            Console.WriteLine("5 - Sair");
        }

        private static int LerOpcao()
        {
            Console.Write("Opção: ");
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Opção inválida. Digite um número válido.");
                return -1;
            }

            return opcao;
        }

        private static void ProcessarOpcao(int opcao)
        {
            var contatos = fileSystemOperation.LerArquivo();

            switch (opcao)
            {
                case 1:
                    listaDeContatos.AdicionarContato();
                    break;
                case 2:
                    new MarkdownFormatter().ExibirContatos(contatos);
                    break;
                case 3:
                    new TabelaFormatter().ExibirContatos(contatos);
                    break;
                case 4:
                    new RawTextFormatter().ExibirContatos(contatos);
                    break;
                case 5:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Saindo...");
                    Console.WriteLine("---------------------------------------------------------------------");
                    return;
                default:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;
            }
        }
    }
}
