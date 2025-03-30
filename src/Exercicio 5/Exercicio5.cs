using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AT_C_.src;

namespace AT_C_
{
    public class Exercicio5
    {
        public static void Executar()
        {
            Console.Write("Digite data atual (dd/MM/yyyy): ");
            string dataString = Console.ReadLine();
            DateTime dataAtual;
            string formato = "dd/MM/yyyy";

            if (Utils.ConverterData(dataString, formato, out dataAtual))
            {

                if (dataAtual > DateTime.Now)
                {
                    Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                }
                else
                {
                    DateTime dataFormatura = new DateTime(2026, 12, 15);

                    if (dataAtual > dataFormatura)
                    {
                        Console.WriteLine("Parabéns! Você já deveria estar formado!");
                    }
                    else
                    {
                        TimeSpan diferenca = dataFormatura - dataAtual;

                        int anos = dataFormatura.Year - dataAtual.Year;
                        int meses = dataFormatura.Month - dataAtual.Month;
                        int dias = dataFormatura.Day - dataAtual.Day;

                        if (dias < 0)
                        {
                            meses--;
                            dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
                        }

                        if (meses < 0)
                        {
                            anos--;
                            meses += 12;
                        }

                        if (diferenca.TotalDays < 180)
                        {
                            Console.WriteLine($"Faltam {meses} meses e {dias} dias para sua formatura!");
                            Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
                        }
                        else
                        {
                            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");
                        }
                    }
                    
                }
            }

                
            }
        }
    }
