using _03._DependencyInversion.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._DependencyInversion.Models
{
    public class DivisionStrategy : ICalculationStrategy
    {
        public int Calculate(int leftOperand, int rightOperand)
        {
            return leftOperand / rightOperand;
        }
    }
}
