using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Classes
{
    

    public class A 
    {
        private static readonly Action action;

        public A(Action action)
        {

        }

        public static void Foo() => action(); 
    }

    public class B : A
    {
        private int a;
        public B(): base(()=> A.Foo() )
        {

        }
    }
}
