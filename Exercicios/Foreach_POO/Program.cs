using System;

namespace Foreach_POO {
    class Program {
        static void Main(string[] args) {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            foreach(string nome in vect) {
                Console.WriteLine(nome);
            }
        }
    }
}
