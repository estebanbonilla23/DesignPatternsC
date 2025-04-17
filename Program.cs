using DesignPatternsC;

IRepository<User> userRepository = new UserRepositoryMock();

Console.WriteLine("Getting all users...\n");
var users = await userRepository.GetAllAsync();
PrintList(users);

Console.WriteLine("\nAdding a new user...\n");
await userRepository.AddAsync(new User
{
    FullName = "Test User",
    Email = "test@example.com"
});

Console.WriteLine("Updated user list:\n");
var updatedUsers = await userRepository.GetAllAsync();
PrintList(updatedUsers);
    

// Generic method to print any list of objects
static void PrintList<T>(IEnumerable<T> items)
{
    foreach (var item in items)
    {
        foreach (var prop in typeof(T).GetProperties())
        {
            var value = prop.GetValue(item);
            Console.Write($"{prop.Name}: {value}    ");
        }
        Console.WriteLine();
    }
}