using System;
using System.IO;


namespace Arquivos_Directory_DirecInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\tmp\DirectoryTest";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFILES: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
