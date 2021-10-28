using System;
using System.Collections;


namespace ConsoleTestApp.Classes
{
    public class TestExeption: ApplicationException
    {
        public TestExeption()
        {
            Console.WriteLine("New Test Exeption Created");
        }
    }

    class ExeptionClassTest
    {
        public static void Test()
        {
            TestExeption ex = new TestExeption();
            ex.Data.Add("TimeStamp", DateTime.Now);
            ex.Data.Add("Cause", "Test Purposes");
            throw ex;
        }
    }
}
