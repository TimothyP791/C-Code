using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class UnitTestFunction
    {
        public string ReturnsSomethingIfZero(int num)
        {
            if (num == 0)
            {
                return "Something";
            }
            else
            {
                return "Something else";
            }
        }
    }
 }
