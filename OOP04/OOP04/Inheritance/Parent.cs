using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Inherintace
{
    internal class Parent
    {

        public int A { get; set; }
        internal int B { get; set; }
        protected int C { get; set; }
        internal protected int D { get; set; }
        private protected int E { get; set; }


        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"X= {X} Y= {Y}";
        }

        public virtual int Product()
        {
        return X * Y ; 
        }

        
   

    }
}
