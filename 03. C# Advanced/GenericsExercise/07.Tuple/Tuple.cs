using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class Tuple<TFirst, Tsecond>
    {
        private TFirst firstItem;
        private Tsecond secondItem;

        public Tuple(TFirst firstItem, Tsecond secondItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
        }

        public TFirst FirstItem
        {
            get
            {
                return this.firstItem;
            }
            set
            {
                this.firstItem = value;
            }
        }

        public Tsecond SecondItem
        {
            get
            {
                return this.secondItem;
            }
            set
            {
                this.secondItem = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem}";
        }
    }
}
