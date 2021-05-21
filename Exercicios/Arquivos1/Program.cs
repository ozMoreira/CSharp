using System;
using System.IO;

namespace Arquivos1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\tmp\file1.txt";
            string targetPath = @"c:\tmp\file2.txt";

            try
            {
                // instancia um objeto ao arquivo que existir no path
                FileInfo fileInfo = new FileInfo(sourcePath);
                //Cria uma copia do arquivo instanciado
                fileInfo.CopyTo(targetPath);
                //Le um arquivo e instancia um vetor com o conteudo do arquivo
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um ERRO!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
