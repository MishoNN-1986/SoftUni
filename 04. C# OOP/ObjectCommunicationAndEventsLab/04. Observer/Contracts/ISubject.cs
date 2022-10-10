using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Observer.Contracts
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void NotifyObservers();
    }
}
