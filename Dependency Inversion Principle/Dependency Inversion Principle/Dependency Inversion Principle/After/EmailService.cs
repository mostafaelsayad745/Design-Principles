namespace _9.Dependency_Inversion_Principle.After
{
    class EmailService : IMessageService
    {
        public string EmailAddress { get; set; }
        public void send()
        {
            Console.WriteLine($"Email is sent to {EmailAddress}");
        }
    }
}