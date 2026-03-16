using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public class Worker : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("Iniciando proceso ETL...");

        CsvExtractor csv = new CsvExtractor();
        DatabaseExtractor db = new DatabaseExtractor();
        ApiExtractor api = new ApiExtractor();

        await csv.ExtractAsync();
        await db.ExtractAsync();
        await api.ExtractAsync();

        Console.WriteLine("Proceso de extracción completado.");
    }
}