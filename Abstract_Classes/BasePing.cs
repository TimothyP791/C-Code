﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public abstract class BasePing
    {
        public int HostAddress { get; set; }

        public int DestAddress { get; set; }

        public string Data { get; set; }

        public abstract bool Init();
        

    }
}
