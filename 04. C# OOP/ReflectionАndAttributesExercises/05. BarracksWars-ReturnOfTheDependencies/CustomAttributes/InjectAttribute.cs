using System;
using System.Collections.Generic;
using System.Text;

namespace _05._BarracksWars_ReturnOfTheDependencies.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Field)]
    class InjectAttribute : Attribute
    {
    }
}
