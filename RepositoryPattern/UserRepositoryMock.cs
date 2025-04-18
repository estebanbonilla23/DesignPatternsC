using DesignPatternsC.Objects;
using DesignPatternsC.RepositoryPattern;

public class UserRepositoryMock : IRepository<User>
{
    private readonly List<User> _users;
    private readonly Random _random = new Random();

    public UserRepositoryMock()
    {
        _users = generateMockUsers(10);
    }

    private List<User> generateMockUsers(int count)
    {
        var users = new List<User>();
        for (int i = 0; i < count; i++)
        {
            users.Add(new User
            {
                Id = Guid.NewGuid(),
                FullName = $"User {_random.Next(1000, 9999)}",
                Email = $"user{_random.Next(1000, 9999)}@example.com"
            });
        }
        return users;
    }

    public Task<IEnumerable<User>> getAllAsync()
    {
        return Task.FromResult<IEnumerable<User>>(_users);
    }

    public Task<User> getByIdAsync(Guid id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        return Task.FromResult(user);
    }

    public Task addAsync(User user)
    {
        user.Id = Guid.NewGuid();
        _users.Add(user);
        return Task.CompletedTask;
    }
}
