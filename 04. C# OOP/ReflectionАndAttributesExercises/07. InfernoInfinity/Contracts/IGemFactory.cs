using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Contracts
{
    public interface IGemFactory
    {
        IGem CreateGem(string clarity, string gemType);
    }
}
