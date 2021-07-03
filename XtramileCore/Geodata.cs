using System;
using System.Collections.Generic;

namespace XtramileCore
{
    public class Geodata : IGeodata
    {
        public string Country { get; set; }
        public List<string> Cities { get; set; }
    }
}
