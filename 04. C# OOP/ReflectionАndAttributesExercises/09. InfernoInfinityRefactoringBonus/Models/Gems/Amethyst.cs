using _09._InfernoInfinityRefactoringBonus.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Models.Gems
{
    public class Amethyst : Gem
    {
        public Amethyst(GemClarity clarity)
            : base(clarity, 2, 8, 4)
        {
        }
    }
}
