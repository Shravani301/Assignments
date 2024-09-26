using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsApp.Models
{
    internal interface Shapes
    {
        string Shape {  get; set; }
        string Display();
    }
}
