using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_9.Manipulação_de_Arquivos
{
    public class FileSystemOperation
    {
        const string filePath = @"H:\Meu Drive\Desenvolvimento C#\estoque.txt";

        public void CriarArquivo()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    Console.WriteLine("Arquivo criado com sucesso!");
                }
                else
                {
                    Console.WriteLine("O arquivo já existe!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar o arquivo: {ex.Message}");
            }
        }

        public void EscreverArquivo(string conteudo)
        {
            try
            {
                using (StreamWriter file = File.AppendText(filePath))
                {
                    file.WriteLine(conteudo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao escrever no arquivo: {ex.Message}");
            }
        }

        public void LerArquivo()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("O arquivo não existe.");
                    return;
                }

                string[] linhas = File.ReadAllLines(filePath);

                if (linhas.Length == 0)
                {
                    Console.WriteLine("O arquivo está vazio.");
                    return;
                }

                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Erro: O arquivo não foi encontrado.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro de leitura do arquivo: {ex.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado! {e.Message}");
            }
        }

        public int ContarProdutos()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return 0;
                }

                int contador = 0;

                using (StreamReader file = new StreamReader(filePath))
                {
                    while (file.ReadLine() != null)
                    {
                        contador++;
                    }
                }
                return contador;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao contar os produtos: {ex.Message}");
                return 0;
            }
        }
    }
}