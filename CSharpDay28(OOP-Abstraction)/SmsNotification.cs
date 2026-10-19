using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay28_OOP_Abstraction_
{
    internal class SmsNotification : Notification
    {
        public string PhoneNumber { get; set; }

        public SmsNotification(string recipient, string message, string phoneNumber)
            : base (recipient, message)
        {
            PhoneNumber = phoneNumber;
        }

        public override bool Send()
        {
            Console.WriteLine($"Sending SMS to {PhoneNumber}: {Message}");
            return true;
        }
    }
}
