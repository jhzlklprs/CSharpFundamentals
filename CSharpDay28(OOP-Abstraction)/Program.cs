namespace CSharpDay28_OOP_Abstraction_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Notification> notifications = new List<Notification>();

            EmailNotification em = new EmailNotification("John", "Hello", "em@gmail.com");
            PushNotification pn = new PushNotification("Jake", "Hi", 2025011);
            SmsNotification sn = new SmsNotification("Levi", "What's up!", "123456789");

            notifications.Add(em);
            notifications.Add(pn);
            notifications.Add(sn);

            foreach (var n in notifications)
            {
                n.LogNotifications();
            }


        }
    }
}
