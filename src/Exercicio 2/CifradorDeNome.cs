using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_
{
    public class CifradorDeNome
    {
    
        public string Cifrar(string nome)
        {
            string nomeCifrado = string.Empty;
            foreach (char letra in nome)
            {
                if (char.IsLetter(letra))
                {
                    char letraBase = char.IsUpper(letra) ? 'A' : 'a';
                    char letraCifrada = (char)((((letra - letraBase) + 2) % 26) + letraBase);
                    nomeCifrado += letraCifrada;
                }
                else
                {
                    nomeCifrado += letra;
                }
            }
            return nomeCifrado;
        }
    }
}
