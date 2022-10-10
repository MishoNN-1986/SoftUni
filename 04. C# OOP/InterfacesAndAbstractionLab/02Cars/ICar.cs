using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public interface ICar
    {
        string Model { get; } //анстракция на кола
        string Color { get; }
        string Start();
        string Stop();
    }
}
