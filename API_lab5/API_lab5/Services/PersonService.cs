using API_lab5.Models;

namespace API_lab5.Services;

public class PersonService : IPersonService
{
    private readonly string _login;

    public PersonService(IConfiguration cfg)
    {
        _login = cfg["MoodleLogin"]
            ?? throw new Exception("There is no login provided.");
    }
    public async Task<Person> GetPerson(string login)
    {
        if (_login==login)
        {
            return new Person 
            { 
                Name = "Sofia",
                Surname = "Mykhailova",
                Year = 2,
                GroupName = "IS-31"
            };
        }
        throw new InvalidOperationException("Login is incorrect.");
    }
}
