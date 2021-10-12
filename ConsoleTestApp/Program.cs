using System;
using ConsoleTestApp.Classes;

namespace ConsoleTestApp
{
    internal class Program
    {
        private enum EnumTest
        {
            One,
            Two,
            Three,
            Four
        }

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

        class DatabaseReader
        {
            public int? numencValue = null;
            public bool? boolValue = true;
            public int? GetIntFromDatabase()
            { return numencValue; }
            public bool? GetBoolFromDatabase()
            { return boolValue; }
        }

        private struct TestStruct
        {
            public int X { get; set; }
            public int Y { get; set; }

            public void Display()
            {
                Console.WriteLine($"X: {X}, Y: {Y}");
            }

        }


        static void Main(string[] args)
        {
            UnnecessaryParametersTest(name: "Admin");
            UnnecessaryParametersTest(1, "Me");

            ReturnModificatorTestFoo();

            EnumTestFoo();

            TestStructFoo();

            Person person = new Person("Sid", 60);
            Console.WriteLine(person.ToString());
            SendByValueTestFoo(person);
            Console.WriteLine(person.ToString());
            SendByReferenceTestFoo(ref person);
            Console.WriteLine(person.ToString());

            DatabaseReaderTestFoo();

            TuplesTestFoo();

             //Console.WriteLine(String.Join<TestClass>("\n", testClassesArray.));
            for (int i = 0; i < 5; i++) Console.WriteLine(new TestClass().ToString());

            Console.ReadKey();
        }

        private static void TuplesTestFoo()
        {
            var tuple = (12, "Wow", true);
            Console.WriteLine(tuple.ToString());
        }

        private static void ReturnModificatorTestFoo()
        {
            int x = 2;
            int y = 3;
            int result;

            Add(x, y, out result);
            Console.WriteLine($"{result}\n");
        }

        private static void EnumTestFoo()
        {
            EnumTest enumTest = EnumTest.Four;

            switch (enumTest)
            {
                case EnumTest.One:
                    break;
                case EnumTest.Two:
                    break;
                case EnumTest.Three:
                    break;
                case EnumTest.Four:
                    Console.WriteLine($"{enumTest}\n");
                    break;
                default:
                    break;
            }
            Console.WriteLine(enumTest.GetType());
            Console.WriteLine(Enum.GetUnderlyingType(enumTest.GetType()));

            foreach (var str in Enum.GetValues(typeof(EnumTest)))
            {
                Console.Write($"{str} \t");
            }
            Console.WriteLine(); ;
        }

        private static void TestStructFoo()
        {
            TestStruct testStruct = new TestStruct();
            testStruct.Display();
            TestStruct testStruct2 = testStruct;
            testStruct.X = 1;
            testStruct.Y = 1;
            testStruct.Display();
            testStruct2.Display();

        }

        private static void Add(int x, int y, out int result)
        {
            result = x + y;
        }

        private static void UnnecessaryParametersTest(int ID = 0, string name = "Admin")
        {
            Console.WriteLine($"{ID}: {name}\n");
        }

        private static void SendByValueTestFoo(Person person)
        {
            person.age = 80;
            person = new Person("John", 40);
        }

        private static void SendByReferenceTestFoo(ref Person person)
        {
            person.age = 80;
            person = new Person("John", 40);
        }

        private static void DatabaseReaderTestFoo()
        {
            DatabaseReader databaseReader = new DatabaseReader();
            int? i = databaseReader.GetIntFromDatabase();

            if (i.HasValue)
            {
                Console.WriteLine($"Value is: {i}\n");
            }
            else
            {
                Console.WriteLine($"Value is udentified\n");
            }

            int data = databaseReader.GetIntFromDatabase() ?? 100;
            Console.WriteLine($"Value is: {data}\n");

        }


    }

    
}
