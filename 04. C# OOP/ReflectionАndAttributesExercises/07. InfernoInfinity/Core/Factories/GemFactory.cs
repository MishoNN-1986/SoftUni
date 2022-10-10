using _07._InfernoInfinity.Contracts;
using _07._InfernoInfinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Core.Factories
{
    public class GemFactory : IGemFactory
    {
        public IGem CreateGem(string clarity, string gemType)
        {
            GemClarity gemClarity = (GemClarity)Enum.Parse(typeof(GemClarity), clarity);

            Type classType = Type.GetType(gemType);

            IGem instance = (IGem)Activator.CreateInstance(classType, new object[] { gemClarity });

            return instance;
        }
    }
}
