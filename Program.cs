using System;
using System.Text;


namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp1;
            int resp2;

          AlunoClass aluno2 = new AlunoClass();

            Console.WriteLine("Entre com nome ");   
                resp1 = Console.ReadLine();
            Console.WriteLine("Digite A idade: ");
                resp2 = Convert.ToInt32(Console.ReadLine());
            aluno2.cadastro(resp1, resp2);
            aluno2.Ler();
            
        }
    }
}
