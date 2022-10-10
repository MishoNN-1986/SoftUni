using System;
using System.Collections.Generic;
using System.Text;

namespace _06._FoodShortage.Interfaces
{
    public interface IBuyer : IName
    {
        int Food { get; }

        void BuyFood();
    }
}
