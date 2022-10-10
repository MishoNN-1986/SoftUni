using System;
using System.Collections.Generic;
using System.Text;

namespace _03._DependencyInversion.Contracts
{
    public interface ICalculator
    {
        int PerformCalculation(int firstOperand, int secondOperand);

        void ChangeStrategy(ICalculationStrategy calculationStrategy);
    }
}
