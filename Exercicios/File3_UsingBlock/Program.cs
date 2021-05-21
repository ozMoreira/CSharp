using System;
using System.IO;

namespace File3_UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\tmp\file1.txt";

            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                //}
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO: ");
                Console.WriteLine(e.Message);
            }


        }
    }
}
