using System;

namespace Metodos_Strings {
    class Program {
        static void Main(string[] args) {
            string qualquer = "abcde FGHIJ ABC abc DEFG    ";
            string s1 = qualquer.ToUpper();
            string s2 = qualquer.ToLower();
            string s3 = qualquer.Trim();
            int n1 = qualquer.IndexOf("bc");
            int n2 = qualquer.LastIndexOf("bc");
            string s4 = qualquer.Substring(3);
            string s5 = qualquer.Substring(3, 5);
            string s6 = qualquer.Replace('a', '*');
            string s7 = qualquer.Replace("abc", "xy");
            bool b1 = string.IsNullOrEmpty(qualquer);
            bool b2 = string.IsNullOrWhiteSpace(qualquer);

            Console.WriteLine("Original: -" + qualquer + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf ('bc'): -" + n1 + "-");
            Console.WriteLine("LastIndexOf ('bc'): -" + n2 + "-");
            Console.WriteLine("Substring (3): -" + s4 + "-");
            Console.WriteLine("Substring (3,5): -" + s5 + "-");
            Console.WriteLine("Replace ('a', 'x'): -"+ s6 + "-");
            Console.WriteLine("Replace ('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2 + "-");
        }
    }
}
