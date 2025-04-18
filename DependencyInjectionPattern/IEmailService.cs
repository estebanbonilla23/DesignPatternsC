namespace DesignPatternsC.DependencyInjectionPattern
{
    internal interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
