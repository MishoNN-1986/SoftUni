using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Contracts
{
    public interface IGemFactory
    {
        IGem CreateGem(string clarity, string gemType);
    }
}
