using _09._InfernoInfinityRefactoringBonus.Contracts;
using _09._InfernoInfinityRefactoringBonus.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09._InfernoInfinityRefactoringBonus.Core.Factories
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
