using System;
using System.Collections.Generic;
using System.Text;

namespace FestivalManager.Entities.Sets
{
    public class Short : Set
    {
        public Short(string name)
            : base(name, new TimeSpan(0, 15, 0))
        {
        }
    }
}
