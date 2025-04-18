using System.Text;
using DesignPatternsC.Objects;
using Newtonsoft.Json;

namespace DesignPatternsC.Newtonsoft
{
    public class NewtonsoftImplementation
    {
        static User user = new User
        {
            Id = Guid.NewGuid(),
            FullName = "John Doe",
            Email = "john.doe@example.com"
        };

        public static async Task postUserAsync()
        {
            var json = JsonConvert.SerializeObject(user);
            Console.WriteLine(json);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
           
            using var httpClient = new HttpClient();
            var response = await httpClient.PostAsync("https://api.example.com/users", content);

            var responseText = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseText);
        }

        public async Task getUsersAsync()
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api.example.com/users");
            var users = JsonConvert.DeserializeObject<List<User>>(response);
        }
    }
}
