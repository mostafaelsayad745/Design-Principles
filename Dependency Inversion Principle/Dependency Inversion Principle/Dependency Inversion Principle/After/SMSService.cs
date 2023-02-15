namespace _9.Dependency_Inversion_Principle.After
{
    class SMSService : IMessageService
    {
        public string MobileNo { get; set; }
        public void send()
        {
            Console.WriteLine($"Mobile number is sent to {MobileNo}");
        }
    }
}