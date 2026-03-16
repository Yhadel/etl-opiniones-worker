using System;
using System.IO;
using System.Threading.Tasks;

public class CsvExtractor : IExtractor
{
    public async Task ExtractAsync()
    {
        Console.WriteLine("Extrayendo datos desde CSV...");

        string path = "data/productos.csv";

        if (File.Exists(path))
        {
            var lines = await File.ReadAllLinesAsync(path);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("Archivo CSV no encontrado");
        }
    }
}