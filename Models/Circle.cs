using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2.Models
{   //Created new class Circle that will inherit base class Shape
    public class Circle : Shape
    {
        //Added property Radius & method CalculateArea
        public double Radius { get; set; }

        public double CalculateArea(double radius)
        {
            double area = 0;
            area = Math.PI * radius * radius;
            return area;
        }
    }
}
