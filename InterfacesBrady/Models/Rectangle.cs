using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesBrady.Models
{
    class Rectangle : IMeasurable<Rectangle>
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Area()
        {
            double area = Length * Width;
            return area;
        }

        public double Perimeter()
        {
            double perimeter = (Length * 2) + (Width * 2);
            return perimeter;
        }
    }
}
