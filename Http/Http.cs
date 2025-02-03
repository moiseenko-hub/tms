using System.Net.Http.Json;
using ConsoleApp1_tms;

namespace Http;

public class Http
{
    private static HttpClient _httpClient = new()
    {
        BaseAddress = new Uri("https://jsonplaceholder.typicode.com"),
        
    };
    static async Task Main(string[] args)
    {
        await GetAsync(_httpClient);
    }

    static async Task GetByIdAsync(HttpClient httpClient)
    {
        using HttpResponseMessage response = await httpClient.GetAsync("todos/1");
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine(jsonResponse);
    }
    
    static async Task GetAsync(HttpClient httpClient)
    {
        using HttpResponseMessage response = await httpClient.GetAsync("todos");
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine(jsonResponse);
    }

    static async Task PostAsync(HttpClient httpClient)
    {
        using HttpResponseMessage response =
            await httpClient.PostAsJsonAsync("posts", new User(false,"Andrey",11));
        
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{jsonResponse}\n");
    }

    static async Task PathAsync(HttpClient httpClient)
    {
        using HttpResponseMessage response =
            await httpClient.PutAsJsonAsync("posts/1", new User(true, "Kirill", 22));
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{jsonResponse}\n");
    }
    
    static async Task DeleteAsync(HttpClient httpClient)
    {
        using HttpResponseMessage response =
            await httpClient.DeleteAsync("posts/1");
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{jsonResponse}\n");
    }
}