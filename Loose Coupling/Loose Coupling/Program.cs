namespace Loose_Coupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationMode notificationModeFactory = NotificationModeFactory.Create(NotificationMode.Whats);
            NotificationService notificationService = new NotificationService(notificationModeFactory);
            notificationService.notify();
            Console.ReadKey();
        }
    }
    class NotificationModeFactory
    {
        public static INotificationMode Create(NotificationMode mode)
        {
            switch (mode)
            {
                case NotificationMode.EMAIL:
                    return new Email();
                case NotificationMode.SMS:
                    return new sms();
                case NotificationMode.Whats:
                    return new Whats();
                default:
                    return new Email();

            }
        }
    }
    enum NotificationMode
    {
        EMAIL,
        SMS,
        Whats,
    }
    interface INotificationMode
    {
        public void send();
    }
    class Email : INotificationMode
    {
        public void send()
        {
            Console.WriteLine("email sent");
        }
    }
    class sms : INotificationMode
    {
        public void send()
        {
            Console.WriteLine("sms sent");
        }
    }
    class Whats : INotificationMode
    {
        public void send()
        {
            Console.WriteLine("Whats Sent");
        }
    }

    class NotificationService
    {
        private readonly INotificationMode _notificationMode;
        public NotificationService(INotificationMode notificationMode)
        {
            _notificationMode = notificationMode;
        }

        public void notify()
        {
            _notificationMode.send();
        }
    }




}