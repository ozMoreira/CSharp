using System;
using System.Collections.Generic;

namespace Listas_POO {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Ana");
            list.Add("Bob");
            list.Add("Alex");
            list.Insert(2, "Marco");


            foreach (string nomes in list) {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("List Count: " + list.Count);

            // recebe como argumento uma funcao que faz um teste ou expressao lambda
            string s1 = list.Find(Test);
            Console.WriteLine("First A: " + s1);

            string s2 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A Lambda: " + s2);

            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A Lambda: " + s3);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao First A Lambda: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posicao Last A Lambda: " + pos2);
            Console.WriteLine("------------------------");
            
            List<string> list3 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list3) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------");
           
            list.Remove("Alex");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------");
            list.RemoveAt(1);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------");
            //Declarando, instanciando e inicializando uma lista
            List<string> list2 = new List<string> { "Maria", "Alex", "Pedro", "Antonio"};
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------");
            list2.RemoveRange(1, 2);
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }


        }
        static bool Test(string s) {
            return s[0] == 'A';
        }
    }
}
