using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseNetworkUtility
    {
        public int HostAddress { get; set; }
        public int DestAddress { get; set; }
        public int Data { get; set; }

        public  virtual void Send()
        {
            Console.WriteLine("Send");
        }
    }
}
