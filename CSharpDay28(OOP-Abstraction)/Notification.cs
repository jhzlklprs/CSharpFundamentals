using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay28_OOP_Abstraction_
{
    abstract internal class Notification
    {
        public string Recipient { get; }
        public string Message { get; }


        public Notification (string recipient, string message)
        {
            Recipient = recipient;
            Message = message;
        }

        public abstract bool Send();

        public virtual void LogNotifications()
        {
            bool success = Send();
            if (success)
            {
                Console.WriteLine($"[LOG] Notification sent to {Recipient}\n");
            }
            else
            {
                Console.WriteLine($"[LOG] Failed to send notification to {Recipient}\n");
            }
        }
    }
}
