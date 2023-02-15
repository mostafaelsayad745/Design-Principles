using _9.Dependency_Inversion_Principle.After;
using System.Security.Principal;

namespace _9.Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // before
            /* var customers = Repository.Customers;
             foreach (var customer in customers)
             {
                 NotificationService notificationService = new NotificationService(customer);
                 notificationService.Notify();
             }*/

            // after
            // constructor injection
            var customers = Repository.Customers;
            foreach (var customer in customers)
            {
                var messageService = new List<After.IMessageService>()
                {
                    new After.EmailService() { EmailAddress = customer.EmailAddress},
                    new After.SMSService(){MobileNo = customer.MobileNo},
                    new After.Mail(){Address = customer.Address}
                };

                //var notificationService = new After.NotificationService(messageService);
                //notificationService.Notify();




                // property Injection

/*
                var notificationService1 = new After.NotificationService1();
                //notificationService1.messages = messageService;  // or the next one
                notificationService1.setService(messageService);
                notificationService1.Notify();*/


                // method injection
                var notificationService2 = new After.NotificationService2();
                notificationService2.Notify(messageService);

            }


        }
    }
}