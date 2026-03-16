using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiExtractor : IExtractor
{
    public async Task ExtractAsync()
    {
        Console.WriteLine("Extrayendo datos desde API...");

        HttpClient client = new HttpClient();

        var response = await client.GetAsync("https://jsonplaceholder.typicode.com/comments");

        var data = await response.Content.ReadAsStringAsync();

        Console.WriteLine("Datos recibidos de la API");
    }
}