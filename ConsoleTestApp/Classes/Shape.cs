using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTestApp.Interfaces;

namespace ConsoleTestApp.Classes
{
    class Shape : Drawable
    {
        public void Draw()
        {
            Console.WriteLine($"Drawing {this.GetType()}");
        }
    }

    class Circle : Shape
    {

    }

    class Square : Shape
    {

    }

    class Triangle : Shape
    {

    }
}
