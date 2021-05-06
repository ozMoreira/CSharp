using System;

namespace Structs_Nullable_POO {
    class Program {
        static void Main(string[] args) {

            Nullable<double> a = null;
            double? x = null;
            double? y = 10.0;

            //pega valor existente ou retorna o valor padrão de null
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Diz se a variavel tem valor ou não
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Lança excessão, se chamar num objeto nullable que esta dando nulo
            /*
            Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);
            */

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            } else {
                Console.WriteLine("X IS NULL");
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            } else {
                Console.WriteLine("X IS NULL");
            }

            //Operador de Coalescencia Nulla
            //JOga numa outra variavel c, o valor à direita do operador, caso b seja nulo
            double? b = null;
            double? c = 10.0;

            double d = b ?? 5;
            double e = c ?? 5;

            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
