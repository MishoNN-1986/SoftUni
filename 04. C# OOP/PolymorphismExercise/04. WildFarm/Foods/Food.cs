﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04._WildFarm.Food
{
    public abstract class Food
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; private set; }
    }
}
