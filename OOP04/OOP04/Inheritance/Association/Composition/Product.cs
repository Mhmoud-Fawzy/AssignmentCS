using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Inherintace.Association.Composition
{
    internal class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitOfStock { get; set; }



    }
}
