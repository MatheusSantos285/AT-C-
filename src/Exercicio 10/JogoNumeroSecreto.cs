using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_10
{
    public class JogoNumeroSecreto
    {
        static void VerificarIntervalo(int numero)
        {
            if (numero < 1 || numero > 50)
            {
                throw new NumeroForaDoIntervaloException(numero);
            }
        }
        public static void Jogar()
        {
            int numeroSecreto = new Random().Next(1, 51);
            int tentativas = 0;
            bool acertou = false;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação! Tente adivinhar o número secreto entre 1 e 50.");

            try
            {
                while (tentativas < 5 && !acertou) 
                {
                    Console.WriteLine($"\nTentativa {tentativas + 1} de 5. Digite o seu palpite:");

                    string palpiteInput = Console.ReadLine();

                    if (int.TryParse(palpiteInput, out int palpite))
                    {
                        VerificarIntervalo(palpite);
                        tentativas++;

                        if (palpite == numeroSecreto)
                        {
                            Console.WriteLine($"\nParabéns! Você acertou o número secreto {numeroSecreto} em {tentativas} tentativas.");
                            acertou = true;
                        }
                        else if (palpite < numeroSecreto)
                        {
                            Console.WriteLine("O número secreto é maior.");
                        }
                        else
                        {
                            Console.WriteLine("O número secreto é menor.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um número válido!");
                    }

                }

                if (!acertou)
                {
                    Console.WriteLine($"\nVocê excedeu o limite de tentativas. O número secreto era: {numeroSecreto}");
                }

            } 
            catch (NumeroForaDoIntervaloException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {e.Message}");
            }

        }
    }
}