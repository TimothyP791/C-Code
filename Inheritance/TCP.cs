using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class TCP : BaseNetworkUtility
    {
        public override void Send()
        {
            Console.WriteLine("Sending TCP... TCP Sent");
        }
    }
}
