using System;
using System.IO;

namespace Arquivos4_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\tmp\file1.txt";
            string targetPath = @"c:\tmp\file3.txt";
             
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
