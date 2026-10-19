using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay28_OOP_Abstraction_
{
    internal class PushNotification : Notification
    {
        private int deviceId;
        public int DeviceId
        {
            get { return deviceId; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("DeviceID can't be negative!");
                }
                else
                {
                    deviceId = value;
                }
            }
        }

        public PushNotification(string recipient, string message, int deviceId)
            : base(recipient, message)
        {
            DeviceId = deviceId;
        }

        public override bool Send()
        {
            Console.WriteLine($"Sending PUSH to device {DeviceId}: {Message}");
            return true;
        }
    }
}
