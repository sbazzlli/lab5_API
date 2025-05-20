using API_lab5.Models;

namespace API_lab5.Services;

public interface IPersonService
{
    Task<Person> GetPerson(string login);
}
