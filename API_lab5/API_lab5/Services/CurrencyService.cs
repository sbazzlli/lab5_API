using API_lab5.Models;
using System.Text.Json;

namespace API_lab5.Services;

public class CurrencyService : ICurrencyService
{
    public async Task<Currency> GetCurrencyRate(string _base, string _target)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://exchange-rates7.p.rapidapi.com/convert?base={_base}&target={_target}"),
            Headers =
            {
                { "x-rapidapi-key", "3ae4d0188fmsh6f8f3c9af2a872cp1b69bfjsna3f9b9a6ef62" },
                { "x-rapidapi-host", "exchange-rates7.p.rapidapi.com" },
            },
        };

        var result = new Currency();

        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            result = JsonSerializer.Deserialize<Currency>(body);
            Console.WriteLine(body);
        }

        return result;
    }
}
