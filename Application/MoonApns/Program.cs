/*Copyright 2011 Arash Norouzi

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

﻿using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace MoonAPNS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // var payload1 = new NotificationPayload("Device token","Message",Badge,"Sound");
            var payload1 = new NotificationPayload("c2cc30d808a0d623b8f95ac66f3abd4525ee16119d88b0055c260d81e64ad89f", "");
            
            var p = new List<NotificationPayload> {payload1};

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
