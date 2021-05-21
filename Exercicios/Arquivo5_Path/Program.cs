using System;
using System.IO;

namespace Arquivo5_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\tmp\DirectoryTest\file1.txt";

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            var alvo = Path.GetFullPath(path + @"\" + "EstoqueInput" + ".csv");
            Console.WriteLine(alvo);

        }
    }
}
