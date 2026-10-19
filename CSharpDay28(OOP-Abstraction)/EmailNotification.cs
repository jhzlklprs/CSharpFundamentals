using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay28_OOP_Abstraction_
{
    internal class EmailNotification : Notification
    {
        public string EmailAddress { get; set; }

        public EmailNotification(string recipient, string message, string emailAddress)
            : base(recipient, message)
        {
            EmailAddress = emailAddress;
        }

        public override bool Send()
        {
            Console.WriteLine($"Sending EMAIL to {EmailAddress}: {Message}");
            return true;
        }
    }
}
