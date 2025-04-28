using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.The_Shapes
{
    internal interface IShape
    {
        public double Area { get; }

        string DisplayShapeInfo();
    }
}
