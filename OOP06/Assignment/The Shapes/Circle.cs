using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.The_Shapes
{
    internal class Circle : ICircle
    {
        public const double Pi = 3.14;
        public double Radius { get; set; }
        public double Area { get { return Pi * Radius * Radius; } }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public string DisplayShapeInfo()
        {
            return $"Radious: {Radius} , Area = {Area}";
        }
    }
}
