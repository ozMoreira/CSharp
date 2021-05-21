using Export_Estoque.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Export_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o diretório completo >>> ");
            string path = Console.ReadLine();
            Console.Write("Digite o Nome do Arquivo >>> ");
            string file = Console.ReadLine();
            var alvo = Path.GetFullPath(path + @"\" + file + ".csv");
            string filePath = (alvo.ToString());

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                string onlyPath = Path.GetDirectoryName(filePath);
                string outputPath = onlyPath + @"\out";
                string outputFilePath = outputPath + @"\summary.csv";

                Directory.CreateDirectory(outputPath);

                using (StreamWriter sw = File.AppendText(outputFilePath))
                {
                    foreach(string line in lines)
                    {
                        string[] campos = line.Split(';');
                        string produto = campos[0];
                        
                        double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(campos[2]);

                        Produto p = new Produto(produto, preco, qtd);

                        sw.WriteLine($"{p.Nome},{p.CalculaEstoqueFiscal().ToString("F2")}");

                    }
                }
                Console.WriteLine(" --- CALCULO E EXPORTACAO REALIZADO COM SUCESSO ----");
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO FATAL! :");
                Console.WriteLine(e.Message);
            }
        }
    }
}
