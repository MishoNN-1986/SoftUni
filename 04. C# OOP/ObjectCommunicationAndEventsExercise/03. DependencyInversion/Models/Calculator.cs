using _03._DependencyInversion.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._DependencyInversion.Models
{
    public class Calculator : ICalculator
    {
        private ICalculationStrategy calculationStrategy;

        public Calculator(ICalculationStrategy calculationStrategy)
        {
            ChangeStrategy(calculationStrategy);
        }

        public void ChangeStrategy(ICalculationStrategy calculationStrategy)
        {
            this.calculationStrategy = calculationStrategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.calculationStrategy.Calculate(firstOperand, secondOperand);
        }
    }
}
