using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class UDP : BaseNetworkUtility
    {
        public override void Send()
        {
            Console.WriteLine("Sending UDP... UDP Sent");
        }
    }
}
