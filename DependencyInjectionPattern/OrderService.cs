namespace DesignPatternsC.DependencyInjectionPattern
{
    internal class OrderService
    {
        private readonly IEmailService _emailService;

        // Constructor injection
        public OrderService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void ProcessOrder(string customerEmail)
        {
            // Simulate order processing logic
            Console.WriteLine("Processing order...");

            // Notify customer via email
            _emailService.SendEmail(customerEmail, "Order Confirmation", "Your order has been processed.");
        }
    }
}
