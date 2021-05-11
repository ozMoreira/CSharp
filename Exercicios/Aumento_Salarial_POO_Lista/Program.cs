using System;
using System.Collections.Generic;

namespace Aumento_Salarial_POO_Lista {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe um número de colaboradores para lançamento >>> ");
            int n = int.Parse(Console.ReadLine());

            List<Colaborador> listQuadro = new List<Colaborador>();

            for (int i = 1; i <= n; i++) {
                Console.Write("\nId: >>> ");
                int id = int.Parse(Console.ReadLine());
                Colaborador validaId = listQuadro.Find(x => x.Id == id);
                while (validaId != null) {
                    Console.Clear();
                    Console.WriteLine("ID EXISTENTE!");
                    Console.Write("\nId: >>> ");
                    id = int.Parse(Console.ReadLine());
                    validaId = listQuadro.Find(x => x.Id == id);
                }
                Console.Write("Colaborador: >>> ");
                string nome = Console.ReadLine();
                Console.Write("Salario >>> R$ ");
                double salario = double.Parse(Console.ReadLine());

                listQuadro.Add(new Colaborador(id, nome, salario));
                Console.Clear();
            }

            Console.Write("Informe o ID do Colaborador que receberá aumento: >>> ");
            int recAumentoID = int.Parse(Console.ReadLine());
            Colaborador pegaId = listQuadro.Find(x => x.Id == recAumentoID);
            Console.WriteLine(pegaId);
            if (pegaId == null) {
                while (pegaId == null) {
                    Console.Clear();
                    Console.WriteLine("ID EXISTENTE!");
                    Console.Write("\nId: >>> ");
                    recAumentoID = int.Parse(Console.ReadLine());
                    pegaId = listQuadro.Find(x => x.Id == recAumentoID);
                }
            } 
            if (pegaId != null) {
                Console.Clear();
                Console.Write("Informe o percentual de reajuste do salario: >>> ");
                double reajuste = double.Parse(Console.ReadLine());
                pegaId.aumentaSalario(reajuste);      
            }

            Console.WriteLine("\n Quadro de Colaboradores:");
            foreach (Colaborador obj in listQuadro) {
                Console.WriteLine(" " + obj);
            }
        }
    }
}

