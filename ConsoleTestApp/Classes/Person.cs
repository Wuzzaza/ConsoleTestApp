using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Classes
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person() { }

        public Person(string name) : this(name, 0) { }

        public override string ToString() => $"Name: {name}, Age: {age};";

    }
}
