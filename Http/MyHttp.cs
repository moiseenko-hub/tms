using System.Net.Http.Json;
using ConsoleApp1_tms;

namespace Http;

public class MyHttp
{
    private static HttpClient _httpClient = new()
    {
        BaseAddress = new Uri("https://jsonplaceholder.typicode.com"),
        
    };
    static async Task GetByIdAsync(HttpClient httpClient, int id)
    {
        using HttpResponseMessage response = 
            await httpClient.GetAsync($"todos/{id}");
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine(jsonResponse);
    }
    
    static async Task GetAsync(HttpClient httpClient)
    {
        using HttpResponseMessage response = 
            await httpClient.GetAsync("todos");
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine(jsonResponse);
    }

    static async Task PostAsync(HttpClient httpClient, User user)
    {
        using HttpResponseMessage response =
            await httpClient.PostAsJsonAsync("posts", user);
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{jsonResponse}\n");
    }

    static async Task PutAsync(HttpClient httpClient, int id, User user)
    {
        using HttpResponseMessage response =
            await httpClient.PutAsJsonAsync($"posts/{id}", user);
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{jsonResponse}\n");
    }
    
    static async Task PathAsync(HttpClient httpClient, int id, User user)
    {
        using HttpResponseMessage response =
            await httpClient.PatchAsJsonAsync($"posts/{id}", user);
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{jsonResponse}\n");
    }
    
    static async Task DeleteAsync(HttpClient httpClient, int id)
    {
        using HttpResponseMessage response =
            await httpClient.DeleteAsync($"posts/{id}");
        var jsonResponse = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"{jsonResponse}\n");
    }
}