namespace _9.Dependency_Inversion_Principle.After
{
    class Mail : IMessageService
    {
        public string Address { get; set; }
        public void send()
        {
            Console.WriteLine($"Email is sent to {Address}");
        }
    }
}