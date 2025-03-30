using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AT_C_.src;

namespace AT_C_
{
    public class Exercicio4
    {
        public static void Executar()
        {
            Console.Write("Digite a sua data de nascimento (dd/mm/aaaa): ");
            string dataString = Console.ReadLine();
            DateTime dataNascimento;
            string formato = "dd/MM/yyyy";

            if (Utils.ConverterData(dataString, formato, out dataNascimento))
            {
                DateTime dataAtual = DateTime.Now;
                DateTime proximoAniversario;

                if (dataNascimento.Day == 29 && dataNascimento.Month == 2 && !DateTime.IsLeapYear(dataAtual.Year))
                {
                    proximoAniversario = new DateTime(dataAtual.Year, 2, 28);
                }
                else
                {
                    proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);
                }

                if (proximoAniversario < dataAtual)
                {
                    proximoAniversario = proximoAniversario.AddYears(1);
                }
                int diasRestantes = (proximoAniversario - dataAtual).Days;

                if (diasRestantes < 7)
                {
                    Console.WriteLine("Faltam menos de uma semana para o seu aniversário!");
                }
                else
                {
                    Console.WriteLine($"Faltam {diasRestantes} dias para o seu aniversário!");
                }
            }
        }
        
    }
}
