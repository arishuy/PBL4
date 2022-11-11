using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PBL4
{
    public class CBBItem
    {
        public IPAddress Value { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
