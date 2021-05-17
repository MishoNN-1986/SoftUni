using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBoxes
{
    class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double TotalPrice
        {
            get
            {
                if (Item == null)
                {
                    return 0;
                }

                return Item.Price * ItemQuantity;
            }
        }

        public override string ToString()
        {
            return $"{SerialNumber}\n-- {Item.Name} - ${Item.Price:F2}: {ItemQuantity}\n-- ${TotalPrice:F2}";
        }
    }
}
