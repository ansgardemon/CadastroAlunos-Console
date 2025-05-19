using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos_Console.Model
{
    public class Aluno
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Curso { get; set; }

        public Aluno(int id, string name, string cpf, DateTime dataNascimento, string curso)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Curso = curso;
        }








    }
}
