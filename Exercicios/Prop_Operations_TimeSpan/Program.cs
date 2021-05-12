using System;

namespace Prop_Operations_TimeSpan {
    class Program {
        static void Main(string[] args) {
            TimeSpan t1 = TimeSpan.MinValue;
            TimeSpan t2 = TimeSpan.MaxValue;
            TimeSpan t3 = TimeSpan.Zero;
            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            TimeSpan soma = t5.Add(t6);
            TimeSpan dif = t5.Subtract(t6);
            TimeSpan multi = t6.Multiply(2.0);
            TimeSpan div = t6.Divide(2.0);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            Console.WriteLine("Days: " + t4.Days);
            Console.WriteLine("Hours: " + t4.Hours);
            Console.WriteLine("Minutes: " + t4.Minutes);
            Console.WriteLine("Seconds: " + t4.Seconds);
            Console.WriteLine("Milliseconds: " + t4.Milliseconds);

            Console.WriteLine("TotalDays: " + t4.TotalDays);
            Console.WriteLine("Hours: " + t4.TotalHours);
            Console.WriteLine("Minutes: " + t4.TotalMinutes);
            Console.WriteLine("Seconds: " + t4.TotalSeconds);
            Console.WriteLine("Milliseconds: " + t4.TotalMilliseconds);

            Console.WriteLine(soma);
            Console.WriteLine(dif);
            Console.WriteLine(multi);
            Console.WriteLine(div);
        }
    }
}
