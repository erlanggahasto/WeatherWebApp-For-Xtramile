using System;
using System.Collections.Generic;
using System.Text;

namespace XtramileCore
{
    public interface IGeodata
    {
        string Country { get; set; }
        List<string> Cities { get; set; }
    }
}
