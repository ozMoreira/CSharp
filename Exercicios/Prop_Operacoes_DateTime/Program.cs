using System;

namespace Prop_Operacoes_DateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(1989, 3, 27, 13, 45, 58, 275);
            DateTime d1 = new DateTime(1985, 10, 08, 13, 45, 58);
            DateTime d2 = d1.AddHours(2);
            DateTime d3 = d1.AddMinutes(3);
            TimeSpan t = d.Subtract(d1);

            string s1 = d1.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Second: " + d.Second);
            Console.WriteLine("10) Month: " + d.Month);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("--------------------");
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(t);



        }
    }
}
