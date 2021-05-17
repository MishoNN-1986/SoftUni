using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBoxes
{
    class Item
    {
        public Item()
        {
        }

        public Item(string name, double price)  //конструктор
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }   //пропартита (proparty)
        public double Price { get; set; }
    }
}
