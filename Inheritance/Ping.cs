using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Ping : BaseNetworkUtility
    {
        public override void Send()
        {
            Console.WriteLine("Pinging... Ping Sent");
        }
    }
}
