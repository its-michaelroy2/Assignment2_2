using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2.Models
{
    internal class Square : Shape
    {
        public double SideLength { get; set; }

        public double CalculateArea(double side)
        {
            double area = 0;
            area = side * side;
            return area;
        }
    }
}
