using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_C_.Exercicio_6
{
    public class Aluno
    {
        private string Nome { get; set; }
        private double Matricula { get; set; }
        private string Curso { get; set; }
        private double Media { get; set; }

        public Aluno(string nome, double matricula, string curso, double media)
        {
            Nome = nome;
            Matricula = matricula;
            Curso = curso;
            Media = media;
        }

        public string ExibirDados()
        {
            return $"Nome: {Nome}\nMatrícula: {Matricula}\nCurso: {Curso}\nMédia: {Media}";
        }

        public string VerificarAprovacao()
        {
            return Media >= 7 ? "Aprovado" : "Reprovado";
        }
    }
}
