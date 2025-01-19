using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Inherintace
{
    internal class Child : Parent
    {

        public int F { get; set; }
        public int G { get; set; }

        public int Z { get; set; }
        public Child(int x, int y,int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"X= {X} Y= {Y} Z= {Z}";
        }

        public override int Product()
        {
            return base.Product()*Z;
        }


    }
}
