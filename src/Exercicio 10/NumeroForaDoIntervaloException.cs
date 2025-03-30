using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_10
{
    public sealed class NumeroForaDoIntervaloException : Exception
    {
        public int Numero { get; }

        public NumeroForaDoIntervaloException(int numero, string message = "Número fora do intervalo de 1 a 50!") : base(message)
        {
            Numero = numero;
        }

        public override string ToString()
        {
            return $"{Numero} -> {Message}";
        }
    }
}
