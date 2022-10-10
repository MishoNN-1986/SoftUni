using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Contracts
{
    public interface IObserver
    {
        void Update(int val);
    }
}
