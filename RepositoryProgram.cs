using DesignPatternsC.Objects;
using DesignPatternsC.RepositoryPattern;
using DesignPatternsC.Newtonsoft;
using DesignPatternsC.DependencyInjectionPattern;

IRepository<User> userRepository = new UserRepositoryMock();

Console.WriteLine("Getting all users...\n");
var users = await userRepository.getAllAsync();
PrintList(users);

Console.WriteLine("\nAdding a new user...\n");
await userRepository.addAsync(new User
{
    FullName = "Test User",
    Email = "test@example.com"
});

Console.WriteLine("Updated user list:\n");
var updatedUsers = await userRepository.getAllAsync();
PrintList(updatedUsers);

Console.WriteLine("---");
NewtonsoftImplementation.postUserAsync();

// Manual Dependency Injection
Console.WriteLine("---");
IEmailService emailService = new EmailService();
OrderService orderService = new OrderService(emailService);
orderService.ProcessOrder("customer@example.com");


// Generic method to print any list of objects
static void PrintList<T>(IEnumerable<T> items)
{
    foreach (var item in items)
    {
        foreach (var prop in typeof(T).GetProperties())
        {
            var value = prop.GetValue(item);
            Console.Write($"{prop.Name}: {value}");
        }
        Console.WriteLine();
    }
}