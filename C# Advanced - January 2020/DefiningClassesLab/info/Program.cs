using System;

namespace info
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(); // описват се данните, cat е обект
            //{
            //    Name = "Pesho",
            //    Age = 18,
            //    Color = "Black"
            //};
            //cat.KillMouse(); // +1
            //Console.WriteLine(cat.Name);

            //var secondCat = new Cat(); // празен конструктор, котки могат да се създават без данни
            //secondCat.Name = "Gosho";
            //Console.WriteLine(secondCat.Name);
            //Cat anotherCat = new Cat() // 3-ти начин 
            //{
            //    Name = "Kelesh"
            //};
            //Console.WriteLine(anotherCat.Name);
            cat.SetName("Pesho"); // ако е без пропартита
            Console.WriteLine(cat.GetName());
        }
    }
}
