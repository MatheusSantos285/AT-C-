using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_9.Array
{
    public class Estoque
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            if (produtos.Count < 5)
            {
                if (produto == null)
                {
                    Console.WriteLine("O produto não pode ser nulo.");
                    return;
                }

                ColetarDados(produto);
                produtos.Add(produto);
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Limite de produtos atingido!");
                Console.WriteLine("---------------------------------------------------------------------");
            }

        }

        public void ListarProdutos()
        {
            foreach(Produto produto in produtos)
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine($"Produto: {produto.Nome} | Quantidade: {produto.QuantidadeEmEstoque} | Preço: R$ {produto.PrecoUnitario:F2}");
                Console.WriteLine("---------------------------------------------------------------------");
            }
        }

        private void ColetarDados(Produto produto)
        {
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
        }

    }
}
