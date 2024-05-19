using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public class PingIPv6 : BasePing
    {
        public override bool Init()
        {
            return true;
        }
        public bool SendPing()
        {
            return true;
        }
    }
}
