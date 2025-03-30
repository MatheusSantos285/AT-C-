using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_11
{
    public class AppContatos
    {
        private static ListaDeContatos listaDeContatos = new ListaDeContatos();
        public static void App()
        {
            int opcao;

            do
            {
                ExibirMenu();
                opcao = LerOpcao();
                ProcessarOpcao(opcao);
            } while (opcao != 3);

        }

        private static void ExibirMenu()
        {
            Console.WriteLine("### Gerenciador de Contatos ####");
            Console.WriteLine("---- Escolha a opção desejada ----");
            Console.WriteLine("1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar contatos cadastrados");
            Console.WriteLine("3 - Sair");
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
            switch (opcao)
            {
                case 1:
                    listaDeContatos.AdicionarContato();
                    break;
                case 2:
                    listaDeContatos.ListarContatos();
                    break;
                case 3:
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
