using _07._InfernoInfinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Models.Gems
{
    public class Emerald : Gem
    {
        public Emerald(GemClarity clarity)
            : base(clarity, 1, 4, 9)
        {
        }
    }
}
