using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_12
{
    public class FileSystemOperation
    {
        const string filePath = @"H:\Meu Drive\Desenvolvimento C#\contatos.txt";

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

        public List<Contato> LerArquivo()
        {
            var contatos = new List<Contato>();

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("O arquivo não existe.");
                    return contatos;
                }

                using (var reader = new StreamReader(filePath)) 
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        var partes = linha.Split(',');
                        if (partes.Length == 3)
                        {
                            contatos.Add(new Contato
                            {
                                Nome = partes[0].Trim(),
                                Telefone = partes[1].Trim(),
                                Email = partes[2].Trim(),
                            });
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Erro: O arquivo não foi encontrado.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro de leitura do arquivo: {ex.Message}");
                return contatos;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado! {e.Message}");
            }
            return contatos;
        }
    }
}
