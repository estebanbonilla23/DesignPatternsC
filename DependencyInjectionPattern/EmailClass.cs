using DesignPatternsC.DependencyInjectionPattern;

public class EmailService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Sending Email to: {to}\nSubject: {subject}\nBody: {body}");
    }
}