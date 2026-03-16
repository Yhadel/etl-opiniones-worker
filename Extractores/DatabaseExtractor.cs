using System;
using System.Threading.Tasks;

public class DatabaseExtractor : IExtractor
{
    public async Task ExtractAsync()
    {
        Console.WriteLine("Extrayendo datos desde Base de Datos...");
        await Task.Delay(1000);
    }
}