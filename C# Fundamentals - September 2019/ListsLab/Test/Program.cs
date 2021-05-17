using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Peter"); // добавяме елемент
            names.Add("Maria");
            names.Add("Misho");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(string.Join(", ", names));
            int count = names.Count; // взимаме броя на елементите
            Console.WriteLine(count);
            names.Remove("Peter"); // махаме елемент
            Console.WriteLine(string.Join(", ", names));
            names.RemoveAt(0);  // премахва елемент по индекс
            Console.WriteLine(string.Join(", ", names));
            names.Insert(1, "Tor"); // вмъква елемент на определена позиция, ако тя е заета, всички след нея заемат +1 позиция
            Console.WriteLine(string.Join(", ", names));
            bool a = names.Contains("Misho"); // проверява с true или false дали определен елемент съществува в листа
            Console.WriteLine(a);
            Console.WriteLine(names.Contains("Misho"));
            names.Sort();
            string test = "test";
            var newValue = test.Remove(2);  // маха всички позиции от посочената на горе включително
            Console.WriteLine(newValue);
            int num = names.IndexOf("Misho"); // взимаме на кой индекс е Misho и го слагаме на 0-ва позиция
            string text = names[num];
            names[0] = text;
            Console.WriteLine(names[0]);
            List<int> nums = new List<int> { 1, 2, 3 };
            Console.WriteLine(nums[1]);
            
        }
    }
}
