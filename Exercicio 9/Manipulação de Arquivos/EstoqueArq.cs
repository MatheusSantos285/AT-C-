using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_9.Manipulação_de_Arquivos
{
    public class EstoqueArq
    {
        private FileSystemOperation fileSystemOperation = new FileSystemOperation();
        public void AdicionarProduto()
        {
            int quantidadeProdutos = fileSystemOperation.ContarProdutos();

            if (quantidadeProdutos >= 5)
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Limite de produtos atingido.");
                Console.WriteLine("---------------------------------------------------------------------");
                return;
            }

            ProdutoArq produto = new ProdutoArq();

            if (produto == null)
            {
                Console.WriteLine("O produto não pode ser nulo.");
                return;
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade em estoque: ");
            if (!int.TryParse(Console.ReadLine(), out int quantidade))
            {
                Console.WriteLine("Quantidade inválida. Digite um número inteiro.");
                return;
            }
            produto.QuantidadeEmEstoque = quantidade;

            Console.WriteLine("Digite o preço unitário: ");
            if (!double.TryParse(Console.ReadLine(), out double preco))
            {
                Console.WriteLine("Preço inválido. Digite um número válido.");
                return;
            }
            produto.PrecoUnitario = preco;
            Console.WriteLine("---------------------------------------------------------------------");

            string conteudo = $"{produto.Nome},{produto.QuantidadeEmEstoque},{produto.PrecoUnitario}";
            fileSystemOperation.EscreverArquivo(conteudo);

            Console.WriteLine("Produto adicionado com sucesso!");
            Console.WriteLine("---------------------------------------------------------------------");
        }

        public void ListarProdutos()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            fileSystemOperation.LerArquivo();
            Console.WriteLine("---------------------------------------------------------------------");
        }


    }
}
