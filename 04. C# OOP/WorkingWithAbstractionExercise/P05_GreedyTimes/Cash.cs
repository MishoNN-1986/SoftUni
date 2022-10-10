using System;
using System.Collections.Generic;
using System.Text;

namespace P05_GreedyTimes
{
    public class Cash : Item
    {
        public Cash(string key, long value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
