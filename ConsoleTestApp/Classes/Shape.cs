using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTestApp.Interfaces;

namespace ConsoleTestApp.Classes
{
    abstract class Shape : IDrawable
    {
        private Point coordinates = new Point();

        protected int X { get => coordinates.X; set => coordinates.X = value; }
        protected int Y { get => coordinates.Y; set => Y = value; }

        public virtual void Draw()
        {
            Console.WriteLine($"Drawing {this.GetType()}");
            Console.WriteLine($"Coords: {coordinates.ToString()}");
        }

        sealed protected class Point
        {
            private int x, y;
            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
            public override string ToString() => $"X: {X}, Y: {Y}";
        }
    }

    sealed class Circle : Shape
    {
        private int radius;
        public int Radius { get => radius; set => radius = value; }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Radius: {Radius}");
        }
    }

    sealed class Square : Shape
    {
        private int width, height;
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Widht: {Width}");
            Console.WriteLine($"Height: {Height}");
        }
    }

    sealed class Triangle : Shape
    {

    }
}
