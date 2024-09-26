using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructsApp.Models;

namespace StructsApp{

    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle1 = new Rectangle
            {
                width = 10,
                height = 20
            };

            rectangle1.width = 30;
            AreaOfRectangle(rectangle1 );
            rectangle1.Shape = "Rectangle";
            Console.WriteLine(rectangle1.Display());

            Rectangle rectangle2 = new Rectangle(10,5);
            AreaOfRectangle(rectangle2 );
        }
        static void AreaOfRectangle(Rectangle rectangle)
        {
            Console.WriteLine($"Area of the Rectangle is: " + (rectangle.width * rectangle.height));
        }
    }
}
