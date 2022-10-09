using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        private List<T> numbers; //с arr заема по-малко памет

        public Lake(params T[] elements)
        {
            this.numbers = new List<T>(elements);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < numbers.Count; i += 2)
            {
                yield return numbers[i];
            }
            int backwardsStartIndex = numbers.Count % 2 == 0 ? numbers.Count - 1 : numbers.Count - 2;
            for (int i = backwardsStartIndex; i >= 0; i -= 2)
            {
                yield return numbers[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
