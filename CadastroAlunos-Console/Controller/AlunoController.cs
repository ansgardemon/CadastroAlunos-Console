using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CadastroAlunos_Console.Model;

namespace CadastroAlunos_Console.Controller
{
    public class AlunoController
    {
        private List<Aluno> alunos = new();
        private int proximoId = 1;


        public void CadastrarAluno(string nome, string cpf, string curso, DateTime dataNascimento)
        {
            Aluno novoAluno = new Aluno(proximoId++, nome, cpf, dataNascimento, curso);
            alunos.Add(novoAluno);
        }   


        public List<Aluno> ListarAlunos()
        {
            return alunos;
        }



        public bool AtualizarAluno(int id, string nome, string curso, DateTime dataNascimento)
        {
            Aluno aluno = alunos.Find(a => a.Id == id);
            if (nome == null) return false;

            aluno.Nome = nome;
            aluno.Curso = curso;
            aluno.DataNascimento = dataNascimento;
            aluno.Cpf = curso;
            return true;
        }




    }
}
