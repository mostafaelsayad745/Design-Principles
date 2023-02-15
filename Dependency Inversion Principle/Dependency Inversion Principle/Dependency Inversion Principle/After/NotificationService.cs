namespace _9.Dependency_Inversion_Principle.After
{
    internal class NotificationService
    {
        private readonly List<IMessageService> messages;
        

        public NotificationService(List<IMessageService> messageService)
        {
            messages = messageService;
        }
        public void Notify()
        {

            foreach (var message in messages)
            {
                message.send();
            }
        }
    }
    internal class NotificationService1
    {
        public  List<IMessageService> messages { private set; get; } = new(); 


       
        public void Notify()
        {

            foreach (var message in messages)
            {
                message.send();
            }
        }

        public void setService (List<IMessageService> messages)
        {
            this.messages = messages;
        }
    }



    internal class NotificationService2
    {
       
        public void Notify(List<IMessageService> messages)
        {

            foreach (var message in messages)
            {
                message.send();
            }
        }

    }
}