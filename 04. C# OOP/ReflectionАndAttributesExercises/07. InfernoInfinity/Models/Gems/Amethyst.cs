using _07._InfernoInfinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Models.Gems
{
    public class Amethyst : Gem
    {
        public Amethyst(GemClarity clarity)
            : base(clarity, 2, 8, 4)
        {
        }
    }
}
