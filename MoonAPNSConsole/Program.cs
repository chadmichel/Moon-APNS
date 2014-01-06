using MoonAPNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonAPNSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var payload1 = new NotificationPayload("c2cc30d808a0d623b8f95ac66f3abd4525ee16119d88b0055c260d81e64ad89f", "");

            var p = new List<NotificationPayload> { payload1 };

            var push = new PushNotification(false, @"C:\dev\certs\chadtest1.p12", "panicblaster");
            var rejected = push.SendToApple(p);
            foreach (var item in rejected)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
