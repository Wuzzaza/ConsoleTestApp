using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleTestApp.Classes
{

    class TestClass
    {
        private static int nextID;
        private readonly int ID;
        private string description { get; set; }

        static TestClass() => nextID = 0;

        public TestClass(string description = "")
        {
            this.description = description;
            ID = Interlocked.Increment(ref nextID);
        }

        public override string ToString() => $"ID: {ID}, Description: {description};";
        

    }
}
