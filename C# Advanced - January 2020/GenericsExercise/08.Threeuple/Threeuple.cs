using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Threeuple
{
    public class Threeuple<TFirst, TSecond, TThird>
    {
        private TFirst firstItem;
        private TSecond secondItem;
        private TThird thirdItem;


        public Threeuple(TFirst firstItem, TSecond secondItem, TThird thirdItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
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

        public TSecond SecondItem
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

        public TThird ThirdItem
        {
            get
            {
                return this.thirdItem;
            }
            set
            {
                this.thirdItem = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem} -> {this.ThirdItem}";
        }
    }
}
