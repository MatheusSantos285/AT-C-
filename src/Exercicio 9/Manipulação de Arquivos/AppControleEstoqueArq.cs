using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_9.Manipulação_de_Arquivos
{
    public class AppControleEstoqueArq
    {
        private static EstoqueArq estoque = new EstoqueArq();
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
            Console.WriteLine("#### Controle de Estoque ####");
            Console.WriteLine("---- Escolha a opção desejada ----");
            Console.WriteLine("1 - Inserir Produto");
            Console.WriteLine("2 - Listar Produtos");
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
                    ProdutoArq produto = new ProdutoArq();
                    estoque.AdicionarProduto();
                    break;
                case 2:
                    estoque.ListarProdutos();
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
