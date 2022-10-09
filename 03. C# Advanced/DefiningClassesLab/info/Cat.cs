using System;
using System.Collections.Generic;
using System.Text;

namespace info
{
    public class Cat
    {
        int mouseKilled;
        public void KillMouse()
        {
            mouseKilled++;
        }
        
        //public string Name { get; set; } // пропартита, винаги с главна буква, имат get i set и са public, за да могат да се ползват

        //public int Age { get; set; }

        //public string Color { get; set; }

        public string name; // field(поле) //публично // трябва винаги да са private
        private int age; // само за този клас
        private string color;

        //public string Name // конструктор
        //{
        //    get { return this.name; } //this означава да се вземе на текущия обект стойността

        //    set
        //    {
        //        if (value != null) //value е стойността, която се опитваме да запишем, или value.Length > 3....
        //        {
        //            this.name = value;
        //        }
        //    }
        //}
        //за Age и Color е само get

        public string SayMew()
        {
            return $"Mew from {this.name}";// ако имаме в този метод променлива name, и е без this няма да е ок, иначе става
        }

        // ако искаме да стане без пропартита:
        public string GetName() //с пропартитата се спестяват тези 2 метода:
        {
            return this.name;
        }
        public void SetName(string value)
        {
            if (value == null)
            {
                return;
            }
            this.name = value;
        }

    }
}
