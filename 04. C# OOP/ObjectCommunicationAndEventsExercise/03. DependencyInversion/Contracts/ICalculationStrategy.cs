using System;
using System.Collections.Generic;
using System.Text;

namespace _03._DependencyInversion.Contracts
{
    public interface ICalculationStrategy
    {
        int Calculate(int leftOperand, int rightOperand);
    }
}
