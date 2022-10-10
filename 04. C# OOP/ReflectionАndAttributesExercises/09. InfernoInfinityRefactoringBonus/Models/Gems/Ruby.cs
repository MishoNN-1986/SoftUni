using _09._InfernoInfinityRefactoringBonus.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Models.Gems
{
    public class Ruby : Gem
    {
        public Ruby(GemClarity clarity)
            : base(clarity, 7, 2, 5)
        {
        }
    }
}
