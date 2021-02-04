using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesBrady.Models
{
    class Square : IMeasurable<Square>
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double Area()
        {
            double area = Math.Pow(Side, 2);
            return area;
        }

        public double Perimeter()
        {
            double perimeter = Side * 4;
            return perimeter;
        }
    }
}
