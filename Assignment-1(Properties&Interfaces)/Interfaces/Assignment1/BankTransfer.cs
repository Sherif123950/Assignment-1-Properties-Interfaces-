using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Interfaces.Assignment1
{
    internal class BankTransfer : IPayable
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Paid By Bank Transfer");
        }
    }
}
