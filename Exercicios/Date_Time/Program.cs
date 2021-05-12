using System;
using System.Globalization;

namespace Date_Time {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03);
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Parse("2000-08-15");
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d8 = DateTime.Parse("15/08/2000");
            DateTime d9 = DateTime.Parse("15/08/2000 13:05:58");
            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:13", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            
            Console.WriteLine("Date Time Now:" + d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine("Date Time instanciando ano, mes dia: " + d2);
            Console.WriteLine("Date Time instanciando ano, mes dia, Hora, Minuto, Segundo: " +d3);
            Console.WriteLine("Date Time de Hoje com hora zero: " + d4);
            Console.WriteLine("Horario UTC: " + d5);
            Console.WriteLine("Parse '-': " + d6);
            Console.WriteLine("Parse com hora '-': " + d7);
            Console.WriteLine("Parse '/': " + d8);
            Console.WriteLine("Parse com hora '/': " + d9);
            Console.WriteLine("Parse Exact': " + d10);
            Console.WriteLine("Parse Exact': " + d11);
        }
    }
}
