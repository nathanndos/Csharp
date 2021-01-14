using System;
using System.Text;
using System.Collections.Generic;


namespace Teste1
{
    
    class Program
    {

       static  List<Professor> profs = new List<Professor>();
        static public Professor Testa(int idTeste){

            foreach(var n in profs){
                if(n._id == idTeste){
                    return n;
                }else{
                    return null;
                };
            }
        }
        static void Main(string[] args)
        {
            

          AlunoClass aluno2 = new AlunoClass();
          Professor prof1 = new Professor();
          Turma t1 = new Turma();
          

            Console.WriteLine("Entre com nome ");   
                aluno2._nome = Console.ReadLine();
            Console.WriteLine("Digite A idade: ");
                aluno2._idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o id do aluno");
                aluno2.idAluno = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Digite o nome do professor: ");
                prof1._nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do professor: ");
                prof1._idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o Id do professor: ");
                prof1._id = Convert.ToInt16(Console.ReadLine());
            profs.Add(prof1);

            Console.WriteLine("Digite o numero da turma");
                t1._num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Numero de Alunos: ");
                t1.qntAlunos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o Id do professor Correspondente: ");
            int k = Convert.ToInt16(Console.ReadLine());;
            Program.Testa(k);

            Console.WriteLine("Numero da turma: "+ t1._num+ "\nDados Professor: " + t1._dadosProfessor._nome);
            
        }
    }
}
