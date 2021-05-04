using System;

namespace Boletim_Aluno_POO {
    class Program {
        static void Main(string[] args) {
            
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe os dados do Aluno abaixo:");
            Console.Write("Nome >>> ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Nota do 1º Trim. >>> ");
            aluno.N1 = double.Parse(Console.ReadLine());
            Console.Write("Nota do 2º Trim. >>> ");
            aluno.N2 = double.Parse(Console.ReadLine());
            Console.Write("Nota do 3º Trim. >>> ");
            aluno.N3 = double.Parse(Console.ReadLine());

            if (aluno.Aprovado()) {
                Console.WriteLine("\n\nAluno aprovado com sucesso!!!!");
            } else {
                Console.WriteLine("\n\nREPROVADO - Faltou " 
                    + aluno.MargemFaltante().ToString("F2") + " pontos para aprovação!");
            }
        }
    }
}
