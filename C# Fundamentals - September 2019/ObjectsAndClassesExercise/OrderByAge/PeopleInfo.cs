using System;
using System.Collections.Generic;
using System.Text;

namespace OrderByAge
{
    class PeopleInfo
    {
        public PeopleInfo(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
