using System.Collections;

namespace ConsoleTestApp.Classes
{
    class Canvas : IEnumerable
    {
        Shape[] shapes;
        public Shape[] Shapes { get; set; }

        public Canvas() { }
        public Canvas(Shape[] shapes) => this.shapes = shapes;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return shapes.GetEnumerator();
        }
    }
}
