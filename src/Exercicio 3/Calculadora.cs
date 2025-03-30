using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_
{
    public class Calculadora
    {
        public static void Executar()
        {
            Calculadora calculadora = new Calculadora();

            Console.Write("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("#### Escolha a Operação ####");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            Console.Write("Operação: ");
            int operacao = int.Parse(Console.ReadLine());

            double resultado = calculadora.Calcular(operacao, a, b);
            Console.WriteLine($"Resultado: {resultado:F2}");
            Console.WriteLine();
        }
        public double Somar(double a, double b)
        {
            return a + b;
        }
        public double Subtrair(double a, double b)
        {
            return a - b;
        }
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public double Dividir(double a, double b)
        {
            return a / b;
        }

        public double Calcular(int operacao, double a, double b)
        {
            switch (operacao)
            {
                case 1:
                    return Somar(a, b);
                case 2:
                    return Subtrair(a, b);
                case 3:
                    return Multiplicar(a, b);
                case 4:
                    return Dividir(a, b);
                default:
                    throw new ArgumentException("Operação inválida");
            }
        }

    }
}
