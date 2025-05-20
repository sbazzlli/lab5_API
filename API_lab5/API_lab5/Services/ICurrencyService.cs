using API_lab5.Models;

namespace API_lab5.Services;

public interface ICurrencyService
{
    Task<Currency> GetCurrencyRate(string _base, string _target);
}
