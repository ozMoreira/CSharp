using System.Diagnostics;
using System;

namespace SistemaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();
            string insereEstudante = "N";


            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Deseja acrescentar um novo aluno e nota?? (Y/N)");
                        insereEstudante = Console.ReadLine();

                        while (insereEstudante.ToUpper() != "N")
                        {
                            Console.WriteLine("Informe o nome do Aluno:");
                        
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine($"Informe a nota do " + aluno.Nome + ":");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota= nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        Console.WriteLine();
                        Console.WriteLine($"O aluno " + aluno.Nome + " foi inserido com a nota "+aluno.Nota+" com sucesso!!!");
                        Console.WriteLine();
                        insereEstudante = "N";
                        Console.WriteLine("Deseja acrescentar um novo aluno e nota?? (Y/N)");
                        insereEstudante = Console.ReadLine();
                        }
                        break;
                        
                        
                    case "2":
                        foreach(var a in alunos)
                        {
                            if (a.Nome != null)
                            {
                                Console.WriteLine($"Aluno: {a.Nome}    Nota: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal/nrAlunos;
                        ConceitoEnum conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = ConceitoEnum.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = ConceitoEnum.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = ConceitoEnum.C;
                        }
                        else if (mediaGeral <= 8)
                        {
                            conceitoGeral = ConceitoEnum.B;
                        }
                        else 
                        {
                            conceitoGeral = ConceitoEnum.A;
                        }
                        Console.WriteLine($"A Média Geral foi de {mediaGeral} - O Conceito Geral da Classe foi {conceitoGeral}");
                        break;
                    default:

                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular Média Geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
