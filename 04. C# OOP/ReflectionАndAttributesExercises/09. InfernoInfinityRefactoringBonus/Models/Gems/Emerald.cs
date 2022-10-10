using _09._InfernoInfinityRefactoringBonus.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Models.Gems
{
    public class Emerald : Gem
    {
        public Emerald(GemClarity clarity)
            : base(clarity, 1, 4, 9)
        {
        }
    }
}
