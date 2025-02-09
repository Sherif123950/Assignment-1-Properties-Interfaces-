using Assignment_1_Properties_Interfaces_.Interfaces.Assignment4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_
{
    internal static class Helper
    {
        public static void NotifyCustomer(INotify notify)
        {
            notify.Send();
        }
    }
}
