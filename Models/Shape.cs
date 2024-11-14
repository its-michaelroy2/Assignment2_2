using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2.Models
{
    //Make abstract so Shape cannot be instantiated. Only inherited. Use other class that's not abstract. Is only Parent.
    public abstract class Shape
    {   //ShapeId, ShapeName, ShapeColor => good habit for clarity
        public string ShapeId { get; set; }
        public string ShapeName { get; set; }
        public string ShapeColor { get; set; }

        //Start with methods as void and then think about afterwards what it should be.
        public double CalculateArea(double input)
        {
            double area = 0;
            return area;
        }
    }
}
