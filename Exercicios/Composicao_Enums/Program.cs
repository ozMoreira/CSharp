using System;
using Composicao_Enums.Entities;
using Composicao_Enums.Entities.Enums;

namespace Composicao_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, Enter department's name: >>> ");
            string deptName = Console.ReadLine();
            Console.WriteLine("\n---- ENTER WORKER DATA BELOW----");
            Console.Write("Name: >>> ");
            string wkName = Console.ReadLine();
            Console.Write("Level (Junior / MidLevel / Senior): >>> ");
            WorkerLevel wkLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: >>> R$ ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(wkName, wkLevel, baseSalary, dept);

            Console.Write("\nHow many contrats to this worker? >>> ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\n--- Enter #{i} contract data: ---");
                Console.Write("Date (DD/MM/YYYY): >>> ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: >>> R$ ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): >>> ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and Year to calculate income (MM/YYY): ");
            string mY = Console.ReadLine();
            int month = int.Parse(mY.Substring(0, 2));
            int year = int.Parse(mY.Substring(3, 4));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + mY + ": R$ " + worker.Income(year, month).ToString("F2"));
        }
    }
}
