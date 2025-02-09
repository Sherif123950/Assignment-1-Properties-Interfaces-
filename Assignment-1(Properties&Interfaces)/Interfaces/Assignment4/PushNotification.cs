using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Interfaces.Assignment4
{
    internal class PushNotification:INotify
    {
        public void Send()
        {
            Console.WriteLine("Sent Via Notification");
        }
    }
}
