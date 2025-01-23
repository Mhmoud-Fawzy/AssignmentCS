using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.The_Shapes
{
    internal class Rectangle : IRectangle
    {


        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double Area { get { return Length * Width; } }

        public string DisplayShapeInfo()
        {
            return $"Length = {Length} , Width = {Width} , Area = {Area}";
        }
    }
}
