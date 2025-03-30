using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_7
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        private double Saldo { get; set; }

        public ContaBancaria(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public string Depositar(double valor)
        {
            if (valor < 0)
            {
                return "O valor do depósito deve ser positivo!";
            }

            Saldo += valor;
            return $"Depósito de R$ {valor} realizado com sucesso!";
        }

        public string Sacar(double valor)
        {
            if (valor < 0)
            {
                return "O valor do saque deve ser positivo!";
            }

            if (valor > Saldo)
            {
                return $"Tentativa de saque: R$ {valor}\nSaldo insuficiente para realizar o saque!";
            }

            Saldo -= valor;    
            return $"Saque de R$ {valor} realizado com sucesso!";

        }

        public string ExibirSaldo()
        {
            return $"Saldo atual: R$ {Saldo:F2}";
        }
    }
}