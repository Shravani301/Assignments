using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsApp.Models
{
    public struct Rectangle:Shapes
    {
        public int width;
        public int height;
        public string Shape { get; set; }
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
            Shape = "Shape";
        }
        public string Display()
        {

            return $"Inside the {Shape} Display Method";
        }

    }

}
