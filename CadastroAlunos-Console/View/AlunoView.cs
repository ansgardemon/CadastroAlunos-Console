using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroAlunos_Console.Controller;

namespace CadastroAlunos_Console.View
{
    public class AlunoView
    {
        private AlunoController controller = new();


        public void MostrarMenu()
        {
            int opcao;
            do
            {
                Console.WriteLine("=== Cadastro do Aluno no SENAC ===");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Listar Aluno");
                Console.WriteLine("3 - Atualizar Aluno");
                Console.WriteLine("4 - Excluir Aluno");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Opção Invalida");
                opcao = int.Parse(Console.ReadLine());


                switch(opcao)
                {
                    case 1: CadastrarAluno();
                    break;

                    //case 2: ListarAlunos();
                    //break;

                    //case 3: AtualizarAluno();
                    //break;

                    //case 4: ExcluirAluno();
                    //break;






                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();


            } while (opcao != 0);

        }

        private void CadastrarAluno()
        {
            Console.WriteLine("Nome:   ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF:   ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Curso:   ");
            string curso = Console.ReadLine();
            Console.WriteLine("Data de Nascimento: (DD/MM/AAAA)  ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());



            controller.CadastrarAluno(nome, cpf, curso, dataNascimento);
            Console.WriteLine("Aluno cadastrado com sucesso");
        }

    }
}
