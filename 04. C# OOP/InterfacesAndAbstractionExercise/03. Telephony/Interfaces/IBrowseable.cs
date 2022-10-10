using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Telephony.Interfaces
{
    public interface IBrowseable : ICallable
    {
        string Browse(string site);
    }
}
